using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class ListOfPredicates
    {
        static void Main()
        {
            int endNum = int.Parse(Console.ReadLine());

            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToList();

            List<Predicate<int>> predicates = new List<Predicate<int>>();
            List<int> list = new List<int>();

            nums.ForEach(n => predicates.Add(x => x % n == 0));

            for (int i = 1; i <= endNum; i++)
            {
                bool isDivisible = true;

                foreach (var number in predicates)
                {
                    if (!number(i))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    list.Add(i);
                }
            }

            Console.WriteLine(String.Join(" ", list));
        }
    }
}
