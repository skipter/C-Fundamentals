using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            int userCount = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < userCount; i++)
            {
                string username = Console.ReadLine();
                names.Add(username);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
