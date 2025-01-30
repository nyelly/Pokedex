using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokedexx.Dominio
{
    public class Pokedex
    {
        private List<Pokemon> pokemons = new List<Pokemon>();

        List<int> Numeros = new List<int>();
        public void AdicionarPokemon(Pokemon pokemon)
        {
            pokemons.Add(pokemon);
            //Numeros.Add(pokemon);
            Console.WriteLine($"{pokemon.Nome} foi adicionado à Pokédex!");
        }

        public void ListarPokemons()
        {
            if (pokemons.Count == 0)
            {
                Console.WriteLine("A Pokédex está vazia.");
                return;
            }

            Console.WriteLine("\n Lista de Pokémon:");
            foreach (var pokemon in pokemons)
            {
                pokemon.ExibirInfo();
            }
        }

        public void BuscarPokemon(string nome)
        {
            //var encontrado = pokemons.FirstOrDefault(p => p.Nome.ToLower() == nome.ToLower());
            Pokemon encontrado = null;

            //for (int i = 0; i < pokemons.Count; i++)
            //{
            //    encontrado = pokemons[i];
            //    if (encontrado.Nome.ToLower() == nome.ToLower())
            //    {
            //        break;
            //    }
            //}

            foreach (Pokemon abacaxi in pokemons)
            {
                if (abacaxi.Nome.ToLower() == nome.ToLower())
                {
                    encontrado = abacaxi;
                    break;
                }
            }

            if (encontrado != null)
            {
                Console.WriteLine("\n Pokémon encontrado:");
                Console.WriteLine(encontrado.ExibirInfo());
            }
            else
            {
                Console.WriteLine($" {nome} não está na Pokédex.");
            }
        }
    }

}

