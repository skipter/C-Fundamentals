using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.TicketTrouble
{
    class TicketTrouble
    {
        static void Main()
        {
            List<string> seats = new List<string>();

            string location = Console.ReadLine();
            string input = Console.ReadLine();

            string squarePattern = @"\[[^\]]*{([A-Z]{3} [A-Z]{2})}.*?{([A-Z]{1}[0-9]{1,2})}[^[]*\]";
            string cyrlyPattern = @"{[^}]*\[([A-Z]{3} [A-Z]{2})\].*?\[([A-Z]{1}[0-9]{1,2})\][^{]*}";

            MatchCollection squareCollection = Regex.Matches(input, squarePattern);
            MatchCollection curlyCollection = Regex.Matches(input, cyrlyPattern);

            AddSeats(seats, location, squareCollection);
            AddSeats(seats, location, curlyCollection);

            if (seats.Count == 2)
            {
                Console.WriteLine($"You are traveling to {location} on seats {seats[0]} and {seats[1]}.");
            }
            else
            {
                for (int i = 0; i < seats.Count; i++)
                {
                    for (int j = i + 1; j < seats.Count; j++)
                    {
                        string firstRow = seats[i].Substring(1);
                        string secondRow = seats[j].Substring(1);

                        if (firstRow == secondRow)
                        {
                            Console.WriteLine($"You are traveling to {location} on seats {seats[i]} and {seats[j]}.");
                            return;
                        }
                    }
                }
            }
        }

        private static void AddSeats(List<string> seats, string location, MatchCollection collection)
        {
            foreach (Match item in collection)
            {
                if (item.Groups[1].Value.Contains(location))
                {
                    seats.Add(item.Groups[2].Value);
                }
            }
        }
    }
}
