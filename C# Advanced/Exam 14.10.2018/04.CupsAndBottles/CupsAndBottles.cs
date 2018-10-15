using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CupsAndBottles
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

            int wastedLitters = 0;

            while (true)
            {
                var cup = cups.Dequeue();

                while (true)
                {
                    var bottle = bottles.Pop();

                    if (bottle >= cup)
                    {
                        wastedLitters += bottle - cup;
                        break;
                    }
                    else
                    {
                        cup -= bottle;
                    }

                    if (cup <= 0 || bottles.Count == 0)
                    {
                        break;
                    }
                }
                //Printing result
                if (bottles.Count == 0)
                {
                    Console.WriteLine($"Cups: {string.Join(' ', cups)}\nWasted litters of water: {wastedLitters}");
                    return;
                }

                if (cups.Count == 0)
                {
                    Console.WriteLine($"Bottles: {string.Join(' ', bottles)}\nWasted litters of water: {wastedLitters}");
                    return;
                }
            }
        }
    }
}
