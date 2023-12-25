using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Tyuiu.TarasovVD.Sprint7.Project.V5.Lib
{
    public class DataService
    {

        public string[,] GetMatrix(string path)
        {
            string[] str = File.ReadAllLines(path);
            int columns = str.Any() ? str.Max(line => line.Split(';').Length) : 0;
            int rows = str.Length;

            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] strArr = str[i].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    if (c < strArr.Length)
                    {
                        matrix[i, c] = strArr[c];
                    }
                    else
                    {
                        matrix[i, c] = "Отсутствует";
                    }
                }
            }
            return matrix;
        }


        public bool ValidateFIO(string input)
        {
            string[] parts = input.Split(' ');
            if (parts.Length == 3 && !string.IsNullOrWhiteSpace(parts[0]) && !string.IsNullOrWhiteSpace(parts[1]) && !string.IsNullOrWhiteSpace(parts[2]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidateData(string input)
        {
            string[] parts = input.Split('.');

            if (parts.Length == 3 &&
                parts[0].Length == 2 && parts[1].Length == 2 && parts[2].Length == 4 &&
                int.TryParse(parts[0], out int day) &&
                int.TryParse(parts[1], out int month) &&
                int.TryParse(parts[2], out int year) &&
                day >= 1 && day <= 31 &&
                month >= 1 && month <= 12 &&
                year >= 1000 && year <= 9999)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ProductExist(string[,] DataTable, string Product)
        {
            bool b = false;
            for (int i = 1; i < DataTable.GetLength(0); i++)
            {
                if (Product == DataTable[i, 1])
                    b = true;
            }
            return b;
        }
        
    }
}
