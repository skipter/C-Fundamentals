using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entity.Bag
{
    public class Backpack : Bag
    {
        private const int BackpackTypeOfBag = 100;

        public Backpack() 
            : base(BackpackTypeOfBag)
        {
        }
    }
}
