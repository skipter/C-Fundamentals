using _03BarracksFactory.Models.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_BarraksWars.Models.Units
{
    public class Gunner : Unit
    {
        private const int DefaultHealth = 20;
        private const int DefaultDamage = 20;

        protected Gunner() 
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
