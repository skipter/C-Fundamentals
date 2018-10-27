using P01_RawData;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08.RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private List<Tire> tire;
        private Cargo cargo;

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tyre)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tire = tyre;
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

        public Engine Engine
        {
            get
            {
                return this.engine;
            }
            set
            {
                this.engine = value;
            }
        }
        public List<Tire> Tire
        {
            get
            {
                return tire;
            }
            set
            {
                tire = value;
            }
        }
        public Cargo Cargo
        {
            get
            {
                return this.cargo;
            }
            set
            {
                this.cargo = value;
            }
        }
    }
}