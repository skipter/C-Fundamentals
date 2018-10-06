using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class CountUppercaseWords
    {
        static void Main()
        {
            Func<string, bool> func = x => Char.IsUpper(x[0]);

            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(func)
                .ToList()
                .ForEach(w => Console.WriteLine(w));
        }
    }
}
