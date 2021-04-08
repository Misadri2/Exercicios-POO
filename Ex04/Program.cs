using System;
using System.Collections.Generic;
using Ex04.Entities;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas pessoa1 = new Pessoas("João", 15);
            Pessoas pessoa2 = new Pessoas("Leandro", 21);
            Pessoas pessoa3 = new Pessoas("Paulo", 17);
            Pessoas pessoa4 = new Pessoas("Jessica", 18);

            List<Pessoas> pessoas = new List<Pessoas>();

            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);
            pessoas.Add(pessoa3);
            pessoas.Add(pessoa4);

            Pessoas p1 = pessoa1;
            foreach (Pessoas p in pessoas)
            {
                if (p.Idade > p1.Idade)
                {
                    p1 = p;
                }
            }

            Console.WriteLine("Pessoas mais velha é: " + p1.Nome);
            Console.WriteLine("Quantidade de Pessoas inicial :" + pessoas.Count);

        }
    }
}


