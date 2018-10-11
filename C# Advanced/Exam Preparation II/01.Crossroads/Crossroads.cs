using System;
using System.Collections.Generic;

namespace _01.Crossroads
{
    class Crossroads
    {
        static void Main()
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            int totalSeconds = greenLight + freeWindow;
            string input = Console.ReadLine();

            int carCounter = 0;
            //ToDo
            while (input != "END")
            {
                Queue<char> car = new Queue<char>(input);
                while (totalSeconds > 0)
                {
                    car.Dequeue();
                    if (totalSeconds)
                }



                input = Console.ReadLine();
            }
        }
    }
}
