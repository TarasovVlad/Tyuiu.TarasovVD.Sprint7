using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.TarasovVD.Sprint7.Project.V5.Lib;
using System.IO;


namespace Tyuiu.TarasovVD.Sprint7.Project.V5
{
    public partial class FormInstrument : Form
    {
        public FormInstrument()
        {
            InitializeComponent();
            SetDataGridViewHeaders();
            SetDataFormatColumns();
            openFileDialogTask_TVD.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            openFileDialogTask_TVD.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }



        DataService ds = new DataService();
        public static string path = @"C:\Project\ОПТОВАЯ БАЗА.csv";
        private void SetDataGridViewHeaders()
        {
            if (dataGridViewInPutData_TVD.Columns.Count == 0)
            {
                dataGridViewInPutData_TVD.Columns.Add("Column0", "Номер товара");
                dataGridViewInPutData_TVD.Columns.Add("Column1", "Название товара");
                dataGridViewInPutData_TVD.Columns.Add("Column2", "Количество на складе");
                dataGridViewInPutData_TVD.Columns.Add("Column3", "Стоимость единицы товара");
                dataGridViewInPutData_TVD.Columns.Add("Column4", "Примечания - описание товара");
                dataGridViewInPutData_TVD.Columns.Add("Column5", "Номер поставщика");
                dataGridViewInPutData_TVD.Columns.Add("Column6", "ФИО поставщика");
                dataGridViewInPutData_TVD.Columns.Add("Column7", "Срок поставки");
            }
            else
            {
                dataGridViewInPutData_TVD.Columns["Column0"].HeaderText = "Номер товара";
                dataGridViewInPutData_TVD.Columns["Column1"].HeaderText = "Название товара";
                dataGridViewInPutData_TVD.Columns["Column2"].HeaderText = "Количество на складе";
                dataGridViewInPutData_TVD.Columns["Column3"].HeaderText = "Стоимость единицы товара";
                dataGridViewInPutData_TVD.Columns["Column4"].HeaderText = "Примечания - описание товара";
                dataGridViewInPutData_TVD.Columns["Column5"].HeaderText = "Номер поставщика";
                dataGridViewInPutData_TVD.Columns["Column6"].HeaderText = "ФИО поставщика";
                dataGridViewInPutData_TVD.Columns["Column7"].HeaderText = "Срок поставки";
            }
        }
        private void SetDataFormatColumns()
        {
            dataGridViewInPutData_TVD.Columns[0].DefaultCellStyle.Format = "N0";
            dataGridViewInPutData_TVD.Columns[1].DefaultCellStyle.Format = "G";
            dataGridViewInPutData_TVD.Columns[2].DefaultCellStyle.Format = "G";
            dataGridViewInPutData_TVD.Columns[3].DefaultCellStyle.Format = "N2";
            dataGridViewInPutData_TVD.Columns[4].DefaultCellStyle.Format = "G";
            dataGridViewInPutData_TVD.Columns[5].DefaultCellStyle.Format = "N0";
            dataGridViewInPutData_TVD.Columns[6].DefaultCellStyle.Format = "G";
            dataGridViewInPutData_TVD.Columns[7].DefaultCellStyle.Format = "D";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_TVD.ShowDialog();
                string path = openFileDialogTask_TVD.FileName;
                string[,] array = ds.GetMatrix(path);

                int rows = array.GetLength(0);
                int columns = array.GetLength(1);
                dataGridViewInPutData_TVD.RowCount = rows;
                dataGridViewInPutData_TVD.ColumnCount = columns;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewInPutData_TVD.Rows[i].Cells[j].Value = array[i, j];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_TVD.FileName = "OutPutFileProjectV5.csv";
            saveFileDialogMatrix_TVD.InitialDirectory = Directory.GetCurrentDirectory();
            if (saveFileDialogMatrix_TVD.ShowDialog() == DialogResult.OK)
            {
                string outPath = saveFileDialogMatrix_TVD.FileName;
                try
                {
                    using (StreamWriter sw = new StreamWriter(outPath, false, Encoding.UTF8))
                    {
                        for (int i = 0; i < dataGridViewInPutData_TVD.RowCount; i++)
                        {
                            for (int j = 0; j < dataGridViewInPutData_TVD.ColumnCount; j++)
                            {
                                if (j != dataGridViewInPutData_TVD.ColumnCount - 1)
                                {
                                    sw.Write(dataGridViewInPutData_TVD.Rows[i].Cells[j].Value + ";");
                                }
                                else
                                {
                                    sw.Write(dataGridViewInPutData_TVD.Rows[i].Cells[j].Value);
                                }
                            }
                            sw.WriteLine();
                        }
                    }
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridViewInPutData_TVD.ReadOnly != true)
            {
                dataGridViewInPutData_TVD.ReadOnly = true;
                MessageBox.Show("Ручное изменение заблокировано", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridViewInPutData_TVD.ReadOnly = false;
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
            string.IsNullOrWhiteSpace(textBoxInfo_TVD.Text) ||
            string.IsNullOrWhiteSpace(textBoxFIO_TVD.Text) ||
            string.IsNullOrWhiteSpace(textBoxNumber_TVD.Text) ||
            string.IsNullOrWhiteSpace(textBoxDataProduct_TVD.Text))

            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                string[,] DataTable = ds.GetMatrix(path);
                if (!ColumnsExist(dataGridViewInPutData_TVD))
                {
                    dataGridViewInPutData_TVD.Columns.Add("Column0", "Номер товара");
                    dataGridViewInPutData_TVD.Columns.Add("Column1", "Название товара");
                    dataGridViewInPutData_TVD.Columns.Add("Column2", "Количество на складе");
                    dataGridViewInPutData_TVD.Columns.Add("Column3", "Стоимость единицы товара");
                    dataGridViewInPutData_TVD.Columns.Add("Column4", "Примечания - описание товара");
                    dataGridViewInPutData_TVD.Columns.Add("Column5", "Номер поставщика");
                    dataGridViewInPutData_TVD.Columns.Add("Column6", "ФИО поставщика");
                    dataGridViewInPutData_TVD.Columns.Add("Column7", "Срок поставки");
                }
                int lastRowIndex = dataGridViewInPutData_TVD.Rows.Add();
                if (lastRowIndex >= 0)
                {
                    dataGridViewInPutData_TVD.Rows[lastRowIndex].Cells[0].Value = Convert.ToInt32(lastRowIndex + 1);
                    dataGridViewInPutData_TVD.Rows[lastRowIndex].Cells[1].Value = textBoxName_TVD.Text;
                    dataGridViewInPutData_TVD.Rows[lastRowIndex].Cells[2].Value = textBoxCount_TVD.Text;
                    dataGridViewInPutData_TVD.Rows[lastRowIndex].Cells[3].Value = textBoxCost_TVD.Text;
                    dataGridViewInPutData_TVD.Rows[lastRowIndex].Cells[4].Value = textBoxInfo_TVD.Text;
                    dataGridViewInPutData_TVD.Rows[lastRowIndex].Cells[5].Value = textBoxNumber_TVD.Text;
                    dataGridViewInPutData_TVD.Rows[lastRowIndex].Cells[6].Value = textBoxFIO_TVD.Text;
                    dataGridViewInPutData_TVD.Rows[lastRowIndex].Cells[7].Value = textBoxDataProduct_TVD.Text;
                }
                textBoxName_TVD.Text = "";
                textBoxCost_TVD.Text = "";
                textBoxInfo_TVD.Text = "";
                textBoxCount_TVD.Text = "";
                textBoxFIO_TVD.Text = "";
                textBoxDataProduct_TVD.Text = "";
                textBoxNumber_TVD.Text = "";

                MessageBox.Show("Товар занесен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool ColumnsExist(DataGridView dataGridView)
        {
            return dataGridView.Columns.Count > 0;
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

        

        private void buttonStats_TVD_Click(object sender, EventArgs e)
        {
            string countText = textBoxCountP_TVD.Text;
            string SumText = textBoxSum_TVD.Text;

            if (!int.TryParse(countText, out int count) ||
                !int.TryParse(SumText, out int sum))
 
            {
                MessageBox.Show("Ошибка преобразования значений", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            chartStats_TVD.Series.Clear();
            Series series = new Series("Статистика");
            series.Points.AddXY("Кол-во", count);
            series.Points.AddXY("Общее кол-во", sum);
            chartStats_TVD.Series.Add(series);
            chartStats_TVD.Invalidate();
        }
        
        private void buttonSortNumberProduct_TVD_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBoxSort_TVD.Text, out int columnIndex) || columnIndex < 0 || columnIndex >= dataGridViewInPutData_TVD.Columns.Count)
            {
                MessageBox.Show("Введите корректный номер столбца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridViewInPutData_TVD.Sort(dataGridViewInPutData_TVD.Columns[columnIndex], ListSortDirection.Ascending);
        }
        private void CalculateStatistics()
        {
 
            if (dataGridViewInPutData_TVD.Rows.Count == 0)
            {
                MessageBox.Show("Таблица пуста", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int columnIndex = 2;
            double[] numericValues = new double[dataGridViewInPutData_TVD.Rows.Count];

            for (int i = 0; i < dataGridViewInPutData_TVD.Rows.Count; i++)
            {
                if (dataGridViewInPutData_TVD.Rows[i].Cells[columnIndex].Value != null &&
                    double.TryParse(dataGridViewInPutData_TVD.Rows[i].Cells[columnIndex].Value.ToString(), out double value))
                {
                    numericValues[i] = value;
                }
                else
                {
                    numericValues[i] = 0;
                }
            }

            int count = numericValues.Length;
            double sum = numericValues.Sum();
            double average = count > 0 ? sum / count : 0;
            double min = numericValues.Min();
            double max = numericValues.Max();
            textBoxCountP_TVD.Text = count.ToString();
            textBoxSum_TVD.Text = sum.ToString();
            textBoxAverage_TVD.Text = average.ToString();
            textBoxmin_TVD.Text = min.ToString();
            textBoxMax_TVD.Text = max.ToString();
        }
        private void buttonCalculateStats_Click(object sender, EventArgs e)
        {
            CalculateStatistics();
        }


    }
    
}
