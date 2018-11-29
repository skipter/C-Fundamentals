using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.GenericCountMethodString
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<string> messages = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                messages.Add(message);
            }

            string comparator = Console.ReadLine();
                
            Box<string> box = new Box<string>(messages);
            int result = box.GetComparable(comparator);
            Console.WriteLine(result);
            
        }
    }
}
