using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class ReversAndExclude
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            int divNum = int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> removeNums = x => x.RemoveAll(y => y % divNum == 0).ToList();

        }
        public static Action<List<int>> reverseFunc = nums => nums.Reverse();
    }
}
