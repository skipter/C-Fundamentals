﻿using MilitaryEliteV1_2.Contracts;
using MilitaryEliteV1_2.EnumM;
using System.Collections.Generic;

namespace MilitaryEliteV1_2.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<IMission>();
        }

        public ICollection<IMission> Missions { get; set; }
        public override string ToString()
        {
           
            return base.ToString() + $"\nCorps: {this.Corps}\nMissions:{(this.Missions.Count == 0? "":"\n" )}{string.Join("\n", this.Missions)}";



        }
    }
}
