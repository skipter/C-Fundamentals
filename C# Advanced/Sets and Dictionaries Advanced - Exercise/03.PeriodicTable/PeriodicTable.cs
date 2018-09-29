using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            SortedSet<string> chems = new SortedSet<string>();

            for (int i = 0; i < number; i++)
            {
                var chemicals = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < chemicals.Length; j++)
                {
                    chems.Add(chemicals[j]);
                }
            }

            Console.WriteLine(String.Join(" ", chems));
        }
    }
}
