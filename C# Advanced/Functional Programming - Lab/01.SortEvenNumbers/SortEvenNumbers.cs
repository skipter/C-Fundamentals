using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
    class SortEvenNumbers
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToArray();

            Console.WriteLine(String.Join(", ", numbers));

            //Second way

            // Console.WriteLine(String.Join(", ", Console.ReadLine()
            //     .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            //     .Select(int.Parse)
            //     .Where(x => x % 2 == 0)
            //     .OrderBy(x => x)
            //     .ToArray()));
        }
    }
}
