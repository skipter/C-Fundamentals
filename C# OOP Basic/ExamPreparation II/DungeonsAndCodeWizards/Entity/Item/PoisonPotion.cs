﻿using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Entity.Character;

namespace DungeonsAndCodeWizards.Entity.Item
{
    using Entity.Character;

    public class PoisonPotion : Item
    {
        private const int PoisonPotionWeight = 5;

        public PoisonPotion() 
            : base(PoisonPotionWeight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            character.Health -= 20;
        }
    }
}
