namespace _06.StrategyPattern
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var sortedByName = new SortedSet<Person>(new NameComparator());
            var sortedByAge = new SortedSet<Person>(new AgeComparator());

            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] peopleData = Console.ReadLine().Split();
                string name = peopleData[0];
                int age = int.Parse(peopleData[1]);

                Person person = new Person(name, age);

                sortedByName.Add(person);
                sortedByAge.Add(person);
            }

            foreach (var person in sortedByName)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }

            foreach (var person in sortedByAge)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
    }
}
