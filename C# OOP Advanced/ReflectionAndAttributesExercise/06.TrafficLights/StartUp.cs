using System;
using System.Collections.Generic;

namespace _06.TrafficLights
{
    public class StartUp
    {
        public static void Main()
        {
            string[] lights = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<TrafficLight> trafficLight = new List<TrafficLight>();

            foreach (var light in lights)
            {
                trafficLight.Add(new TrafficLight(light));
            }

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                trafficLight.ForEach(l => l.ChangeLight());

                Console.WriteLine(string.Join(" ", trafficLight));
            }
        }
    }
}
