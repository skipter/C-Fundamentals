using System;
using System.Collections.Generic;

namespace _06.TrafficLight
{
    class TrafficLight
    {
        static void Main(string[] args)
        {
            int carsToPass = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            string command;
            int carsPassedCounter = 0;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green") //When its green, we remove cars from queue(which we add in 'else' statement).
                {
                    for (int i = 0; i < carsToPass; i++) //Number of cars that have to pass the road.
                    {
                        if (queue.Count > 0) 
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            carsPassedCounter++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command); //When its not green, we add cars to the queue.
                }
            }
            Console.WriteLine($"{carsPassedCounter} cars passed the crossroads.");
        }
    }
}
