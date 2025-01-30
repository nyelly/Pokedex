using System;
using System.Collections.Generic;
using System.Linq;

public class Pokedex
{
    private List<Pokemon> pokemons = new List<Pokemon>();

    public void AdicionarPokemon(Pokemon pokemon)
    {
        pokemons.Add(pokemon);
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
        var encontrado = pokemons.FirstOrDefault(p => p.Nome.ToLower() == nome.ToLower());
        if (encontrado != null)
        {
            Console.WriteLine("\n Pokémon encontrado:");
            encontrado.ExibirInfo();
        }
        else
        {
            Console.WriteLine($" {nome} não está na Pokédex.");
        }
    }
}
