using System;
using System.Collections.Generic;

namespace _04.HitList
{
    class HitList
    {
        static void Main()
        {
            int infoIndex = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            var peopleInfo = new Dictionary<string, SortedDictionary<string, string>>();

            while (input != "end transmissions")
            {
                string[] tokens = input.Split("=");
                string name = tokens[0];
                string[] kvps = tokens[1].Split(";");
                //input logic
                if (!peopleInfo.ContainsKey(name))
                {
                    peopleInfo.Add(name, new SortedDictionary<string, string>());
                }
                for (int i = 0; i < kvps.Length; i++)
                {
                    string[] kvp = kvps[i].Split(":");
                    string key = kvp[0];
                    string value = kvp[1];

                    if (!peopleInfo[name].ContainsKey(key))
                    {
                        peopleInfo[name].Add(key, value);
                    }
                    else
                    {
                        peopleInfo[name][key] = value;
                    }
                }


                input = Console.ReadLine();
            }
            //person to kill- print info
            string[] kill = Console.ReadLine()
                .Split(" ");
            string killWho = kill[1];

            int indexCount = 0;
            //print result
            Console.WriteLine($"Info on {killWho}:");

            foreach (var kvp in peopleInfo[killWho])
            {
                indexCount += kvp.Key.Length;
                indexCount += kvp.Value.Length;
                Console.WriteLine($"---{kvp.Key}: {kvp.Value}");
            }
            Console.WriteLine($"Info index: {indexCount}");

            if (infoIndex <= indexCount)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                Console.WriteLine($"Need {infoIndex - indexCount} more info.");
            }
        }
    }
}
