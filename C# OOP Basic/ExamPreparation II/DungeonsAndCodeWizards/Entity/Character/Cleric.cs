using DungeonsAndCodeWizards.Entity.Bag;
using DungeonsAndCodeWizards.Entity.Character.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entity.Character
{
    using Entity.Bag;

    public class Cleric : Character
    {
        private const int BaseHealth = 50;
        private const int BaseArmor = 25;
        private const int AbilityPoints = 40;
        private static Bag bag = new Backpack() { };

        public Cleric(string name, Faction faction) 
            : base(name, BaseHealth, BaseArmor, AbilityPoints, bag, faction)
        {
        }

        public override double RestHealMultiplier => 0.5;

        public void Heal(Character character)
        {
            this.CheckAlive();
            character.CheckAlive();

            if (this.Faction != character.Faction)
            {
                throw new InvalidOperationException("Cannot heal enemy character!");
            }

            character.IncreaseHealth(AbilityPoints);
        }
    }
}
