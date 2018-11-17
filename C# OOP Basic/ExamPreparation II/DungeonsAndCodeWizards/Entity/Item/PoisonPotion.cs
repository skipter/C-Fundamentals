﻿using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Entity.Character;

namespace DungeonsAndCodeWizards.Entity.Item
{
    public class PoisonPotion : Item
    {
        private const int PoisonPotionWeight = 5;

        public PoisonPotion() 
            : base(PoisonPotionWeight)
        {
        }

        public override void AffectCharacter(Character.Character character)
        {
            base.AffectCharacter(character);
        }
    }
}
