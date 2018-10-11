using System;
using System.Linq;

namespace _02.Sneaking
{
    class Sneaking
    {
        static void Main()
        {
            int dimensions = int.Parse(Console.ReadLine());

            char[][] room = new char[dimensions][];

            int row = 0;
            int col = 0;

            for (int i = 0; i < dimensions; i++)
            {
                //input colons
                room[i] = Console.ReadLine().ToCharArray();
                //Look for Sam
                if (room[i].Contains('S'))
                {
                    //Take Sam start index
                    row = i;
                    col = Array.IndexOf(room[i], 'S');
                }
            }

            char[] directions = Console.ReadLine().ToCharArray();

            bool[] winLose = new bool[2];
            //Move game
            for (int i = 0; i < directions.Length; i++)
            {
                MoveEnemy(room);


                //Check if an enemy looks at Sam.
                if (room[row].Contains('d') && Array.IndexOf(room[row], 'd') > col) //col - index of Sam and d - index of enemy
                {
                    room[row][col] = 'X';
                    Console.WriteLine($"Sam died at {row}, {col}");
                    break;
                }
                else if (room[row].Contains('b') && Array.IndexOf(room[row], 'b') < col)
                {
                    room[row][col] = 'X';
                    Console.WriteLine($"Sam died at {row}, {col}");
                    break;
                }

                MoveSam(room, ref row, ref col, directions[i]);

                if (room[row].Contains('N'))
                {
                    int colOfN = Array.IndexOf(room[row], 'N');
                    room[row][colOfN] = 'X';
                    Console.WriteLine("Nikoladze killed!");
                    break;
                }
            }
            foreach (var r in room)
            {
                Console.WriteLine(String.Join("", r));
            }
        }

        //Move Sam logic
        private static void MoveSam(char[][] room, ref int row, ref int col, char direction)
        {
            //Sam olds position
            room[row][col] = '.';
            switch (direction)
            {
                case 'U':
                    row--;
                    break;
                case 'D':
                    row++;
                    break;
                case 'L':
                    col--;
                    break;
                case 'R':
                    col++;
                    break;
                default:
                    break;
            }
            //New Sam position
            room[row][col] = 'S';
        }

        //Moves enemy logic
        private static void MoveEnemy(char[][] room)
        {
            for (int i = 0; i < room.Length; i++)
            {
                int indexD = Array.IndexOf(room[i], 'd'); //return -1
                int indexB = Array.IndexOf(room[i], 'b');

                if (indexD != -1)
                {
                    if (indexD == 0)
                    {
                        room[i][indexD] = 'b';
                    }
                    else
                    {
                        room[i][indexD] = '.';
                        indexD--;
                        room[i][indexD] = 'd';
                    }
                }
                else if (indexB != -1)
                {
                    if (indexB == room[i].Length - 1)
                    {
                        room[i][indexB] = 'd';
                    }
                    else
                    {
                        room[i][indexB] = '.';
                        indexB++;
                        room[i][indexB] = 'b';
                    }
                }
            }
        }
    }
}
