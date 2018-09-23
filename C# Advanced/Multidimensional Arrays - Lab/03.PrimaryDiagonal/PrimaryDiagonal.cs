using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class PrimaryDiagonal
    {
        static void Main(string[] args)
        {
            int matrixSize = Int32.Parse(Console.ReadLine()); //Read matrix size, its N x N.

            int[,] matrix = new int[matrixSize, matrixSize]; //Initial matrix size.


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columeElements = Console.ReadLine()   //Read colument elements.
                    .Split()
                    .Select(Int32.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columeElements[col];
                }
            } 

            //ToDo logic
            

        }
    }
}
