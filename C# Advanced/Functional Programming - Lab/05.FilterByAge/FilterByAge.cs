using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    class FilterByAge
    {
        static void Main()
        {
            int numbersCount = parser(Console.ReadLine());
            List<KeyValuePair<string, int>> people = new List<KeyValuePair<string, int>>();

            for (int i = 0; i < numbersCount; i++)
            {
                string input = Console.ReadLine();

                var data = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string name = data[0];
                int age = parser(data[1]);

                people.Add(new KeyValuePair<string, int>(name, age));
            }

            string condition = Console.ReadLine();
            int ageInput = parser(Console.ReadLine());
            string[] format = Console.ReadLine().Split(" ");

            people
                .Where(p => condition == "younger" ? p.Value < ageInput : p.Value >= ageInput)
                .ToList()
                .ForEach(p => Printer(p, format));
        }

        static void Printer (KeyValuePair<string, int> person, string[] format)
        {
            if (format.Length == 2)
            {

                Console.WriteLine(format[0] == "name" ? 
                    $"{person.Key} - {person.Value}" :
                     $"{person.Value} - {person.Key}");
            }
            else
            {
                Console.WriteLine(format[0] == "name" ?
                    $"{person.Key}" :
                     $"{person.Value}");
            }
        }

        public static Func<string, int> parser = n => Int32.Parse(n);
    }
}
