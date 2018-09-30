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



            string[] input = Console.ReadLine()
                .Split(":")
                .ToArray();

            while (input[0] != "end of contests")
            {
                string contest = input[0];
                string password = input[1];

                if (!contestsInfo.ContainsKey(contest))
                {
                    contestsInfo.Add(contest, password);
                }
            }

            var secondInput = Console.ReadLine()
                .Split("=>")
                .ToArray();
            while (secondInput[0] != "end of submissions")
            {
                string examName = secondInput[0];
                string passExam = secondInput[1];
                string username = secondInput[2];
                int points = int.Parse(secondInput[3]);
            }
        }
    }
}
