namespace _12.Google
{
    public class Car
    {
        private string carModel;
        private string speed;

        public Car()
        {
            this.CarModel = "";
            this.Speed = "";
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

        public string Speed
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
    }
}
