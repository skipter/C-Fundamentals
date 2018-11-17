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

        }

        public Item GetItem(string name)
        {
            return null;
        }
    }
}
