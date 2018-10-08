using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CustomComparator
{
    class CustomComparator
    {
        static void Main()
        {
            Action<int[]> print = p => Console.WriteLine(String.Join(" ", p));

            Func<int, int, int> sort = (a, b) =>
                (a % 2 == 0 & b % 2 != 0) ? -1 :
                 (a % 2 != 0 & b % 2 == 0) ? 1 :
                 a.CompareTo(b);

            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Array.Sort(arr, new Comparison<int>(sort));

            print(arr);

        }
    }
}
