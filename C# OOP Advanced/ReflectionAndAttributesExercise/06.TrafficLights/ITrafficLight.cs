using System;
using System.Collections.Generic;
using System.Text;

namespace _06.TrafficLights
{
    public interface ITrafficLight
    {
        Light Light { get; }
        void ChangeLight();
    }
}
