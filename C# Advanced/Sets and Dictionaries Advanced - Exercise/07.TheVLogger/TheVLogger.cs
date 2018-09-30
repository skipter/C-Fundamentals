using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheVLogger
{
    class TheVLogger
    {
        static void Main()
        {
            var inputData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, Dictionary<string, SortedSet<string>>> vloggers = 
                new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            
            //int counter = 0;

            while (inputData[0] != "Statistics")
            {
                string firstUsername = inputData[0];
                string command = inputData[1];
                string secondUsername = inputData[2];

                if (command == "joined")
                {
                    if (!vloggers.ContainsKey(firstUsername))
                    {   //Add user and add to each of them the two keys(key fot the second dictionary.
                        vloggers.Add(firstUsername, new Dictionary<string, SortedSet<string>>());
                        vloggers[firstUsername].Add("following", new SortedSet<string>());
                        vloggers[firstUsername].Add("followers", new SortedSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    bool isSamePerson = firstUsername == secondUsername;
                    if (vloggers.ContainsKey(firstUsername) && vloggers.ContainsKey(secondUsername) && !isSamePerson) //Firstname and secondname and they are different people !
                    {   //Tricky logic.
                        vloggers[firstUsername]["following"].Add(secondUsername);
                        vloggers[secondUsername]["followers"].Add(firstUsername);
                    }
                }


                inputData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            //Print result
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            //"followers" and "following" are keys.
            var sortedVloggers = vloggers.OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["following"].Count);

            int counter = 1;

            foreach (var item in sortedVloggers)
            {
                
                Console.WriteLine($"{counter}. {item.Key} : {item.Value["followers"].Count} followers, " +
                    $"{item.Value["following"].Count} following");

                if (counter == 1)
                {
                    foreach (var followerName in item.Value["followers"])
                    {
                        Console.WriteLine($"*  {followerName}");
                    }
                }
                counter++;
            }
        }
    }
}
