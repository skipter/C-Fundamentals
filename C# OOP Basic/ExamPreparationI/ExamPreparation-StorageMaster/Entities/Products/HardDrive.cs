using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Products
{
    class HardDrive : Product
    {
        private const int hardDriveWeight = 1;

        public HardDrive(double price) 
            : base(price, hardDriveWeight)
        {
        }
    }
}
