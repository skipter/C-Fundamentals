using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty
{
    class Predicateparty
    {
        static void Main()
        {
            List<string> guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Predicate<string> predicate;
            Action<List<string>> print = names => Console.WriteLine(String.Join(", ", names) + " are going to party!");

            string input = Console.ReadLine();

            while (input != "Party!")
            {
                string[] commandArgs = input.Split(" ");

                string command = commandArgs[0];
                string predicateNames = commandArgs[1];
                string value = commandArgs[2];

                predicate = GetPredicate(predicateNames, value);

                if (command == "Remove")
                {
                    guests.RemoveAll(predicate);
                }
                else
                {
                    var newGuests = guests.FindAll(predicate);

                    foreach (var guest in newGuests)
                    {
                        int indexOfCurrentGuest = guests.IndexOf(guest);

                        guests.Insert(indexOfCurrentGuest + 1, guest);
                    }
                }

                input = Console.ReadLine();
            }

            if (guests.Count == 0)
            {
                Console.WriteLine("Nobody is going to party!");
            }
            else
            {
                print(guests);
            }
        }

        private static Predicate<string> GetPredicate(string predicateNames, string value)
        {
           if (predicateNames == "StartsWith")
            {
                return p => p.StartsWith(value);
            }
           else if (predicateNames == "EndsWith")
            {
                return p => p.EndsWith(value);
            }
           else if (predicateNames == "Length")
            {
                return p => p.Length == int.Parse(value);
            }

            return null;
        }
    }
}
