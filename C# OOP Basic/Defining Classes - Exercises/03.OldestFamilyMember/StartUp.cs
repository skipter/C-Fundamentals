using System;
using System.Collections.Generic;

namespace _03.OldestFamilyMember
{
    public class StartUp
    {
        static void Main()
        {
            Family family = new Family();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                family.AddMember(person);

            }

            Person oldestPerson = family.GetOldestMembers();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
