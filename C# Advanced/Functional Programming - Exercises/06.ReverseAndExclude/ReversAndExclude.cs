using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class ReversAndExclude
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse);

            int divNum = int.Parse(Console.ReadLine());

            Predicate<int> filter = x => x % divNum != 0;
            Func<int, bool> filterFunc = x => filter(x);

            numbers = numbers.Where(filterFunc);

            Console.WriteLine(String.Join(" ", numbers.Reverse()));
        }
    }
}
