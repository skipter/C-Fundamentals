using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Ranking
    {
        static void Main()
        {
            Dictionary<string, string> contestsInfo = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();
             //Fill contestsInfo array.
            while (input != "end of contests")
            {
                string[] elements = input.Split(":");

                string contest = elements[0];
                string password = elements[1];

                if (!contestsInfo.ContainsKey(contest))
                {
                    contestsInfo.Add(contest, password);
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            //Fill students array.
            while (input != "end of submissions")
            {
                string[] elements = input.Split("=>");

                string examName = elements[0];
                string passExam = elements[1];
                string username = elements[2];
                int points = int.Parse(elements[3]);
                //Check the user and does she have the exam and pass .
                if (contestsInfo.ContainsKey(examName) && contestsInfo[examName] == passExam)
                {   //Add user to array.
                    if (!students.ContainsKey(username))
                    {
                        students.Add(username, new Dictionary<string, int>());
                    }
                    //Add exam and its points.
                    if (!students[username].ContainsKey(examName))
                    {
                        students[username].Add(examName, points);
                    }

                    if (students[username][examName] < points)
                    {
                        students[username][examName] = points;
                    }
                }
                input = Console.ReadLine();
            }
            //Take the top student from students with maximum points.
            var topStudents = students.OrderByDescending(x => x.Value.Sum(s => s.Value)).FirstOrDefault();
            //Print that student.
            Console.WriteLine($"Best candidate is {topStudents.Key} with total {topStudents.Value.Sum(x => x.Value)} points.");
            Console.WriteLine("Ranking:");
            //Sort students by name.
            var sortedStudents = students.OrderBy(x => x.Key);

            foreach (var student in sortedStudents)
            {   //Print student name.
                Console.WriteLine(student.Key);
                //Print each contest/exam with its points for every student in descending order by points.
                foreach (var contest in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
