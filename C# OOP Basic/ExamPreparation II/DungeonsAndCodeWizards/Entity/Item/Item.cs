using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entity.Item
{
    using Character;

    public abstract class Item
    {
        private int weight;

        public Item(int weight)
        {
            this.Weight = weight;
        }

        public int Weight { get => weight; private set => weight = value; }

        public virtual void AffectCharacter(Character character)
        {
            if (!character.IsAlive) 
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }
    }
}
