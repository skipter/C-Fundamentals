using System;
using System.Linq;

namespace _08.CustomComparator
{
    class CustomComparator
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            Func<int, bool> even = x => x % 2 == 0;
            Func<int, bool> odd = x => x % 2 != 0;

            input = input.Where(even).OrderBy(x => x);
            input = input.Where(odd).OrderBy(x => x);

            Console.WriteLine(String.Join(" ", input));

            //Console.Write(String.Join(" ", input.Where(even).OrderBy(x => x)));
            //Console.Write(String.Join(" ", input.Where(odd).OrderBy(x => x)));

        }
    }
}
