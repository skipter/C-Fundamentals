using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        string input = Console.ReadLine();

        List<IIdentable> societ = new List<IIdentable>();

        while (input != "End")
        {
            string[] tokens = input.Split(" ");

            if (tokens.Length == 3)
            {
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string id = tokens[2];
                IIdentable citizen = new Citizen(name, age, id);
                societ.Add(citizen);
            }
            else
            {
                string name = tokens[0];
                string id = tokens[1];
                IIdentable robot = new Robot(name, id);
                societ.Add(robot);
            }

            input = Console.ReadLine();
        }

        string idPattern = Console.ReadLine();

        foreach (var personaNoGrande in societ)
        {
            if (personaNoGrande.Id.EndsWith(idPattern))
            {
                Console.WriteLine(personaNoGrande.Id);
            }
        }
    }
}

