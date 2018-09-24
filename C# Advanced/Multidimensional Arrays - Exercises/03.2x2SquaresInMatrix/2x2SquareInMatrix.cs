using System;
using System.Linq;

namespace _03._2x2SquaresInMatrix
{
    class Program
    {
        static void Main()
        {   //Input dimensions
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray();
            string[,] matrix = new string[dimensions[0], dimensions[1]]; //Declare matrix dimensions

            //Fill matrix columns
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] columtElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columtElements[col];
                }
            }

            //Logic
            int counter = 0;
            
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    string currentElement = matrix[row, col];
                    if (matrix[row, col] == currentElement && matrix[row, col + 1] == currentElement && 
                        matrix[row + 1, col] == currentElement && matrix[row + 1, col + 1] == currentElement)
                    {
                        counter++;
                    }
                }
            }
            //Print the result
            Console.WriteLine(counter);
        }
    }
}
