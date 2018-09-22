using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PoisonousPlants.v2
{
    class PoisonousPlantsV2
    {
        static void Main(string[] args)
        {
            int plants = int.Parse(Console.ReadLine());

            List<int> pesticideQuantity = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> indexes = new List<int>();

            int days = 0;

            while (true)
            {
                for (int i = 0; i < pesticideQuantity.Count - 1; i++)
                {
                    if (pesticideQuantity[i] < pesticideQuantity[i + 1])
                    {
                        indexes.Add(i + 1);
                    }
                }

                if (indexes.Count == 0)
                {
                    break;
                }

                int counter = 0;
                for (int i = 0; i < indexes.Count; i++)
                {
                    pesticideQuantity.RemoveAt(indexes[i] - counter);
                    counter++;
                }
                days++;
                indexes.Clear();
            }
            Console.WriteLine(days);
        }
    }
}