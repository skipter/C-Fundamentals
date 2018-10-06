using System;
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

            // Second variant
            // Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //     .Where(x => Char.IsUpper(x[0]))
            //     .ToList()
            //     .ForEach(Console.WriteLine);

            // Third variant - Expression tree
            // Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //     .Where(x => Char.IsUpper(x[0]))
            //     .Select( w =>
            //      {
            //          Console.WriteLine(w)
            //          return w;
            //      })
            //      .ToList();  / .Count();            
        }
    }
}
