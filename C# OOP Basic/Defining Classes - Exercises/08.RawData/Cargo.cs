using System;
using System.Collections.Generic;
using System.Text;

namespace _08.RawData
{
    public class Cargo
    {
        private int cargoWeight;
        private string cargoType;

        public Cargo(int cargoWeigth, string cargoType)
        {
            this.CargoType = cargoType;
            this.CargoWeight = cargoWeigth;
        }

        public int CargoWeight
        { 
            get
            {
                return this.cargoWeight;
            }
            set
            {
                this.cargoWeight = value;
            }
        }

        public string CargoType
        {
            get
            {
                return this.cargoType;
            }
            set
            {
                this.cargoType = value;
            }
        }
    }
}
