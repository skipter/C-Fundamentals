using System;
using System.Linq;

namespace _02.DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main()
        {
            int dimensions = Int32.Parse(Console.ReadLine());
            long[,] matrix = new long[dimensions, dimensions];

            //Matrix input
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                long[] numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(Int64.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            //Left diagonal
            long sumLeft = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                   if (row == col)
                    {
                        sumLeft += matrix[row, col];
                    }
                }
            }

            //Right diagonal
            long sumRight = 0;
            for (int row = 0; row < dimensions; row++)
            {
                for (int col = dimensions - 1; col >= 0; col--)
                {
                    if (col == Math.Abs(row - dimensions + 1))
                    {
                        sumRight += matrix[row, col];
                    }
                }
            }
            long result = sumLeft - sumRight;
            Console.WriteLine(Math.Abs(result));
        }
    }
}
