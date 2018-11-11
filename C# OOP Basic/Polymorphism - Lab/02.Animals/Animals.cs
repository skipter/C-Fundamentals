using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animals
    {
        private string name;
        private string fauvoriteFood;

        public Animals(string name, string fauvoriteFood)
        {
            this.Name = name;
            this.FauvoriteFood = fauvoriteFood;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                value = this.name;
            }
        }
        public string FauvoriteFood
        {
            get
            {
                return this.fauvoriteFood;
            }
            set
            {
                value = this.fauvoriteFood;
            }
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.FauvoriteFood}";
        }
    }
}
