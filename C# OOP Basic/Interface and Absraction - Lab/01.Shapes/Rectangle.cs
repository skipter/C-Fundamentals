using System;

namespace Shapes
{
    public class Rectangle : IDrawable
    {

        //Fields
        private int width;
        private int height;
        //Prop
        public int Width
        {
            get { return this.width; }

            private set
            {
                if (value < 4)
                {
                    throw new ArgumentException("Width must be minimum 4");
                }
                this.width = value;
            }
        }
        //Prop
        public int Height
        {
            get { return this.height; }

            private set
            {
                if (value < 4)
                {
                    throw new ArgumentException("Height must be minimum 4");
                }
                this.height = value;
            }
        }

        //Constructor
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        //Method
        public void Draw()
        {
            System.Console.WriteLine(new string('*', Width));
            for (int i = 0; i < Height - 2; i++)
            {
                System.Console.WriteLine($"*{new string(' ', Width - 2)}*");
            }
            System.Console.WriteLine(new string('*', Width));
        }
    }
}
