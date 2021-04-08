using System;

namespace Ex04.Entities
{
    public class Pessoas
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoas (string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

    }
}