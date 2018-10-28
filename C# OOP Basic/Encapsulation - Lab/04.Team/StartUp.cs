using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var inputArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = inputArgs[0];
                string lastName = inputArgs[1];
                int age = int.Parse(inputArgs[2]);
                decimal salary = decimal.Parse(inputArgs[3]);

                Person person = new Person(firstName, lastName, age, salary);

                persons.Add(person);
            }
            Team team = new Team("SoftUni");

            foreach (var person in persons)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}
