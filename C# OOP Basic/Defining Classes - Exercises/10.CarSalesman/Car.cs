using System.Text;

namespace _10.CarSalesman
{
    public class Car
    {
        private string markModel;
        private Engine engineType;
        private string weight;
        private string color;

        public Car(string markModel, Engine engine)
        {
            this.MarkModel = markModel;
            this.Engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }

        public string MarkModel
        {
            get
            {
                return this.markModel;
            }
            set
            {
                this.markModel = value;
            }
        }

        public Engine Engine
        {
            get
            {
                return this.engineType;
            }
            set
            {
                this.engineType = value;
            }
        }

        public string Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder()
                .AppendLine($"{this.MarkModel}:")
                .AppendLine($"  {this.Engine.EngineModel}:")
                .AppendLine($"      Power: {this.Engine.Power}")
                .AppendLine($"      Displacement: {this.Engine.Displacement}")
                .AppendLine($"      Efficiency: {this.Engine.Efficiency}")
                .AppendLine($"  Weight: {this.Weight}")
                .AppendLine($"  Color: {this.Color}");

            return str.ToString();
        }
    }
}
