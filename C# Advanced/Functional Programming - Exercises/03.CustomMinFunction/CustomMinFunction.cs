using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class CustomMinFunction
    {
        static void Main()
        {
            Console.WriteLine(GetMin(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(Parse)
                .ToArray()));

        }
        public static Func<string, int> Parse = n => Int32.Parse(n);
        public static Func<int[], int> GetMin = p => p.Min();
    }
}
