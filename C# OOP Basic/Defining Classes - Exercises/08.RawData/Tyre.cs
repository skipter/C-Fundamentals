using System;
using System.Collections.Generic;
using System.Text;

namespace _08.RawData
{
    public class Tyre
    {
        private int age;
        private double pressure;

        public Tyre(int age, double pressure)
        {
            this.Age = age;
            this.Pressure = pressure;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public double Pressure
        {
            get
            {
                return this.pressure;
            }
            set
            {
                this.pressure = value;
            }
        }
    }
}
