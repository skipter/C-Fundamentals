using System;
using System.Collections.Generic;
using System.Text;

namespace FootShortage.Contracts
{
    public interface IBuyer
    {
        string Name { get; }
        int Food { get; }

        void Buyfood();
    }
}
