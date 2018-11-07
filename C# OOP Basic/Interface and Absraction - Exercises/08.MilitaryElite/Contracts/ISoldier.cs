using System;
using System.Collections.Generic;
using System.Text;

namespace _08.MilitaryElite.Contracts
{
    public interface ISoldier
    {
        int Id { get; } //if here is set, we create folder models and Soldier.cs with field and prop Id
                        //if we dont have set here, it has to be private in Soldier.cs

        string FirstName { get; }
        string LastName { get; }
    }
}
