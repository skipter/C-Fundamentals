using System;

namespace _03.Ferrari
{
    public class StartUp
    {
        public static void Main()
        {
            string driver = Console.ReadLine();

            IFerrari ferrariInfo = new Ferrari(driver);

            Console.WriteLine(ferrariInfo);
        }
    }
}
