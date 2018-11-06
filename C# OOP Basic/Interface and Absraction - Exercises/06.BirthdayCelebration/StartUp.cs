using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        string input = Console.ReadLine();
        List<IBirthdayDate> birthdays = new List<IBirthdayDate>();

        while (input != "End")
        {
            string[] tokens = input.Split();
            string birthdate = String.Empty;
            switch (tokens[0])
            {
                
                case "Pet":
                    string name = tokens[1];
                    birthdate = tokens[2];
                    IBirthdayDate pet = new Pets(name, birthdate);
                    birthdays.Add(pet);
                    break;

                case "Citizen":
                    string personName = tokens[1];
                    int age = int.Parse(tokens[2]);
                    string personId = tokens[3];
                    birthdate = tokens[4];
                    IBirthdayDate person = new Citizens(personName, age, personId, birthdate);
                    birthdays.Add(person);
                    break;
            }
            input = Console.ReadLine();
        }

        string year = Console.ReadLine();
        birthdays.Where(x => x.Birthdate.EndsWith(year)).ToList().ForEach(x => Console.WriteLine(x));
    }
}

