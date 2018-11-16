using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entity.Item
{
    public abstract class Item
    {
        private int weight;

        public Item(int weight)
        {
            this.Weight = weight;
        }

        public int Weight { get => weight; private set => weight = value; }

        public void AffectCharacter(Character character)
        {

        }
    }
}
