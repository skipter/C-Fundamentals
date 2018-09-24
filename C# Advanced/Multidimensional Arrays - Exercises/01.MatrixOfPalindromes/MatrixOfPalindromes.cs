using System;
using System.Linq;

namespace _01.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main()
        {
            //Get matrix sizes.
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray();

            string[,] matrix = new string[dimensions[0], dimensions[1]];
            
            //Use arrray alphabet for the input.
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {   //The palindrome logic
                    matrix[row, col] = "" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row); //aaa aba aca ada aea afa
                                                                                                             //bbb bcb bdb beb bfb bgb    and etc...
                }
            }

            //Print the result
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
