using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int numberOfbuyers = int.Parse(Console.ReadLine());

        List<IBuyer> list = new List<IBuyer>();

        for (int i = 0; i < numberOfbuyers; i++)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split();

            if (tokens.Length == 4)
            {
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string id = tokens[2];
                string birth = tokens[3];

                IBuyer citizen = new Citizen(name, age, id, birth);
            }
            else
            {
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string group = tokens[2];

                IBuyer rebel = new Rebel(name, age, group);
            }
        }
    }
}

