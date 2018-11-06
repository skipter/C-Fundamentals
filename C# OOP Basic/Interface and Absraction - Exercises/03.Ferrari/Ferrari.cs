using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Ferrari
{
    public class Ferrari : IFerrari
    {
        public Ferrari(string driver)
        {
            this.Driver = driver;
        }

        public string Driver { get; set; }

        public string Stop()
        {
            return "Brakes!/";
        }

        public string Start()
        {
            return "Zadu6avam sA!/";
        }

        public string Model()
        {
            return "488-Spider/";
        }

        public override string ToString()
        {
            return $"{this.Model()}{this.Stop()}{this.Start()}{this.Driver}";
        }
    }
}
