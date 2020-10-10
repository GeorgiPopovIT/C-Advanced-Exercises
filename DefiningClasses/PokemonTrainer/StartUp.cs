using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Tournament")
                {
                    break;
                }
                var parts = input.Split();
                string trainerName = parts[0];
                string pokemonName = parts[1];
                string pokemonElement = parts[2];
                int pokemonHealth = int.Parse(parts[3]);
                Pokemon currPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                if (!trainers.ContainsKey(trainerName))
                {
                    var trainer = new Trainer(trainerName);
                    trainers.Add(trainerName,trainer);
                }
                trainers[trainerName].Pokemons.Add(currPokemon);
            }

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                Checker(trainers, command);
            }

            trainers = trainers.OrderByDescending(x => x.Value.NumberOfBadges)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var trainer1 in trainers)
            {
                Console.WriteLine($"{trainer1.Key} {trainer1.Value.NumberOfBadges} {trainer1.Value.Pokemons.Count}");
            }
        }
        static void Checker(Dictionary<string,Trainer> dict,string command)
        {
            foreach ((string name,Trainer trainer) in dict)
            {
                if (trainer.Pokemons.Any(p => p.Element == command))
                { 
                    trainer.NumberOfBadges += 1;
                }
                else
                {
                    trainer.Pokemons.ForEach(x => x.Health -= 10);
                    trainer.Pokemons.RemoveAll(x => x.Health <= 0);
                }
            }
        }
    }
}
