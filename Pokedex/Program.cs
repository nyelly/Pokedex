using System;
using Pokedexx.Dominio;

class Program
{
    static void Main()
    {
        Pokedex pokedex = new Pokedex();
        bool rodando = true;

        while (rodando)
        {
            Console.WriteLine("\n Escolha uma opção:");
            Console.WriteLine("1 Adicionar Pokémon");
            Console.WriteLine("2️ Listar Pokémon");
            Console.WriteLine("3️ Buscar Pokémon");
            Console.WriteLine("4️ Sair");
            Console.Write("Opção: ");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.Write("Nome do Pokémon: ");
                    string nome = Console.ReadLine();
                    Console.Write("Tipo do Pokémon: ");
                    string tipo = Console.ReadLine();


                    pokedex.AdicionarPokemon(new Pokemon(nome, tipo));
                    break;

                case "2":
                    pokedex.ListarPokemons();
                    break;

                case "3":
                    Console.Write("Nome do Pokémon para buscar: ");
                    string nomeBusca = Console.ReadLine();
                    pokedex.BuscarPokemon(nomeBusca);
                    break;

                case "4":
                    rodando = false;
                    Console.WriteLine(" Saindo da Pokédex...");
                    break;

                default:
                    Console.WriteLine(" Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}