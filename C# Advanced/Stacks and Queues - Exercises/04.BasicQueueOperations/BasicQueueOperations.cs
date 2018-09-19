using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int elementsToAdd = input[0];
            int elementsToRemove = input[1];
            int elementToCheck = input[2];

            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(elements);

            if (elements.Length == 0)
            {
                Console.WriteLine("0");
            }

            for (int i = 0; i < elementsToRemove; i++)
            {
                queue.Dequeue();
            }

            if(queue.Count != 0)
            {
                if (queue.Contains(elementToCheck))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
