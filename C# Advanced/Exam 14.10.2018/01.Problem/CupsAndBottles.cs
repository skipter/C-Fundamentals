using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Problem
{
    class CupsAndBottles
    {
        static void Main()
        {
            int[] cupsCapacity = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] filledBottles = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> cups = new Queue<int>(cupsCapacity);
            Stack<int> bottles = new Stack<int>(filledBottles);

            int remainLitters = 0;
            int last = 0;
            while (true)
            {
                if (cups.Count == 0 || bottles.Count == 0)
                {
                    break;
                }

                int currentBottle = bottles.Peek();
                int currentCup = cups.Dequeue();

                if (currentBottle >= currentCup)
                {
                    remainLitters += currentBottle - currentCup;
                    bottles.Pop();
                }
                else
                {
                    if (last != 0)
                    {
                        currentCup -= last;
                    }
                    last = currentCup - currentBottle;
                    bottles.Pop();
                }
            }

            //Print result
            if (bottles.Count != 0)
            {
                Console.Write($"Bottles: ");
                Console.Write(String.Join(" ", bottles));
                Console.WriteLine();
                Console.WriteLine($"Wasted litters of water: {remainLitters}");
            }
            else 
            {
                Console.Write($"Cups: ");
                Console.Write(String.Join(" ", cups));
                Console.WriteLine();
                Console.WriteLine($"Wasted litters of water: {remainLitters}");
            }
        }
    }
}