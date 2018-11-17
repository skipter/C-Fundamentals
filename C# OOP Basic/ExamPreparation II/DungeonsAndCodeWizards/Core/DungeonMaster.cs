using DungeonsAndCodeWizards.Entity.Character;
using DungeonsAndCodeWizards.Entity.Character.Contracts;
using DungeonsAndCodeWizards.Entity.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Core
{
    public class DungeonMaster
    {
        private List<Character> characters;
        private Stack<Item> itemsPool;

        public DungeonMaster()
        {
            this.characters = new List<Character>();
            this.itemsPool = new Stack<Item>();
        }

        public string JoinParty(string[] args)
        {
            string faction = args[0];
            string characterType = args[1];
            string name = args[2];

            if (!Enum.TryParse(faction, out Faction factionResult))
            {
                throw new ArgumentException($"Invalid faction \"{ faction }\"!");
            }

            Character character;

            if (characterType == "Warrior")
            {
                character = new Warrior(name, factionResult);
            }
            else if (characterType == "Cleric")
            {
                character = new Cleric(name, factionResult);
            }
            else
            {
                throw new ArgumentException("Invalid character type \"{ characterType }\"!");
            }

            this.characters.Add(character);

            return $"{name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            string itemName = args[0];

            Item item;

            if (itemName == "ArmorRepairKit")
            {
                item = new ArmorRepairKit();
            }
            else if (itemName == "HealthPotion")
            {
                item = new HealthPotion();
            }
            else if (itemName == "PoisonPotion")
            {
                item = new PoisonPotion();
            }
            else
            {
                throw new ArgumentException("Invalid item \"{ name }\"!");
            }

            itemsPool.Push(item);
            return $"{itemName} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[0];

            var currentName = this.characters.FirstOrDefault(x => x.Name == characterName);

            if (currentName == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }

            if (itemsPool.Count == 0)
            {
                throw new ArgumentException("No items left in pool!");
            }

            var lastItem = this.itemsPool.Pop();

            return $"{characterName} picked up {lastItem}!";
        }

        public string UseItem(string[] args)
        {
            string characterName = args[0];
            string itemName = args[1];

            var character = this.characters.FirstOrDefault(x => x.Name == characterName);
            var item = character.Bag.GetItem(itemName);

            if (character == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }

            character.UseItem(item);

            return $"{character.Name} used {itemName}.";
        }

        public string UseItemOn(string[] args)
        {
            throw new NotImplementedException();
        }

        public string GiveCharacterItem(string[] args)
        {
            throw new NotImplementedException();
        }

        public string GetStats()
        {
            throw new NotImplementedException();
        }

        public string Attack(string[] args)
        {
            throw new NotImplementedException();
        }

        public string Heal(string[] args)
        {
            throw new NotImplementedException();
        }

        public string EndTurn(string[] args)
        {
            throw new NotImplementedException();
        }

        public bool IsGameOver()
        {
            throw new NotImplementedException();
        }
    }
}
