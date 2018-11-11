using System;
namespace Shapes
{
    public class Circle : Shapes
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            var area = 2 * Math.PI * this.radius;
            return area;
        }
        public override double CalculatePerimeter()
        {
            var perimeter = Math.PI * this.radius * this.radius;
            return perimeter;
        }
        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}