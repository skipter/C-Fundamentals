using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PoisonousPlants
{
    class Program
    {
        static void Main()
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
                
                for (int i = indexes.Count - 1; i >= 0; i--)
                {
                    pesticideQuantity.RemoveAt(indexes[i]);
                   
                }
                days++;
                indexes.Clear();
            }
            Console.WriteLine(days);
        }
    }
}
