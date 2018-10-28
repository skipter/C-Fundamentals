using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfPersons = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();

            for (int i = 0; i < numberOfPersons; i++)
            {
                List<string> inputArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string firstName = inputArgs[0];
                string lastName = inputArgs[1];
                int age = int.Parse(inputArgs[2]);
                decimal salary = decimal.Parse(inputArgs[3]);

                Person person = new Person(firstName, lastName, age, salary);

                persons.Add(person);
            }

            decimal bonus = decimal.Parse(Console.ReadLine());

            persons.ForEach(x => x.IncreaseSalary(bonus));
            persons.ForEach(x => Console.WriteLine(x));
        }
    }
}
