using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseNumbers.v2
{
    class ReverseNumsV2
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            numbers.Reverse();
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
