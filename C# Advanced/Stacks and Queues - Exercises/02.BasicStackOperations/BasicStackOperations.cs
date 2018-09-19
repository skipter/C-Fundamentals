using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            var nSx = Console.ReadLine().Split(' ');

            int numberOfElements = int.Parse(nSx[0]);
            int elementsToPop = int.Parse(nSx[1]);
            int elementToCheck = int.Parse(nSx[2]);

            var stackNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(stackNumbers);

            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(elementToCheck))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            } 
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
