using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] petrolInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

                queue.Enqueue(petrolInfo);
            }

            int index = 0;

            while (true)
            {
                int totalFuel = 0;

                foreach (var petrolPump in queue)
                {
                    int fuel = petrolPump[0];
                    int distance = petrolPump[1];

                    totalFuel += fuel - distance;

                    if (totalFuel < 0)
                    {
                        index++;
                        int[] pumpToRemove = queue.Dequeue();
                        queue.Enqueue(pumpToRemove);
                        break;
                    }
                }
                if (totalFuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}
