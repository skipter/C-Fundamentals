using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class CountSameValuesInArray
    {
        static void Main()
        {
            double[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> dict = new Dictionary<double, int>();

            foreach (var item in inputArray)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 0);
                }

                dict[item]++;
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
