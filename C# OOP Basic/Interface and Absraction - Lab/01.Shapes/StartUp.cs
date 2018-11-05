using System;

namespace Shapes
{
    public class StartUp
    {
        public static void Main()
        {
            int radius = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            //To import interface must namespace be with samename.
            IDrawable shape = new Rectangle(width, height);
            shape.Draw();
        }
    }
}
