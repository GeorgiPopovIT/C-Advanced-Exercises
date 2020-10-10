using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            Name = name;
            Pokemons = new List<Pokemon>();
            NumberOfBadges = 0;
        }
        public Trainer(string name,int badges ,  List<Pokemon> pokemons) : this(name)
        {
            NumberOfBadges = badges;
            Pokemons = pokemons;
        }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }


    }
}
