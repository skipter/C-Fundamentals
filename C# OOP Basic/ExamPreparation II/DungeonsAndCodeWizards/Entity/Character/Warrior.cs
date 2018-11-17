using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Entity.Bag;

namespace DungeonsAndCodeWizards.Entity.Character.Contracts
{
    using Entity.Bag;
    public class Warrior : Character
    {
        private const int BaseHealth = 100;
        private const int BaseArmor = 50;
        private const int AbilityPoints = 40;
        private static Bag bag = new Satchel() { };

        public Warrior(string name, Faction faction) 
            : base(name, BaseHealth, BaseArmor, AbilityPoints, bag, faction)
        {
            
        }

        public void Attack(Character character)
        {

        }
    }
}
