using System;
using System.Collections.Generic;
using System.Linq;


namespace Pokedexx.Dominio
{
    public class Pokedex
    {
        private readonly List<Pokemon> pokemons = new();
        private int ProximoId = 1;

        public void AdicionarPokemon(Pokemon pokemon)
        {
            pokemon.Id = ProximoId++; 
            pokemons.Add(pokemon);
        }

        public List<Pokemon> GetAll()
        {
            return pokemons;
        }

        public Pokemon GetById(int id)
        {
            foreach (var pokemon in pokemons)
            {
                if (pokemon.Id == id)
                {
                    return pokemon;
                }
            }
            return null;
        }

        public Pokemon BuscarPokemon(string nome)
        {
            foreach (var pokemon in pokemons)
            {
                if (pokemon.Nome.ToLower() == nome.ToLower())
                {
                    return pokemon;
                }
            }
            return null;
        }
    }
}