﻿using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Storage
{
    public class AutomatedWarehouse : Storage
    {
        private const int automatedWarehouseCapacity = 1;
        private const int automatedWarehouseSlots = 2;
        private static Vehicle[] DefaultVehicles = new Vehicle[]
        {
            new Truck()
        }; 

        public AutomatedWarehouse(string name) 
            : base(name, automatedWarehouseCapacity, automatedWarehouseSlots, DefaultVehicles)
        {
        }
    }
}
