using System;

namespace _04.OpinionPoll
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string name = input[0];
                int age = int.Parse(input[1]);


            }
        }
    }
}
