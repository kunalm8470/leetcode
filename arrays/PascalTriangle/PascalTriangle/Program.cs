using System;
using System.Collections.Generic;
using System.Linq;

namespace PascalTriangle
{
    class Program
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            if (numRows == 0)
            {
                return new List<IList<int>> { };
            }

            var seedTriangle = new List<IList<int>>
            {
                new List<int> { 1 },
                new List<int> { 1, 1 }
            };

            if (numRows == 1)
            {
                seedTriangle.RemoveAt(1);
                return seedTriangle;
            }

            if (numRows == 2)
            {
                return seedTriangle;
            }

            for (int i = 2; i < numRows; i++)
            {
                int previousRowIdx = i - 1;
                List<int> currentRow = new List<int> { 1 };
                                
                for (int j = 0; j < previousRowIdx; j++)
                {
                    currentRow.Add(seedTriangle[previousRowIdx][j] + seedTriangle[previousRowIdx][j + 1]);
                }
                currentRow.Add(1);

                seedTriangle.Add(currentRow);
            }

            return seedTriangle;
        }

        static void Main(string[] args)
        {
            int numRows = 6;
            var pascalTraingle = Generate(numRows);
        }
    }
}
