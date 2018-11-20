using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;


namespace AnimalCentre.Models.Procedures
{
    using Models.Animals;

    public abstract class Procedure : IProcedure
    {
        private ICollection<Animal> procedureHistory;

        public Procedure()
        {

        }

        public string History()
        {
            throw new NotImplementedException();
        }

        public virtual void DoService(IAnimal animal, int procedureTime)
        {
            throw new NotImplementedException();
        }
    }
}
