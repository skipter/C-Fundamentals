using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class setsOfElements
    {
        static void Main(string[] args)
        {
            int[] setSizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < setSizes[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                firstSet.Add(num);
            }

            for (int i = 0; i < setSizes[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                secondSet.Add(num);
            }

            var containedNums = firstSet.Intersect(secondSet);
            Console.WriteLine(String.Join(" ", containedNums));
        }
    }
}
