using System;
using System.Collections.Generic;

namespace _07.SpeedRacing
{
    public class SpeedRacing
    {
        public static void Main()
        {

            List<Car> cars = new List<Car>();
            int numOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCars; i++)
            {
                string[] data = Console.ReadLine().Split();

                string model = data[0];
                double fuel = double.Parse(data[1]);
                double fuelPerKm = double.Parse(data[2]);

                Car car = new Car(model, fuel, fuelPerKm);
                cars.Add(car);
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] inputArgs = input.Split();

                string command = inputArgs[0];
                string carModel = inputArgs[1];
                double kmToDrive = double.Parse(inputArgs[2]);

                Car car = cars.Find(x => x.Model == carModel); //Look in the list for the car

                bool isMoved = car.Drive(kmToDrive);    //Go to car method for Drive.

                if (!isMoved)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                input = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.Distance}");
            }
        }
    }
}
