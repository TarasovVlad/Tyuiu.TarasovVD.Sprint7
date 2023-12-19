﻿using System;
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
        static int rows;
        static int colums;
        static string openFilePath;
        DataService ds = new DataService();

        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }

            return arrayValues;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            
            openFileDialogTask_TVD.ShowDialog();
            openFilePath = openFileDialogTask_TVD.FileName;
            string[,] arrayValues = new string[rows, colums];
            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewInPutData_TVD.ColumnCount = colums;
            dataGridViewInPutData_TVD.RowCount = rows;
            
            for (int i = 0; i < colums; i++)
            {
                dataGridViewInPutData_TVD.Columns[i].Width = 100;
                
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInPutData_TVD.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            button2.Enabled = true;
            SetDataGridViewHeaders();
        }
        private void SetDataGridViewHeaders()
        {
            string[] headers = { "Код товара", "Название товара", "Количество на складе", "Стоимость единицы товара", "Примечания - описание товара" };

            for (int i = 0; i < headers.Length; i++)
            {
                dataGridViewInPutData_TVD.Columns[i].HeaderText = headers[i];
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_TVD.FileName = "OutPutFile.csv";
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
            string str = "";
            for (int i = 0; i < rows; i++)
            {
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
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}
