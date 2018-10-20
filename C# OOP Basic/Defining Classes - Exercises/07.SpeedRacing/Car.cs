using System;
using System.Collections.Generic;
using System.Text;

namespace _07.SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumation;
        private double distance;

        public Car(string model, double fuelAmount, double fuelCOnsumation)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumation = fuelCOnsumation;
            this.Distance = 0;      //By default

        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public double FuelAmount
        {
            get
            {
                return this.fuelAmount;
            }
            set
            {
                this.fuelAmount = value;
            }
        }

        public double FuelConsumation
        {
            get
            {
                return this.fuelConsumation;
            }
            set
            {
                this.fuelConsumation = value;
            }
        }

        public double Distance
        {
            get
            {
                return this.distance;
            }
            set
            {
                this.distance = value;
            }
        }

        public bool Drive (double distance)
        {
            double fuelNeeded = distance * this.FuelConsumation;  //distance * fuel cons per km

            if (this.FuelAmount < fuelNeeded)
            {
                return false;
            }
            this.FuelAmount -= fuelNeeded;
            this.Distance += distance;
            return true;
        }

    }
}
