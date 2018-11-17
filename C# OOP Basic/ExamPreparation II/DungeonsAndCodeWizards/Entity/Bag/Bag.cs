using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entity.Bag
{
    using Entity.Item;
    using System.Linq;

    public abstract class Bag
    {
        private int capacity;
        private readonly List<Item> items;

        public IReadOnlyCollection<Item> Items => this.items.AsReadOnly();

        public Bag(int capacity)
        {
            this.Capacity = capacity;
            this.items = new List<Item>();
        }

        public int Capacity { get => capacity; private set => capacity = value; }

        public void AddItem(Item item)
        {
            if (this.items.Sum(x => x.Weight) + item.Weight > this.Capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }

            items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }

            var item = this.Items.FirstOrDefault(i => i.GetType().Name == name);

            if (item == null)
            {
                throw new InvalidOperationException($"No item with name {name} in bag!");
            }

            items.Remove(item);
            return item;
        }
    }
}
