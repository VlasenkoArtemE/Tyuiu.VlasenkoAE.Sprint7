using System.IO;

namespace Tyuiu.VlasenkoAE.Sprint7.Project.V12.Lib
{
    public class DataService
    {
        public int GetMaxPrice(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(";").Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_i = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(line_i[j]);
                }
            }

            int maxPrice = 0;
            int priceColumn = 4;

            for (int r = 0; r < rows; r++)
            {
                if (matrix[r, priceColumn] > maxPrice)
                    maxPrice = matrix[r, priceColumn];
            }
            return maxPrice;
        }

        public int GetMinPrice(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(";").Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_i = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(line_i[j]);
                }
            }

            int priceColumn = 4;
            int minPrice = matrix[0, priceColumn];

            for (int r = 1; r < rows; r++)
            {
                if (matrix[r, priceColumn] < minPrice)
                    minPrice = matrix[r, priceColumn];
            }
            return minPrice;
        }
    }
}
