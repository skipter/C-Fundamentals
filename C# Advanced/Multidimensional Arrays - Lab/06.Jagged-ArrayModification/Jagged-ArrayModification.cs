using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main()
        {   //Read row size from single line.
            int rowCount = Int32.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rowCount][];
            //Initial row count and fill other arrays/columns/ in the jagged array.
            for (int row = 0; row < rowCount; row++)
            {
                int[] columnElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(Int32.Parse)
                    .ToArray();
                for (int col = 0; col < columnElements.Length; col++)
                {
                    jaggedArray[row] = columnElements;
                }
            }

            //Input {command}{row}{col}{value}
            string[] commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "END")
            {
                string action = commands[0];
                int rowIndex = Int32.Parse(commands[1]);
                int colIndex = Int32.Parse(commands[2]);
                int value = Int32.Parse(commands[3]);

                if (rowIndex < 0 || rowIndex > jaggedArray.Length - 1 ||
                    colIndex < 0 || colIndex > jaggedArray[rowIndex].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    commands = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                switch (action) // (action?.ToLower()); NB -> ? operator check if its 'null'. If its - it will return null, without it - it throw an exception.
                {
                    case "Add":
                        jaggedArray[rowIndex][colIndex] += value;
                        break;
                    case "Subtract":
                        jaggedArray[rowIndex][colIndex] -= value;
                        break;
                }
                commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(String.Join(" ", item));
            }

        }
    }
}
