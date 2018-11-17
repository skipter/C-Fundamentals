using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entity.Bag
{
    public class Satchel : Bag
    {
        private const int SatchelTypeOfBag = 20;

        public Satchel() 
            : base(SatchelTypeOfBag)
        {
        }
    }
}
