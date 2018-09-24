using System;
using System.Linq;

namespace _05.RubiksMatrix
{
    class RubiksMatrix
    {
        static void Main()
        {   //Matrix size
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[][] matrix = new int[rows][];


            GetMatrix(matrix, cols);

            //Print(matrix); - Method for test and debug.

            int commandsCount = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                int rowCowIndex = Int32.Parse(input[0]);
                string direction = input[1];
                int moves = Int32.Parse(input[2]);

                //Input command.
                if (direction == "down")
                {
                    MoveDown(matrix, rowCowIndex, moves % matrix.Length); //If matrix is 3x3 and someone makes you to take 10000 loops-> % 3(three rows) this is 1 step. 
                }                                                          //We dont need without unnecessary loop. With this we save them.
                else if (direction == "left")
                {
                    MoveLeft(matrix, rowCowIndex, moves % matrix[0].Length);
                }
                else if (direction == "right")
                {
                    MoveRight(matrix, rowCowIndex, moves % matrix[0].Length);
                }
                else if (direction == "up")
                {
                    Up(matrix, rowCowIndex, moves % matrix.Length);
                }
            }

            int counter = 1;

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == counter)
                    {
                        Console.WriteLine("No swap required");
                        counter++;
                    }
                    else
                    {
                        Rearrange(matrix, row, col, counter);
                        counter++;
                    }
                }
            }
        }

        //Rearrange the matrix to inital look, before commands.
        private static void Rearrange(int[][] matrix, int row, int col, int counter)
        {
            for (int targetRow = 0; targetRow < matrix.Length; targetRow++)
            {
                for (int targetCol = 0; targetCol < matrix[targetRow].Length; targetCol++)
                {
                    if (matrix[targetRow][targetCol] == counter)
                    {
                        matrix[targetRow][targetCol] = matrix[row][col];
                        matrix[row][col] = counter;
                        Console.WriteLine($"Swap ({row}, {col}) with ({targetRow}, {targetCol})");
                        return;
                    }
                }
            }
        }

        private static void Up(int[][] matrix, int col, int moves)
        {
            for (int i = 0; i < moves; i++)                     //How many times to spin the elements at current positions.
            {
                int firstNumber = matrix[0][col];

                for (int row = 0; row < matrix.Length - 1; row++)
                {
                    matrix[row][col] = matrix[row + 1][col];
                }
                matrix[matrix.Length - 1][col] = firstNumber;
            }
        }

        private static void MoveRight(int[][] matrix, int row, int moves)
        {
            for (int i = 0; i < moves; i++) //How many times to spin the elements at current positions.
            {
                int lastElement = matrix[row][matrix[row].Length - 1]; //Take the last element in [Row]-[matrox(row).Length - 1 -> this take the last element of the N-th row
                for (int col = matrix.Length - 1; col > 0; col--)
                {
                    matrix[row][col] = matrix[row][col - 1];
                }
                matrix[row][0] = lastElement;       //Last element comes to first and first to last
            }
        }

        private static void MoveLeft(int[][] matrix, int row, int moves)
        {
            for (int i = 0; i < moves; i++)                             //How many times to spin the elements at current positions.
            {
                int firstElement = matrix[row][0];
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    matrix[row][col] = matrix[row][col + 1];
                }
                matrix[row][matrix[row].Length - 1] = firstElement;
            }
        }

        private static void MoveDown(int[][] matrix, int col, int moves)
        {

            for (int i = 0; i < moves; i++)                             //How many times to spin the elements at current positions.
            {
                int lastElement = matrix[matrix.Length - 1][col];

                for (int row = matrix.Length - 1; row > 0; row--)
                {
                    matrix[row][col] = matrix[row - 1][col];
                }
                matrix[0][col] = lastElement;
            }
        }

        //Print matrix - to test/debug and etc.
        // private static void Print(int[][] matrix)
        // {
        //     for (int row = 0; row < matrix.Length; row++)
        //     {
        //         Console.WriteLine(String.Join(" ", matrix[row]));
        //     }
        // }

        //Initial matrix rows and fill columns with simple counter.
        private static void GetMatrix(int[][] matrix, int cols)
        {
            int counter = 1;
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[cols];

                for (int col = 0; col < matrix[row].Length; col++) //On that row how many colomns are there.
                {
                    matrix[row][col] = counter++;                  //Fill matrix with numbers 1 2 3 4 5 6 ...depend on rows and cols.
                }
            }
        }
    }
}
