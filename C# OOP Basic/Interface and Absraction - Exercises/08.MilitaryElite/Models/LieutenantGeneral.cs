using _08.MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08.MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.Private = new List<IPrivate>();
        }

        public ICollection<IPrivate> Private
        {
            get;
            set;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nPrivates:\n    {string.Join("\n    ", this.Private)}";
        }
    }
}
