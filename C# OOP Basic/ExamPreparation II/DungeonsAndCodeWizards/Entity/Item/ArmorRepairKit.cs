using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Entity.Character;

namespace DungeonsAndCodeWizards.Entity.Item
{
    public class ArmorRepairKit : Item
    {
        private const int ArmorRepairKitWeight = 10;

        public ArmorRepairKit() 
            : base(ArmorRepairKitWeight)
        {
        }

        public override void AffectCharacter(Character.Character character)
        {
            base.AffectCharacter(character);
        }
    }
}
