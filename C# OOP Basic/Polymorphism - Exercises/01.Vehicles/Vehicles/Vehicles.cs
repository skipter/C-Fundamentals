using _01.Vehicles.Vehicle.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Models
{
    public abstract class Vehicles : IVehicle 
    {   
        //fields - come from IVehicle - there are fields and methods, they are public because its Interface
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;
        //Constructor
        public Vehicles(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public bool IsVehicleEmpty { get; set; }

        public double TankCapacity
        {
            get
            {
                return tankCapacity;
            }
            set
            {
                tankCapacity = value;
            }
        }

        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            set
            {
                if (value > this.TankCapacity)
                {
                    value = 0;
                }

                fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return fuelConsumption;
            }
            set
            {
                fuelConsumption = value;
            }
        }

        //Methods
        public virtual void Drive(double distance)
        {
            double currentFuelConsumption = this.FuelConsumption;

            double neededFuel = distance * this.FuelConsumption;

            if (!IsVehicleEmpty)
            {
                currentFuelConsumption += 1.4;
            }
            
            if (this.FuelQuantity < neededFuel)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            this.FuelQuantity -= neededFuel;
            //this.GetType().Name will return Car or Truck.
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");

        }

        public virtual void Refuel(double fuel) 
        {
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (this.FuelQuantity + fuel > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }

            this.FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.fuelQuantity:F2}";
        }
    }
}
