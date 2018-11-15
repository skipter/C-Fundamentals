using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Models
{
    public class Bus : Vehicles
    {
        private const double airCOnditionConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            double currentFuelConsumption = this.FuelConsumption;

            if (!IsVehicleEmpty)
            {
                currentFuelConsumption += airCOnditionConsumption;
            }

            double neededFuel = distance * currentFuelConsumption;

            if (this.FuelQuantity < neededFuel)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            this.FuelQuantity -= neededFuel;
            //this.GetType().Name will return Car or Truck.
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
    }
}
