using StorageMaster.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Entities.Vehicles
{
    public abstract class Vehicle
    {
        private int capacity;

        private List<Product> trunk;

        protected Vehicle(int capacity)
        {
            this.Capacity = capacity;
            this.trunk = new List<Product>();
        }

        public IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();

        public bool IsFull => this.Trunk.Sum(p => p.Weight) >= this.Capacity;
        public bool IsEmpty => this.Trunk.Count == 0;

        public int Capacity { get => capacity; private set => capacity = value; }

        public void LoadProduct(Product product)
        {
            //check for free space
            if (this.IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            //if there is a free space in trunk
            this.trunk.Add(product);
        }

        public Product Unload()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }

            Product product = this.trunk[this.trunk.Count - 1]; //trunk is the List from upper. -> From this List, list count - 1/last element
            this.trunk.RemoveAt(this.trunk.Count - 1); //we remove the last element

            return product;
        }

    }
}
