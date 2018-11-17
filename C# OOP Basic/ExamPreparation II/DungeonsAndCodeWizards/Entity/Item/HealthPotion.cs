using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Entity.Character;

namespace DungeonsAndCodeWizards.Entity.Item
{
    using Entity.Character;

    public class HealthPotion : Item
    {
        private const int HealthPotionWeight = 5;

        public HealthPotion() 
            : base(HealthPotionWeight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            int healthFromPotion = 20;

            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            character.Health += healthFromPotion;
        }
    }
}
