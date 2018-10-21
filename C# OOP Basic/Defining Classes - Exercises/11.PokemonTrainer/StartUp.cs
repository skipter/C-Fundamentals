using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PokemonTrainer
{
    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var trainers = new Dictionary<string, Trainer>();

            while (input != "Tournament")
            {
                var data = input.Split();
                if (data.Length == 4)
                {
                    var trainerName = data[0];
                    var pokemonName = data[1];
                    var element = data[2];
                    var health = int.Parse(data[3]);

                    var trainer = new Trainer(trainerName);
                    var pokemon = new Pokemon(pokemonName, element, health);

                    if (!trainers.ContainsKey(trainerName))                             //Check trainerName not trainer !!!
                    {
                        trainers[trainerName] = trainer;                                //To the key Pesho we add trainer with name Pesho
                    }
                    trainers[trainerName].Pokemons.Add(pokemon);                        //To trainer name, we add every current pokemon.
                }

                input = Console.ReadLine();
            }

            while ((input = Console.ReadLine()) != "End")
            {

                foreach (var trainer in trainers)
                {
                    var checkTrainer = trainer.Value;

                    if (checkTrainer.Pokemons.Any(x => x.Element == input))         //Check the trainer for pokemon with current element, and add badge if he have it.
                    {
                        checkTrainer.NumberOfBadges++;                              //Add badge
                    }
                    else
                    {                                                               //If he doesnt have a pokemon with current element, we have to remove - 10 health from every pokemon
                        for (int i = 0; i < checkTrainer.Pokemons.Count; i++)
                        {
                            var currentPokemon = checkTrainer.Pokemons[i];

                            if (currentPokemon.Health > 10)                         //If health is more than 10 , we just remove 10.
                            {
                                currentPokemon.Health -= 10;
                            }
                            else
                            {
                                checkTrainer.Pokemons.Remove(currentPokemon);       //If pokemon health is <= 10, pokemon die, and we remove it from Pokemons.
                                i--;                                                 //Reduce the count besauce of removed/dead pokemon.
                            }
                        }
                    }
                }
            }

            //foreach (var trainer in trainers.OrderByDescending(x => x.Value.NumberOfBadges))
            //{
            //    Console.WriteLine($"{trainer.Key} {trainer.Value.NumberOfBadges} {trainer.Value.Pokemons.Count}");
            //}

            var sorted = trainers.OrderByDescending(t => t.Value.NumberOfBadges);

            foreach (var tr in sorted)
            {
                var trn = tr.Value;
                Console.WriteLine($"{trn.Name} {trn.NumberOfBadges} {trn.Pokemons.Count}");
            }
        }
    }
}
