using System;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            IPerson ctzen = new Citizen(name, age);

            Console.WriteLine(ctzen.Name);
            Console.WriteLine(ctzen.Age);
        }
    }
}
