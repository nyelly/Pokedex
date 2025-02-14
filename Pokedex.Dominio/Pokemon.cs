using System;

namespace Pokedexx.Dominio
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }

        public Pokemon(string nome, string tipo, int id)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
        }

        public string ExibirInfo()
        {
            return $"Id: {Id},  Nome: {Nome}, Tipo: {Tipo}";
        }
    }
}