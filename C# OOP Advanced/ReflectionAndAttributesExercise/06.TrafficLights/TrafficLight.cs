using System;
using System.Collections.Generic;
using System.Text;

namespace _06.TrafficLights
{
    public class TrafficLight : ITrafficLight
    {
        private Light light;

        public TrafficLight(string light)
        {
            this.light = (Light)Enum.Parse(typeof(Light), light);
        }

        public Light Light
        {
            get => this.light;
            private set => this.light = value;
        }

        public void ChangeLight()
        {
            this.Light += 1;
            this.Light = (int)this.Light > 2 ? 0 : this.light;
        }

        public override string ToString()
        {
            return $"{this.Light}";
        }
    }
}
