using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class Potato
    {
        static void Main(string[] args)
        {
            long bagCapacity = long.Parse(Console.ReadLine());
            string[] inputArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();
            long gold = 0;
            long stones = 0;
            long money = 0;

            for (int i = 0; i < inputArgs.Length; i += 2)
            {
                string item = inputArgs[i];
                long quantity = long.Parse(inputArgs[i + 1]);

                string currentItem = string.Empty;

                if (item.Length == 3)
                {
                    currentItem = "Cash";
                }
                else if (item.ToLower().EndsWith("gem"))
                {
                    currentItem = "Gem";
                }
                else if (item.ToLower() == "gold")
                {
                    currentItem = "Gold";
                }

                if (currentItem == "")
                {
                    continue;
                }
                else if (bagCapacity < bag.Values.Select(x => x.Values.Sum()).Sum() + quantity)
                {
                    continue;
                }

                switch (currentItem)
                {
                    case "Gem":
                        if (!bag.ContainsKey(currentItem))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (quantity > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[currentItem].Values.Sum() + quantity > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.ContainsKey(currentItem))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (quantity > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[currentItem].Values.Sum() + quantity > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.ContainsKey(currentItem))
                {
                    bag[currentItem] = new Dictionary<string, long>();
                }

                if (!bag[currentItem].ContainsKey(item))
                {
                    bag[currentItem][item] = 0;
                }

                bag[currentItem][item] += quantity;
                if (currentItem == "Gold")
                {
                    gold += quantity;
                }
                else if (currentItem == "Gem")
                {
                    stones += quantity;
                }
                else if (currentItem == "Cash")
                {
                    money += quantity;
                }
            }

            foreach (var x in bag)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
    }
}