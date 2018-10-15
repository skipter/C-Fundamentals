using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Targam
{
    class Targam
    {
        static void Main()
        {
            var data = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var banTokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //Ban check
                if (banTokens[0] == "ban")
                {
                    string userToBan = banTokens[1];
                    if (data.ContainsKey(userToBan))
                    {
                        data.Remove(userToBan);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    string name = tokens[0];
                    string tag = tokens[1];
                    int likes = int.Parse(tokens[2]);

                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new Dictionary<string, int>());
                    }

                    if (!data[name].ContainsKey(tag))
                    {
                        data[name].Add(tag, likes);
                    }
                    else
                    {
                        data[name][tag] += likes;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var name in data.OrderByDescending(x => x.Value.Sum(y => y.Value)).ThenByDescending(i => i.Key))
            {
                Console.WriteLine(name.Key);

                foreach (var tag in name.Value)
                {
                    Console.WriteLine($"- {tag.Key}: {tag.Value}");
                }
            }
        }
    }
}
