using System.IO;
using System.Numerics;

namespace Tyuiu.VlasenkoAE.Sprint7.Project.V12.Lib
{
    public class DataService
    {
        public int GetMaxPrice(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;   // количество строк
            int columns = matrix.Length / rows;       // количество столбцов

            int maxPrice = 0;
            int priceColumn = 4;

            for (int r = 0; r < rows; r++)
            {
                if (matrix[r, priceColumn] > maxPrice)
                    maxPrice = matrix[r, priceColumn];
            }
            return maxPrice;
        }

        public int GetMinPrice(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

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
