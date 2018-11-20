using AnimalCentre.Models;
using AnimalCentre.Models.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalCentre.Core
{
    public class AnimalCentre
    {
        Hotel hotel;
        private Dictionary<string, List<Animal>> history;
        private SortedDictionary<string, List<string>> adopted;

        public AnimalCentre()
        {
            hotel = new Hotel();
            history = new Dictionary<string, List<Animal>>();
            adopted = new SortedDictionary<string, List<string>>();
        }

        public string RegisterAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            return null;
        }

        public string Chip(string name, int procedureTime)
        {
            throw new NotImplementedException();
        }

        public string Vaccinate(string name, int procedureTime)
        {
            throw new NotImplementedException();
        }

        public string Fitness(string name, int procedureTime)
        {
            throw new NotImplementedException();
        }

        public string Play(string name, int procedureTime)
        {
            throw new NotImplementedException();
        }

        public string DentalCare(string name, int procedureTime)
        {
            throw new NotImplementedException();
        }

        public string NailTrim(string name, int procedureTime)
        {
            throw new NotImplementedException();
        }

        public string Adopt(string animalName, string owner)
        {
            AnimalCheck(animalName);
            Animal animal = hotel.Animals.Values.FirstOrDefault(x => x.Name == animalName);
            hotel.Adopt(animalName, owner);

            if (!adopted.ContainsKey(owner))
            {
                adopted.Add(owner, new List<string>());
            }
            adopted[owner].Add(animalName);

            if (animal.IsChipped)
            {
                return $"{animal.Owner} adopted animal with chip";
            }
            else
            {
                return $"{animal.Owner} adopted animal without chip";
            }
        }

        public string History(string type)
        {
            throw new NotImplementedException();
        }

        private void AnimalCheck(string animalName)
        {
            if (!hotel.Animals.ContainsKey(animalName))
            {
                throw new ArgumentException("Animal {animal name} does not exist");
            }
        }

    }
}
