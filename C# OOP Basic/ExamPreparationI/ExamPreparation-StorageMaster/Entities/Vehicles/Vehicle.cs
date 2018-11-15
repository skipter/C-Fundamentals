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
        private List<Product> products;

        protected Vehicle(int capacity)
        {
            this.Capacity = capacity;
            this.products = new List<Product>();
        }

        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();

        public bool IsFull => this.Products.Sum(p => p.Weight) >= this.Capacity;
        public bool IsEmpty => this.Products.Count == 0;

        public int Capacity { get => capacity; private set => capacity = value; }

        public void LoadProduct(Product product)
        {
            //TODO
        }

        public Product Unload()
        {
            //TODO
            return null;
        }

    }
}
