using System;

namespace _08.PascalTriangle
{
    class PascalTriangle
    {
        static void Main()
        {
            int rowSize = Int32.Parse(Console.ReadLine());

            long[][] jaggedArray = new long[rowSize][];

            for (int index = 0; index < jaggedArray.Length; index++)
            {
                jaggedArray[index] = new long[index + 1];
                jaggedArray[index][0] = 1;
                jaggedArray[index][index] = 1;
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                if (jaggedArray[row].Length > 2) //Check if the index is bigger than 2/second element.
                {   //Logic about inside numbers (Pascal triangle) algorithm.
                    for (int col = 1; col < jaggedArray[row].Length - 1; col++)
                    {
                        jaggedArray[row][col] = jaggedArray[row - 1][col] + jaggedArray[row - 1][col - 1];
                    }
                }
            }
            //Print result.
            foreach (var item in jaggedArray)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
