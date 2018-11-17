using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Entity.Character;

namespace DungeonsAndCodeWizards.Entity.Item
{
    using Entity.Character;

    public class ArmorRepairKit : Item
    {
        private const int ArmorRepairKitWeight = 10;

        public ArmorRepairKit() 
            : base(ArmorRepairKitWeight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            character.BaseArmor += 10;
        }
    }
}
