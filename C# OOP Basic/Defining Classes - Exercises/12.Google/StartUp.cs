using System;
using System.Collections.Generic;

namespace _12.Google
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, Person> persons = new Dictionary<string, Person>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                var data = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = data[0];
                string classType = data[1];
                var currentPerson = new Person(name);

                if (!persons.ContainsKey(name))
                {
                    persons[name] = currentPerson;
                }

                switch (classType)
                {
                    case "company":
                        Company company = new Company(data[2], data[3], decimal.Parse(data[4]));
                        persons[name].Company = company;
                        break;

                    case "car":
                        Car car = new Car(data[2], int.Parse(data[3]));
                        persons[name].Car = car;
                        break;

                    case "pokemon":
                        Pokemon pokemon = new Pokemon(data[2], data[3]);
                        persons[name].Pokemon.Add(pokemon);
                        break;

                    case "parents":
                        Family parents = new Family(data[2], data[3]);
                        persons[name].Parents.Add(parents);
                        break;

                    case "children":
                        Family children = new Family(data[2], data[3]);
                        persons[name].Children.Add(children);
                        break;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            Console.WriteLine(persons[input]); //to print the info must have override method ToString{} in every class !!!
        }
    }
}
