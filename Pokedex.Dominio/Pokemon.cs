using System;

namespace Pokedexx.Dominio
{
    public class Pokemon
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }

        public Pokemon(string nome, string tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }

        public string ExibirInfo()
        {
            return $"Nome: {Nome}, Tipo: {Tipo}";
        }
    }
}


