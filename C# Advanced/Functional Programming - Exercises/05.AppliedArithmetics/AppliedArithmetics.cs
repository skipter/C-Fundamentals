using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.AppliedArithmetics
{
    class AppliedArithmetics
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                switch (input)
                {
                    case "add":
                        numbers = add(numbers);
                       // numbers = numbers.Select(x => x + 1).ToList();
                        break;

                    case "multiply":
                        numbers = multiply(numbers);
                        //numbers = numbers.Select(x => x * 2).ToList();
                        break;

                    case "subtract":
                        numbers = subtrack(numbers);
                        //numbers = numbers.Select(x => x - 1).ToList();
                        break;

                    case "print":
                        Console.WriteLine(String.Join(" ", numbers));
                        break;

                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }
        public static Func<List<int>, List<int>> add = x => x.Select(y => y + 1).ToList();
        public static Func<List<int>, List<int>> multiply = x => x.Select(y => y * 2).ToList();
        public static Func<List<int>, List<int>> subtrack = x => x.Select(y => y - 1).ToList();
    }
}
