using System;
using System.Collections.Generic;
using System.Text;

namespace _08.MilitaryElite.Contracts
{
    public interface ILieutenantGeneral : IPrivate
    {
        ICollection<IPrivate> Private { get; set; }
    }
}
