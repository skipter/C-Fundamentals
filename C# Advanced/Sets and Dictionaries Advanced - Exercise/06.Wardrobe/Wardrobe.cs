using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            int counter = 0;
            //Input.
            for (int i = 0; i < inputLines; i++)
            {
                var input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string color = input[0];

                var currentClothes = input[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //Keep simple logic, I was put a lot of hardcore stuff, no need it...
                //Check for key and add it.
                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }
                //Fill current color with clothes and add counter-1 item.
                for (int k = 0; k < currentClothes.Length; k++)
                {
                    if (!clothes[color].ContainsKey(currentClothes[k]))
                    {
                        clothes[color].Add(currentClothes[k], counter);
                    }
                        clothes[color][currentClothes[k]] += 1; //if color exists and dress , just increase + 1 to current items
                }
            }
            //Read for what clothe and color , we are looking for.
            var toLookFor = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            //Tokens.
            string colorToFind = toLookFor[0];
            string dress = toLookFor[1];
            //Print colors section.
            foreach (var color in clothes)
            {
                Console.WriteLine($"{color.Key} clothes:");
                //In each color we take its value(color.Value) and look/work with 'item'
                foreach (var item in color.Value)           //Search item in COLOR.VALUE !!! Not color.Key.
                {
                    if (colorToFind == color.Key && item.Key == dress)
                    {    //Check do we have the special dress.
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
