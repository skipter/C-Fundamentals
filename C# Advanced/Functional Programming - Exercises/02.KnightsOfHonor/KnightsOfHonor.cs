using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class KnightsOfHonor
    {
        static void Main()
        {
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(appender)
                .ToList()
                .ForEach(w => Console.WriteLine(w));
        }
        public static Func<string, string> appender = w => "Sir " + w.ToString();
    }
}
