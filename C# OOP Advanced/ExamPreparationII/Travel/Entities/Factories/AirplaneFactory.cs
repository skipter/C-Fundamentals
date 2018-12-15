namespace Travel.Entities.Factories
{
	using Contracts;
	using Airplanes.Contracts;
    using System.Reflection;
    using System;
    using System.Linq;

    public class AirplaneFactory : IAirplaneFactory
	{
		public IAirplane CreateAirplane(string type)
		{

            var airplaneType = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == type);
            var airplaneInstance = (IAirplane)Activator.CreateInstance(airplaneType);
            //(airplaneType, new object[] {1, 2, 3,}) if ctor want args

            return airplaneInstance;

            //We dont need switch any more...use reflection
            //switch (type)
            //{
            //    case "LightAirplane":
            //        return new LightAirplane();
            //    case "MediumAirplane":
            //        return new MediumAirplane();
            //    default:
            //        return null; //TODO can be a bug
            //}
		}
	}
}