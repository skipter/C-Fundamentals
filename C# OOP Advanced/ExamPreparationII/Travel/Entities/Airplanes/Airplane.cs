namespace Travel.Entities.Airplanes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Travel.Entities.Airplanes.Contracts;
    using Travel.Entities.Contracts;

    public abstract class Airplane : IAirplane
    {
        
        private List<IBag> baggageCompartment;
        private List<IPassenger> passengers;

        protected Airplane(int seats, int baggageCompartments)
        {
            this.Seats = seats;
            this.BaggageCompartments = baggageCompartments;
            this.passengers = new List<IPassenger>();
            this.baggageCompartment = new List<IBag>();
        }

        //TODO add fields
        public int Seats { get; }
        public int BaggageCompartments { get; }

        public IReadOnlyCollection<IBag> BaggageCompartment => this.baggageCompartment.AsReadOnly();
        public IReadOnlyCollection<IPassenger> Passengers => this.passengers.AsReadOnly();

        public bool IsOverbooked => this.Passengers.Count > this.Seats;


        public void AddPassenger(IPassenger passenger)
        {
            this.passengers.Add(passenger);
        }

        //!!! Use linq to see ibag class and its props. and by them find bags.
        public IEnumerable<IBag> EjectPassengerBags(IPassenger passenger)
        {
            var baggage = this.baggageCompartment
                .Where(x => x.Owner.Username == passenger.Username)
                .ToList();

            this.baggageCompartment
                .RemoveAll(x => x.Owner.Username == passenger.Username);

            return baggage;
        }

        public void LoadBag(IBag bag)
        {
            if (this.BaggageCompartment.Count > this.BaggageCompartments)
            {
                //TODO plane name
                throw new InvalidOperationException("No more bag room in {planeName}!");
            }

            this.baggageCompartment.Add(bag);
        }

        public IPassenger RemovePassenger(int seat)
        {   
            //TODO can be a bug
            var passenger = this.passengers[seat];
            this.passengers.RemoveAt(seat);
            return passenger;
        }
    }
}