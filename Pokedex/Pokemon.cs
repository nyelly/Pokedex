using System;

public class Pokemon
{
    public string Nome { get; set; }
    public string Tipo { get; set; }

    public Pokemon(string nome, string tipo)
    {
        Nome = nome;
        Tipo = tipo;
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Nome: {Nome}, Tipo: {Tipo}");
    }
}
