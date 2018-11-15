using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Storage
{
    using Entities.Vehicles;
    using Entities.Products;
    using System.Linq;

    public abstract class Storage
    {
        private string name;
        private int capacity;
        private int garageSlots;

        public bool IsFull => this.Products.Sum(p => p.Weight) >= this.Capacity;

        private Vehicle[] garage;

        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(garage);

        private List<Product> products;

        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();
        

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;

            this.products = new List<Product>();
            this.garage = new Vehicle[this.GarageSlots];

            this.FillGarageWithInitialVehicles(vehicles);
        }

        public string Name { get => name; private set => name = value; }
        public int Capacity { get => capacity; private set => capacity = value; }
        public int GarageSlots { get => garageSlots; private set => garageSlots = value; }

        public Vehicle GetVehicle(int garageSlot)
        {
            throw new ArgumentException();
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            throw new ArgumentException();
        }

        public int UnloadVehicle(int garageSlot)
        {
            throw new ArgumentException();
        }

        private void FillGarageWithInitialVehicles(IEnumerable<Vehicle> vehicles)
        {
            int index = 0;

            foreach (Vehicle vehicle in vehicles)
            {
                this.garage[index] = vehicle;
                index++;
            }
        }
    }
}
