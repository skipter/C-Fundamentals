using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Animals
    {
        public Dog(string name, string fauvoriteFood) : base(name, fauvoriteFood)
        {
        }

        public override string ExplainSelf()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ExplainSelf())
                .Append("DJAAF");

            return builder.ToString();
        }
    }
}
