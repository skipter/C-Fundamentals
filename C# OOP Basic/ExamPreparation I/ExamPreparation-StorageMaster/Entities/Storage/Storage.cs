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
            if (garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }

            Vehicle vehicle = this.garage[garageSlot];

            if (vehicle == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }
            
            return vehicle;
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = this.GetVehicle(garageSlot);

            int foundGarageSlotIndex = deliveryLocation.AddVehicleToGarage(vehicle);
            this.garage[garageSlot] = null;

            return foundGarageSlotIndex;


        }

        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }

            Vehicle vehicle = this.GetVehicle(garageSlot);

            int unloadedProductCounter = 0;

            while (!this.IsFull && !vehicle.IsEmpty)
            {
                Product product = vehicle.Unload();
                this.products.Add(product);
                unloadedProductCounter++;
            }
            return unloadedProductCounter;
        }

        private int AddVehicleToGarage(Vehicle vehicle)
        {
            int freeGarageSlotIndex = Array.IndexOf(this.garage, null);

            if (freeGarageSlotIndex == -1)
            {
                throw new InvalidOperationException("No room in range");
            }

            this.garage[freeGarageSlotIndex] = vehicle;

            return freeGarageSlotIndex;
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
