using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class PredicateForNames
    {
        static void Main()
        {
            int lengthNumber = int.Parse(Console.ReadLine());

            Predicate<string> checkLength = x => x.Length <= lengthNumber;

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => checkLength(x))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
