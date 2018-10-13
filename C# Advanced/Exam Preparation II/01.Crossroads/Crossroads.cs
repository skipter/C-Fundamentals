using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.Crossroads
{
    class Crossroads
    {
        static void Main()
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string input = Console.ReadLine();

            int carCounter = 0;

            while (input != "END")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                    input = Console.ReadLine();
                    continue;
                }

                int currentGreenLight = greenLight;

                string currentCar = string.Empty;
                string outputCar = string.Empty;
                while (cars.Count > 0 && currentGreenLight > 0)
                {
                    currentCar = cars.Dequeue();
                    outputCar = currentCar;
                    currentGreenLight -= currentCar.Length;

                    if (currentGreenLight >= 0)
                    {
                        carCounter++;
                        continue;
                    }

                    currentCar = currentCar.Remove(0, currentCar.Length - currentGreenLight * -1);

                    currentGreenLight += freeWindow;

                    if (currentGreenLight >= 0)
                    {
                        carCounter++;
                        break;
                    }

                    currentCar = currentCar.Remove(0, currentCar.Length - currentGreenLight * -1);
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{outputCar} was hit at {currentCar[0]}.");
                    return; //Environment.Exit(0) - exit from a lot of nested methonds or statements.
                }
               
                input = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carCounter} total cars passed the crossroads.");
        }
    }
}
