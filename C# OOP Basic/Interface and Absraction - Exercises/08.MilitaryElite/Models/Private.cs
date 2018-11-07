using _08.MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08.MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary
        {
            get => Salary;
            private set => Salary = value;
        }

        public override string ToString()
        {
            return base.ToString() + $"Salary: {this.Salary:F2}";
        }
    }
}
