using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class SumMatrixCoumns
    {
        static void Main()
        {
            //Read matrix size
            int[] sizes = Console.ReadLine()
                 .Split(',', StringSplitOptions.RemoveEmptyEntries)
                 .Select(Int32.Parse)
                 .ToArray();
            //Initial matrix size
            //Initial matrix size
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                //Read column elements
                int[] columnElements = Console.ReadLine()
                    .Split() //Must careful with input, here is only with whitespaces, if there is a comma between nums, it will throw an exeption.
                    .Select(Int32.Parse)
                    .ToArray();
                //Initial column elements
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnElements[col];
                }
            }
            //Sum every number by column and print it, we exchange places of row and col.
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
