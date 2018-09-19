using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> maxStack = new Stack<int>();

            int num = int.Parse(Console.ReadLine());
            int max = Int32.MinValue;

            for (int i = 0; i < num; i++)
            {
                var query = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                switch (query[0])
                {
                    case 1:
                        stack.Push(query[1]);
                        break;

                    case 2:
                        stack.Pop();
                        break;

                    case 3:
                        Console.WriteLine(stack.Max()); 
                        break;
                }
            }
        }
    }
}
