using P01_RawData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.RawData
{
    public class StartUp
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                List<Tire> tyres = new List<Tire>();

                for (int j = 0; j < 4; j += 2)
                {
                    double tirePressure = double.Parse(input[5 + j]);
                    int tyreAge = int.Parse(input[6 + j]);

                    Tire tyre = new Tire(tirePressure, tyreAge);
                    tyres.Add(tyre);
                }

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car car = new Car(model, engine, cargo, tyres);
                cars.Add(car);

            }

            string typeOfCargo = Console.ReadLine();


            if (typeOfCargo == "fragile")
            {
                cars
                .Where(c => c.Cargo.CargoType == "fragile" && c.Tire.Any(t => t.Pressure < 1))
                .ToList().ForEach(c => Console.WriteLine($"{c.Model}"));
            }
            else
            {
                cars
                .Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250)
                .ToList()
                .ForEach(c => Console.WriteLine($"{c.Model}"));
            }
        }
    }
}