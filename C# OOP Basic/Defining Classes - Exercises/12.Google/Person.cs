using System.Collections.Generic;
using System.Text;

namespace _12.Google
{
    public class Person
    {
        private string name;
        private Company company;
        private List<Pokemon> pokemon;
        private List<Family> parents;
        private List<Family> children;
        private Car car;

        public Person(string name)
        {
            this.Name = name;
            this.Company = company;
            this.Car = car;
            this.Pokemon = new List<Pokemon>();
            this.Parents = new List<Family>();
            this.Children = new List<Family>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Company Company
        {
            get
            {
                return this.company;
            }
            set
            {
                this.company = value;
            }
        }

        public List<Pokemon> Pokemon
        {
            get
            {
                return this.pokemon;
            }
            set
            {
                this.pokemon = value;
            }
        }

        public List<Family> Parents
        {
            get
            {
                return this.parents;
            }
            set
            {
                this.parents = value;
            }
        }

        public List<Family> Children
        {
            get
            {
                return this.children;
            }
            set
            {
                this.children = value;
            }
        }

        public Car Car
        {
            get
            {
                return this.car;
            }
            set
            {
                this.car = value;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{this.Name}");
            str.AppendLine("Company:");

            if (this.Company != null)
            {
                str.AppendLine(Company.ToString());
            }

            str.AppendLine("Car:");

            if (this.Car != null)
            {
                str.AppendLine(Car.ToString());
            }

            str.AppendLine("Pokemon:");
            this.Pokemon.ForEach(x => str.AppendLine(x.ToString()));

            str.AppendLine("Parents:");
            this.Parents.ForEach(x => str.AppendLine(x.ToString()));

            str.AppendLine("Children:");
            this.Children.ForEach(x => str.AppendLine(x.ToString()));

            return str.ToString().Trim();
        }
    }
}
