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
        private Faction faction;
        private bool isAlive = true;
        private double restHealMultiplier;

        public Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;
            this.Health = health;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;
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
        public double Health { get => health; set => health = value; }
        public double BaseArmor { get => baseArmor; set => baseArmor = value; }
        public double Armor { get => armor; private set => armor = value; }
        public double AbilityPoints { get => abilityPoints; private set => abilityPoints = value; }
        public virtual double RestHealMultiplier { get => 0.2; }
        public Bag Bag { get => bag; private set => bag = value; }
        public Faction Faction { get => faction; private set => faction = value; }

        public bool IsAlive
        {
            get => isAlive;
            private set
            {
                if (this.baseHealth <= 0)
                {
                    isAlive = false;
                }
                isAlive = value;
            }
        }

        public void TakeDamage(double hitPoints)
        {
            this.CheckAlive();

            if (this.Armor < hitPoints)
            {
                armor -= hitPoints;
                armor = 0;
                health -= hitPoints;

                if (health <= 0)
                {
                    this.IsAlive = false;
                    this.health = 0;
                }
            }

            this.Armor -= hitPoints;
            
        }

        public void Rest()
        {
            this.CheckAlive();

            this.Health += this.Health * (this.BaseHealth * RestHealMultiplier);
        }

        public void UseItem(Item item)
        {
            this.CheckAlive();
            item.AffectCharacter(this);
        }

        public void UseItemOn(Item item, Character character)
        {
            this.CheckAlive();
            character.CheckAlive();

            item.AffectCharacter(character);
        }

        public void GiveCharacterItem(Item item, Character character)
        {
            this.CheckAlive();
            character.CheckAlive();

            character.ReceiveItem(item);
        }

        public void ReceiveItem(Item item)
        {
            this.CheckAlive();
            this.bag.AddItem(item);
        }

        internal void CheckAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }

        internal void IncreaseHealth(double points)
        {
            this.Health = Math.Min(BaseHealth, Health + points);
        }
    }
}
