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
                    if (bottles.Count > 0 && cups.Count > 0)
                    {
                        currentCup = cups.Peek();
                        currentBottle = bottles.Peek();
                        continue;
                    }
                    break;
                }
                else
                {
                    currentCup = currentCup - currentBottle;
                    bottles.Pop();
                    if (bottles.Count > 0)
                    {
                        currentBottle = bottles.Peek();
                        continue;
                    }
                    break;
                }
            }

            //Print result
            if (bottles.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(' ', cups)}");
            }
            else 
            {
                Console.WriteLine($"Cups: {string.Join(' ', bottles)}");
            }
            Console.WriteLine($"Wasted litters of water: {remainLitters}");
        }
    }
}