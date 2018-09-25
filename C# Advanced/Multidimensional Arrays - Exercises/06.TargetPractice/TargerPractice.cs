using System;
using System.Linq;

namespace _06.TargetPractice
{
    class TargerPractice
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray();

            int rowSize = dimensions[0];
            int colSize = dimensions[1];

            int[][] matrix = new int[rowSize][];

            for (int row = 0; row < matrix.Length; row++)
            {
                //matrix[row] = matrix[colSize];
                char[] snake = Console.ReadLine()
                    .ToArray();
                for (int col = 0; col < matrix[row].Length; col++)
                {

                }
            }

            foreach (var item in matrix)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
