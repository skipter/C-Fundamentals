namespace _10.CarSalesman
{
    public class Engine
    {
        private string engineModel;
        private int power;
        private string displacement;
        private string efficiency;

        public Engine(string engineModel, int power)
        {
            this.EngineModel = engineModel;
            this.Power = power;
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }

        public string EngineModel
        {
            get
            {
                return this.engineModel;
            }
            set
            {
                this.engineModel = value;
            }
        }

        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }

        public string Displacement
        {
            get
            {
                return this.displacement;
            }
            set
            {
                this.displacement = value;
            }
        }

        public string Efficiency
        {
            get
            {
                return this.efficiency;
            }
            set
            {
                this.efficiency = value;
            }
        }
    }
}
