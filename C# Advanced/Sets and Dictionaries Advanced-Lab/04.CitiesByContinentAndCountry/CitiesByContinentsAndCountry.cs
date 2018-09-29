using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CitiesByContinentAndCountry
{
    class CitiesByContinentsAndCountry
    {
        static void Main(string[] args)
        {
            int entityCounter = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> data = 
                new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < entityCounter; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string continent = input[0];
                string country = input[1];
                string towns = input[2];

                if (!data.ContainsKey(continent))
                {
                    data.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!data[continent].ContainsKey(country))
                {
                    data[continent].Add(country, new List<string>());
                    data[continent][country].Add(towns);
                }
                else
                {
                    data[continent][country].Add(towns);
                }
            }

            foreach (var continent in data)
            {
                var country = continent.Key;
                Console.WriteLine($"{continent.Key}:");

                foreach (var town in data[country])
                {
                    Console.WriteLine($"    {town.Key} -> {String.Join(", ", town.Value)}");
                }
            }
        }
    }
}
