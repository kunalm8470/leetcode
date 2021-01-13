using System;
using System.Collections.Generic;
using System.Linq;

namespace PascalTriangle2
{
    class Program
    {
        public static IList<int> GetRow(int rowIndex)
        {
            if (rowIndex == 0)
            {
                return new List<int> { 1 };
            }

            int[][] seedTriangle = new int[rowIndex + 1][];

            for (int i = 0; i <= rowIndex; i++)
            {
                seedTriangle[i] = new int[i + 1];

                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0 || j == i)
                    {
                        seedTriangle[i][j] = 1;
                    }

                    else
                    {
                        seedTriangle[i][j] = seedTriangle[i - 1][j - 1] + seedTriangle[i - 1][j];
                    }
                }
            }

            return seedTriangle[rowIndex].ToList();
        }

        static void Main(string[] args)
        {
            int rowIndex = 3;
            IList<int> triangleRow = GetRow(rowIndex);
        }
    }
}
