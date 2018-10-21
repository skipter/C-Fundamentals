namespace _12.Google
{
    public class Car
    {
        private string carModel;
        private int speed;

        public Car(string carModel, int speed)
        {
            this.CarModel = carModel;
            this.Speed = speed;
        }

        public string CarModel
        {
            get
            {
                return this.carModel;
            }
            set
            {
                this.carModel = value;
            }
        }

        public int Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                this.speed = value;
            }
        }

        public override string ToString()
        {
            return $"{this.CarModel} {this.Speed}";
        }
    }
}
