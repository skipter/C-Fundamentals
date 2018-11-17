using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entity.Character
{
    using Entity.Item;
    using Entity.Bag;
    using DungeonsAndCodeWizards.Entity.Character.Contracts;

    public abstract class Character : IAttackable, IHealable
    {
        private string name;
        private double baseHealth;
        private double health;
        private double baseArmor;
        private double armor;
        private double abilityPoints;
        private Bag bag;
        private string faction;
        private bool isAlive = true;
        private double restHealMultiplier;

        public Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;
            this.Health = health;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            
        }

        public string Name
        {
            get => name;
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }

                this.name = value;
            }
        }
        public double BaseHealth { get => baseHealth; private set => baseHealth = value; }
        public double Health { get => health; private set => health = value; }
        public double BaseArmor { get => baseArmor; private set => baseArmor = value; }
        public double Armor { get => armor; private set => armor = value; }
        public double AbilityPoints { get => abilityPoints; private set => abilityPoints = value; }
        public string Faction { get => faction; private set => faction = value; }
        public bool IsAlive { get => isAlive; private set => isAlive = value; }
        public double RestHealMultiplier { get => restHealMultiplier; private set => restHealMultiplier = value; }
        public Bag Bag { get => bag; private set => bag = value; }

        public void TakeDamage(double hitPoints)
        {

        }

        public void Rest()
        {

        }

        public void UseItem(Item item)
        {

        }

        public void UseItemOn(Item item, Character character)
        {

        }

        public void GiveCharacterItem(Item item, Character character)
        {

        }

        public void ReceiveItem(Item item)
        {

        }
    }
}
