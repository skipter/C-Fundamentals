using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<double> messages = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double message = double.Parse(Console.ReadLine());
                messages.Add(message);
            }

            double comparator = double.Parse(Console.ReadLine());

            Box<double> box = new Box<double>(messages);
            int result = box.GetComparable(comparator);
            Console.WriteLine(result);

        }
    }
}
