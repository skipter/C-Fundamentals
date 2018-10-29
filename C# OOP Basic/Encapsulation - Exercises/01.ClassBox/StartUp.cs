using System;

namespace _01.ClassBox
{
    public class StartUp
    {
        public static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, heigth);
            Console.WriteLine($"Surface Area - {box.SurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurface():F2}");
            Console.WriteLine($"Volume - {box.BoxVolume():F2}");
        }
    }
}
