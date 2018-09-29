using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> charsCount = new SortedDictionary<char, int>();
            int counter = 1;

            foreach (var character in input)
            {
                if (!charsCount.ContainsKey(character))
                {
                    charsCount.Add(character, counter);
                }
                else
                {
                    charsCount[character] += 1;
                }
            }

            foreach (var character in charsCount)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
