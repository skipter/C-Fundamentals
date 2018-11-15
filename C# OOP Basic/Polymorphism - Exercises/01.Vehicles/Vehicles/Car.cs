using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Models
{
    public class Car : Vehicles
    {   //We inheritate abstract class Vehicles and he inheritate IVehicle

        private const double airConditionConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            // this.FuelConsumption += 0.9; --> bad practise
            this.FuelConsumption += airConditionConsumption;
        }
    }
}
