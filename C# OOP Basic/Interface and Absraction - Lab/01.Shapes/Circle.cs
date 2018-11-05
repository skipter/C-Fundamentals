namespace Shapes
{
    public class Circle : IDrawable
    {
        private int radius;

        public int Radius
        {
            get { return this.radius; }

            private set
            {
                this.radius = value;
            }
        }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
