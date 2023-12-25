using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TarasovVD.Sprint7.Project.V5.Lib;
using System.IO;

namespace Tyuiu.TarasovVD.Sprint7.Project.V5
{
    public partial class FormInstrument : Form
    {
        public FormInstrument()
        {
            InitializeComponent();
        }
        public static string[,] LoadFromFileData(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }

            return arrayValues;
        }

        DataService ds = new DataService();
        public static string path = @"C:\Project\ОПТОВАЯ БАЗА.csv";

        
        private void LoadDataInfoDataGridView(string filePath)
        {
            string[,] dataArray = LoadFromFileData(filePath);


            dataGridViewInPutData_TVD.Rows.Clear();
            dataGridViewInPutData_TVD.Columns.Clear();


            for (int i = 0; i < dataArray.GetLength(1); i++)
            {
                dataGridViewInPutData_TVD.Columns.Add("", dataArray[0, i]);
            }


            for (int i = 1; i < dataArray.GetLength(0); i++)
            {
                List<string> rowData = new List<string>();
                for (int j = 0; j < dataArray.GetLength(1); j++)
                {
                    rowData.Add(dataArray[i, j]);
                }
                dataGridViewInPutData_TVD.Rows.Add(rowData.ToArray());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogTask = new OpenFileDialog();
            openFileDialogTask.Filter = "csv Files|*.csv";
            if (openFileDialogTask.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialogTask.FileName;


                LoadDataInfoDataGridView(filePath);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_TVD.FileName = "NewDataGrid.csv";
            saveFileDialogMatrix_TVD.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_TVD.ShowDialog();

            string path = saveFileDialogMatrix_TVD.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewInPutData_TVD.RowCount;
            int columns = dataGridViewInPutData_TVD.ColumnCount;
            for (int i = 0; i < rows; i++)
            {
                string str = "";
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewInPutData_TVD.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewInPutData_TVD.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridViewInPutData_TVD.ReadOnly != true || dataGridViewInfoMan_TVD.ReadOnly != true)
            {
                dataGridViewInPutData_TVD.ReadOnly = true;
                dataGridViewInfoMan_TVD.ReadOnly = true;
                MessageBox.Show("Ручное изменение заблокировано", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridViewInPutData_TVD.ReadOnly = false;
                dataGridViewInfoMan_TVD.ReadOnly = false;
                MessageBox.Show("Ручное изменение разблокировано", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            string productNameToDelete = textBoxDeleteProduct_TVD.Text.Trim();

            if (!string.IsNullOrEmpty(productNameToDelete))
            {
                bool productFound = false;

                foreach (DataGridViewRow row in dataGridViewInPutData_TVD.Rows)
                {
                    if (row.Cells["Column1"].Value != null && row.Cells["Column1"].Value.ToString() == productNameToDelete)
                    {
                        dataGridViewInPutData_TVD.Rows.Remove(row);
                        productFound = true;
                        break;
                    }
                }

                if (!productFound)
                {
                    MessageBox.Show("Товар с указанным названием не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Товар успешно удален", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Введите название товара для удаления", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void buttonOpenFile_TVD_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_TVD.ToolTipTitle = "Открыть файл";
        }
        private void buttonSaveFile_TVD_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_TVD.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_TVD_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_TVD.ToolTipTitle = "Справка";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAboutInstrument formAboutInstrument = new FormAboutInstrument();
            formAboutInstrument.Show();
        }


        private void buttonAdd_TVD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName_TVD.Text) ||
    string.IsNullOrWhiteSpace(textBoxCost_TVD.Text) ||
    string.IsNullOrWhiteSpace(textBoxCount_TVD.Text) ||
    string.IsNullOrWhiteSpace(textBoxInfo_TVD.Text))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[,] DataTable = ds.GetMatrix(path);

                bool Product = ds.ProductExist(DataTable, textBoxName_TVD.Text);

                if (Product)
                {
                    MessageBox.Show("Данный товар уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!ColumnsExist(dataGridViewInPutData_TVD))
                    {
                        dataGridViewInPutData_TVD.Columns.Add("Column0", "Номер товара");
                        dataGridViewInPutData_TVD.Columns.Add("Column1", "Название товара");
                        dataGridViewInPutData_TVD.Columns.Add("Column2", "Количество на складе");
                        dataGridViewInPutData_TVD.Columns.Add("Column3", "Стоимость единицы товара");
                        dataGridViewInPutData_TVD.Columns.Add("Column4", "Примечания - описание товара");
                    }
                    int lastRowIndex = dataGridViewInPutData_TVD.Rows.Add();
                    if (lastRowIndex >= 0)
                    {
                        dataGridViewInPutData_TVD.Rows[lastRowIndex].Cells[0].Value = (lastRowIndex + 1).ToString();
                        dataGridViewInPutData_TVD.Rows[lastRowIndex].Cells[1].Value = textBoxName_TVD.Text;
                        dataGridViewInPutData_TVD.Rows[lastRowIndex].Cells[2].Value = textBoxCount_TVD.Text;
                        dataGridViewInPutData_TVD.Rows[lastRowIndex].Cells[3].Value = textBoxCost_TVD.Text;
                        dataGridViewInPutData_TVD.Rows[lastRowIndex].Cells[4].Value = textBoxInfo_TVD.Text;
                    }
                    textBoxName_TVD.Text = "";
                    textBoxCost_TVD.Text = "";
                    textBoxInfo_TVD.Text = "";
                    textBoxCount_TVD.Text = "";

                    MessageBox.Show("Товар занесен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            


        }
        private bool ColumnsExist(DataGridView dataGridView)
        {
            return dataGridView.Columns.Count > 0;
        }

        private void buttonAddInfo_TVD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFIO_TVD.Text) ||
        string.IsNullOrWhiteSpace(textBoxDataProduct_TVD.Text) ||
        string.IsNullOrWhiteSpace(textBoxCountProduct_TVD.Text))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string FIO = textBoxFIO_TVD.Text;

            if (!ds.ValidateFIO(FIO))
            {
                MessageBox.Show("ФИО введено некорректно. Пожалуйста, введите в формате \"Фамилия Имя Отчество\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFIO_TVD.Text = "";
                return;
            }
            string data = textBoxDataProduct_TVD.Text;
            if (!ds.ValidateData(data))
            {
                MessageBox.Show("Дата введена не правильно, введите в формате \"дд.мм.гггг\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDataProduct_TVD.Text = "";
                return;
            }

            string[,] DataTable = ds.GetMatrix(path);


            {
                if (!dataGridViewInfoMan_TVD.Columns.Contains("Column1"))
                {
                    dataGridViewInfoMan_TVD.Columns.Add("Column1", "ФИО поставщика");
                    dataGridViewInfoMan_TVD.Columns.Add("Column2", "Срок доставки");
                    dataGridViewInfoMan_TVD.Columns.Add("Column3", "Количество товара");
                }

                int lastRowIndex = dataGridViewInfoMan_TVD.Rows.Add();


                if (lastRowIndex >= 0)
                {
                    dataGridViewInfoMan_TVD.Rows[lastRowIndex].Cells[0].Value = textBoxFIO_TVD.Text;
                    dataGridViewInfoMan_TVD.Rows[lastRowIndex].Cells[1].Value = textBoxDataProduct_TVD.Text;
                    dataGridViewInfoMan_TVD.Rows[lastRowIndex].Cells[2].Value = textBoxCountProduct_TVD.Text;
                }
                textBoxFIO_TVD.Text = "";
                textBoxDataProduct_TVD.Text = "";
                textBoxCountProduct_TVD.Text = "";
                MessageBox.Show("Поставщик занесен в базу", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonDeleteInfoMan_TVD_Click(object sender, EventArgs e)
        {
            string NameToDelete = textBoxDeleteInfoMan_TVD.Text.Trim();

            if (!string.IsNullOrEmpty(NameToDelete))
            {
                bool NameFound = false;

                foreach (DataGridViewRow row in dataGridViewInfoMan_TVD.Rows)
                {
                    if (row.Cells["Column1"].Value != null && row.Cells["Column1"].Value.ToString() == NameToDelete)
                    {
                        dataGridViewInfoMan_TVD.Rows.Remove(row);
                        NameFound = true;
                        break;
                    }
                }

                if (!NameFound)
                {
                    MessageBox.Show("ФИО не найдено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Поставщик успешно удален", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Введите ФИО поставщика для удаления", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void buttonReturn_TVD_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_TVD.ToolTipTitle = "Вернуться";
        }

        private void buttonEditHeaders_TVD_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_TVD.ToolTipTitle = "Редактирование";
        }

        private void buttonAdd_TVD_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_TVD.ToolTipTitle = "Добавить";
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_TVD.ToolTipTitle = "Удалить";
        }

        private void buttonAddInfo_TVD_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_TVD.ToolTipTitle = "Добавить";
        }

        private void buttonDeleteInfoMan_TVD_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_TVD.ToolTipTitle = "Удалить";
        }

        private void textBoxSearch_TVD_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch_TVD.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewInPutData_TVD.Rows)
            {
                if (row.IsNewRow) continue; 

                bool found = false;

                for (int j = 0; j < dataGridViewInPutData_TVD.Columns.Count; j++)
                {
                    if (row.Cells[j].Value != null && row.Cells[j].Value.ToString().ToLower().Contains(searchValue))
                    {
                        found = true;
                        break;
                    }
                }

                row.Visible = found; 
            }
        }

        private void textBoxNameSearch_TVD_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxNameSearch_TVD.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewInfoMan_TVD.Rows)
            {
                if (row.IsNewRow) continue;

                bool found = false;

                for (int j = 0; j < dataGridViewInfoMan_TVD.Columns.Count; j++)
                {
                    if (row.Cells[j].Value != null && row.Cells[j].Value.ToString().ToLower().Contains(searchValue))
                    {
                        found = true;
                        break;
                    }
                }

                row.Visible = found;
            }
        }

        private void buttonStats_TVD_Click(object sender, EventArgs e)
        {
            FormStats formStats = new FormStats();
            formStats.Show();
        }
    }
    
}
