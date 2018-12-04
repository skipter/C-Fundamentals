namespace _05.ComparingObjects
{
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        private List<Person> people;
        private bool isRun;

        public Engine()
        {
            this.people = new List<Person>();
            this.isRun = true;
        }

        public void Run()
        {
            string args;

            while ((args = Console.ReadLine()) != "END")
            {
                var data = args.Split();
                string name = data[0];
                int age = int.Parse(data[1]);
                string town = data[2];

                Person person = new Person(name, age, town);

                people.Add(person);
            }

            int personSearched = int.Parse(Console.ReadLine());
            var personToCompare = people[personSearched - 1];

            int equalPeople = 0;
            int notEqualPeople = 0;

            foreach (var person in people)
            {
                if (personToCompare.CompareTo(person) == 0)
                {
                    equalPeople++;
                }
                else 
                {
                    notEqualPeople++;
                }
            }

            if (equalPeople == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalPeople} {notEqualPeople} {people.Count}");
            }
        }
    }
}
