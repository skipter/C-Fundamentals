using System;
using System.Linq;

namespace _05.SquareWIthMaximumSum
{
    class SquareWithMaximumSum
    {
        static void Main()
        {
            int[] sizes = Console.ReadLine()      //Matrix size.
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]]; //Initial matrix size.

            int maxSum = Int32.MinValue;
            int rowIndex = 0;
            int colIndex = 0;

            for (int row = 0; row < matrix.GetLength(0); row++) //Read input and inital columns.
            {
                int[] columnElements = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnElements[col];
                }
            }
            //The logic. We look in the matrix to GetLength() - 1 -> this will not throw an exeption. 
            //If it is only GetLength(), when it comes to the last element to check it will try to check the next one and throw an exeption.
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + //First row (0 index) and the element(0, 0 indexes) + same row and next element (0, 1 indexes)
                        matrix[row + 1, col] + matrix[row + 1, col + 1];//Next row, col (element on 1,0 indexes) + same row , col (1,1 indexes).

                    if (sum > maxSum)   //maxSum = Int32.MinValue.
                    {
                        maxSum = sum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }
            #region Print Result
            //Print the result. Print the smell matrix with maximum sum.
            for (int row = rowIndex; row < rowIndex + 2; row++)
            {
                for (int col = colIndex; col < colIndex + 2; col++)
                {
                    Console.Write($"{matrix[row, col]} "); //Direct from the matrix/
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
            #endregion
        }
    }
}
