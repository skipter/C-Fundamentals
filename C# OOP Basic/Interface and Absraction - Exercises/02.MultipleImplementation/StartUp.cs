using System;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthday = Console.ReadLine();

            IPerson ctzen = new Citizen(name, age, id, birthday);
            IIdentifiable ident = new Citizen(name, age, id, birthday);
            IBirthable birth = new Citizen(name, age, id, birthday);

            //Console.WriteLine(ctzen.Name);
            //Console.WriteLine(ctzen.Age);
            Console.WriteLine(ident.Id);
            Console.WriteLine(birth.Birthdate);
        }
    }
}
