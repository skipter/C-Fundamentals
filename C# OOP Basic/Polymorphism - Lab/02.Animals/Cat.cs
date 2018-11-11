using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animals
    {
        public Cat(string name, string fauvoriteFood) : base(name, fauvoriteFood)
        {
        }

        public override string ExplainSelf()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ExplainSelf())
                .Append("MEEOW");

            return builder.ToString();
        }
    }
}
