using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person person = new Person();

            person.Name = "Ivan"; //Console.ReadLine();
            person.Age = 15;

            //Console.WriteLine($"Your name is {person.Name} and your age is {person.Age}");
        }
    }
}
