using System;
using System.Collections.Generic;
using System.Text;

namespace _08.RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private List<Tyre> tyre;
        private Cargo cargo;

        public Car(string model, Engine engine, Cargo cargo, List<Tyre> tyre)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tyre = tyre;
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
        public List<Tyre> Tyre
        {
            get
            {
                return tyre;
            }
            set
            {
                tyre = value;
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
