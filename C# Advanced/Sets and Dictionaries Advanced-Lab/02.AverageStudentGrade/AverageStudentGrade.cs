using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrade
{
    class AverageStudentGrade
    {
        static void Main()
        {
            int studentCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsData = new Dictionary<string, List<double>>();

            for (int i = 0; i < studentCount; i++)
            {
                var inputData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = inputData[0];
                double grade = double.Parse(inputData[1]);

                if (!studentsData.ContainsKey(name))
                {
                    studentsData.Add(name, new List<double>());
                    studentsData[name].Add(grade);
                }
                else
                {
                    studentsData[name].Add(grade);
                }
            }
            foreach (var studentName in studentsData)
            {
                var data = studentName.Key;
                Console.Write($"{studentName.Key} -> ");
                // Console.WriteLine(String.Join(" ", studentsData[data].Where( x => x.ToString({ }:f2)));

                foreach (var grades in studentsData[data])
                {
                    Console.Write($"{grades:f2} ");
                    
                }
                Console.Write($"(avg: {studentsData[data].Average():f2})");
                Console.WriteLine();
            }
        }
    }
}
