using System;
using System.Linq;
using System.Collections.Generic;

namespace _11.PartyReservationFilterModule
{
    class PartyReservationFilterModule
    {
        static void Main()
        {

            Func<string, string, bool> startsWith = (a, b) => a.StartsWith(b);
            Func<string, string, bool> endsWith = (a, b) => a.EndsWith(b);
            Func<string, string, bool> contains = (a, b) => a.Contains(b);
            Func<string, int, bool> checkLength = (a, b) => a.Length == b;

            List<string> guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            List<string> result = new List<string>(guests);
            List<string> filtered = new List<string>();

            while (input != "Print")
            {
                string[] commandArgs = input
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];
                string filterType = commandArgs[1];
                string param = commandArgs[2];

                switch (commandArgs[1])
                {
                    case "Starts with":
                        filtered = guests
                            .Where(i => startsWith(i, commandArgs[2]))
                            .ToList();
                        break;
                    case "Ends with":
                        filtered = guests
                            .Where(i => endsWith(i, commandArgs[2]))
                            .ToList();
                        break;
                    case "Length":
                        filtered = guests
                            .Where(i => checkLength(i, int.Parse(commandArgs[2])))
                            .ToList();
                        break;
                    case "Contains":
                        filtered = guests
                            .Where(i => contains(i, commandArgs[2]))
                            .ToList();
                        break;
                }

                switch (commandArgs[0])
                {
                    case "Add filter":
                        result
                            .RemoveAll(r => filtered.Contains(r));
                        break;
                    case "Remove filter":
                        result.AddRange(filtered);
                        result = result.Distinct().ToList();
                        break;
                }

                input = Console.ReadLine();
            }

            guests.RemoveAll(i => !result.Contains(i));
            Console.WriteLine(String.Join(" ", guests));
        }
    }
}
