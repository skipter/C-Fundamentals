using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SumMatrixElements
{
    class SumMatrixElements
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray(); ;

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                //Input column element.
                int[] columnElements = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnElements[col];
                }
            }
            Print(matrix.GetLength(0));
            Print(matrix.GetLength(1));
            //Sum all elements in matrix
            int sum = 0;

            foreach (var element in matrix)
            {
                sum += element;
            }
            Print(sum);
        }
        //Print method
        static void Print(int input) //For different input you can use dynamic, but its not good practise. 
        {
            Console.WriteLine(input);
        }
    }
}
