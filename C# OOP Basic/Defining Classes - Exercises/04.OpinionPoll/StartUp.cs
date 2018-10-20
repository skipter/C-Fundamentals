using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.OpinionPoll
{
    public class StartUp
    {
        static void Main()
        {
            List<Person> over30 = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                if (age > 30)
                {
                    Person person = new Person(name, age);
                    over30.Add(person);
                }
            }

            //var sorted = people.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
            //and print with foreach

            foreach (var person in over30.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}
