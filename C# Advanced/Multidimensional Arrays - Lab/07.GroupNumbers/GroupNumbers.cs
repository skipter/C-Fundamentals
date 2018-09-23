using System;
using System.Linq;

namespace _07.GroupNumbers
{
    class GroupNumbers
    {
        static void Main()
        {
            //Input
            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray();

            //Odder numbers by their remainder 0 , 1 or 2 when dividing by 3.
            int[][] orderNumbers = new int[3][];

            //Order/put numbers by their remainder with lambda - 'where' function.
            orderNumbers[0] = numbers
                .Where(x => Math.Abs(x) % 3 == 0)
                .ToArray();

            orderNumbers[1] = numbers
                .Where(x => Math.Abs(x) % 3 == 1)
                .ToArray();

            orderNumbers[2] = numbers
                .Where(x => Math.Abs(x) % 3 == 2)
                .ToArray();

            //Print jagged array.
            foreach (var item in orderNumbers)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
