using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseNumberswithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //Can you also use a Stack<string> 
            Stack<int> stack = new Stack<int>(numbers);
            foreach (var number in stack)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
