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
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;
            string[,] mtrx = new string[rows, cols];
            string[] line;
            for (int i = 0; i < rows; i++)
            {
                line = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    mtrx[i, j] = line[j];
                }
            }
            return mtrx;
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
        public string[,] SortNumber(string[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;

            // Создаем массив индексов от 0 до rows - 1
            int[] indices = Enumerable.Range(0, rows).ToArray();

            // Сортируем индексы по значениям в первом столбце (по номеру)
            Array.Sort(indices, (i, j) => string.Compare(array[i, 0], array[j, 0]));

            // Создаем новый массив для результата
            string[,] res = new string[rows, 8];

            // Копируем строки из исходного массива в новый в порядке отсортированных индексов
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    res[i, j] = array[indices[i], j];
                }
            }

            return res;
        }

    }
}
