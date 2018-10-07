using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvenOrOdds
{
    class FindEvenOrOdds
    {
        static void Main()
        {   //Take start and end number
            List<int> indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToList();

            string numType = Console.ReadLine();
            int startNum = indexes[0];
            int endNum = indexes[1];
            //Empty list
            List<int> numbers = new List<int>();

            //Populate list
            for (int i = startNum; i <= endNum; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> even = x => { return x % 2 == 0; };
            Predicate<int> odd = x => { return x % 2 != 0; };

            //Printing
            List<int> resultList = new List<int>();
            switch (numType)
            {
                case "odd":

                    resultList = numbers.FindAll(odd);
                    break;

                case "even":

                    resultList = numbers.FindAll(even);
                    break;
            }
            Console.WriteLine(String.Join(" ", resultList));
        }
    }
}
