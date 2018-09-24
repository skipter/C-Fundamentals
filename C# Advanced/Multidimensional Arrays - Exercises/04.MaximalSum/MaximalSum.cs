using System;
using System.Linq;

namespace _04.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {   //Matrix dimensions input
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray();

            long[,] matrix = new long[dimensions[0], dimensions[1]];//Declare dimensions
            //Fill the matrix with column elements
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                long[] columnElements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int64.Parse)
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnElements[col];
                }
            }

            //The logic to find 3x3 square with maximal sum ot elements.
            long maxSum = Int64.MinValue;
            int rowIndex = 0;
            int colIndex = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)     // GetLenght - 2 !!!
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++) // GetLenght - 2 !!! //+2
                {
                    long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                               matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + // 3x3
                               matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > maxSum) //if sum is bigger than maxSum(min.value = - 22222222.....)
                    {
                        maxSum = sum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            //Printing the result
            Console.WriteLine($"Sum = {maxSum}");   //print the sum

            for (int row = rowIndex; row < rowIndex + 3; row++)
            {
                for (int col = colIndex; col < colIndex + 3; col++)
                {
                    Console.Write($"{matrix[row, col]} "); //Printing direct from the matrix.
                }
                Console.WriteLine();                        //Empty line between rows.
            }
        }
    }
}
