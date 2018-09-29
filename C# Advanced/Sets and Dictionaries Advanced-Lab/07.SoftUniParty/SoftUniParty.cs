using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class SoftUniParty
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> vips = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();


            while (input != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vips.Add(input);
                }
                else
                {
                    regular.Add(input);
                }

                input = Console.ReadLine();
            }

            while (input != "END")
            {
                if (char.IsDigit(input[0]))
                {
                    vips.Remove(input);
                }
                else
                {
                    regular.Remove(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(vips.Count + regular.Count);
            foreach (var name in vips)
            {
                Console.WriteLine(name);
            }
            foreach (var name in regular)
            {
                Console.WriteLine(name);
            }
        }
    }
}
