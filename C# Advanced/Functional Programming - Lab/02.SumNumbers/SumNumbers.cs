using System;
using System.Linq;

namespace _02.SumNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(", ")
                .Select(n => n.Trim())
                .Select(parse)
                .ToArray();

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }

        public static Func<string, int> parse = n => Int32.Parse(n);
    }
}
