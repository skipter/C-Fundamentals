using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.CarSalesman
{
    public class StartUp
    {
        public static void Main()
        {
            int enginesCount = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < enginesCount; i++)
            {
                string[] engineData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string engineModel = engineData[0];
                int power = int.Parse(engineData[1]);

                Engine engine = new Engine(engineModel, power);

                if (engineData.Length == 3)
                {
                    if (Char.IsLetter(engineData[2][0]))
                    {
                        engine.Efficiency = engineData[2];
                    } 
                    else
                    {
                        engine.Displacement = engineData[2];
                    }
                }
                else if (engineData.Length == 4)
                {
                    engine.Displacement = engineData[2];
                    engine.Efficiency = engineData[3];
                }
                engines.Add(engine);
            }

            int carsCount = int.Parse(Console.ReadLine());

            for (int j = 0; j < carsCount; j++)
            {
                string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string markModel = carData[0];
                var engine = carData[1];

                Car car = new Car(markModel, engines.FirstOrDefault(x => x.EngineModel == engine)); //Look in list of engines and looks for the model

                if (carData.Length == 3)
                {
                    if (Char.IsDigit(carData[2][0]))
                    {
                        car.Weight = carData[2];
                    }
                    else
                    {
                        car.Color = carData[2];
                    }
                }
                else if (carData.Length == 4)
                {
                    car.Weight = carData[2];
                    car.Color = carData[3];
                }
                cars.Add(car);
            }

            cars.ForEach(c => Console.Write(c.ToString()));
        }
    }
}
