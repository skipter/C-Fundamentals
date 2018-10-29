namespace _01.ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double heigth;

        public Box(double length, double width, double heigth)
        {
            this.Length = length;
            this.Width = width;
            this.Heigth = heigth;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public double Heigth
        {
            get
            {
                return this.heigth;
            }
            set
            {
                this.heigth = value;
            }
        }

        public double BoxVolume()
        {
            // Volume = lwh
            double result = length * width * heigth;
            return result;
        }

        public double LateralSurface()
        {
            // Lateral Surface Area = 2lh + 2wh
            double result = 2 * length * heigth + 2 * width * heigth;
            return result;
        }

        public double SurfaceArea()
        {
            // Surface Area = 2lw + 2lh + 2wh
            double result = 2 * length * width + 2 * length * heigth + 2 * width * heigth;
            return result;
        }
    }
}
