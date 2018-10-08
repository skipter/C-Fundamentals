using System;
using System.Linq;
using System.Collections.Generic;

namespace _13.TriFunction
{
    class TriFunction
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, int, bool> isGreater = (a, b) => a.Sum(c => c) >= b;
            Func<Func<string, int, bool>, List<string>, string> returnFirst = (a, b) => b.FirstOrDefault(s => a(s, num));

            string result = returnFirst(isGreater, names);

            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(String.Empty);
            }
        }
    }
}
