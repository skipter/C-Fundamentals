using System;
using System.Collections.Generic;
using System.Text;

namespace _08.MilitaryElite.Contracts
{
    public interface ICommando : ISpecialisedSoldier
    {
        ICollection<IMission> Missions { get; set; }
    }
}
