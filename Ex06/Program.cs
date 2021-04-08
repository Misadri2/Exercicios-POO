using System;
using System.Linq;
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

            Console.WriteLine("Quantidade de Pessoas inicial :" + pessoas.Count);

            if (pessoa1.Idade < 18)
            {
                pessoas.Remove(pessoa1);
            }
            if (pessoa2.Idade < 18)
            {
                pessoas.Remove(pessoa2);
            }
            if (pessoa3.Idade < 18)
            {
                pessoas.Remove(pessoa3);
            }
            if (pessoa4.Idade < 18)
            {
                pessoas.Remove(pessoa4);
            }

            Console.WriteLine("Quantidade de Pessoas inicial :" + pessoas.Count);

            if (pessoas.Contains(pessoa4))
            {
                Console.WriteLine("Nome: " + pessoa4.Nome + " / Idade: " + pessoa4.Idade);
            }
        }
    }
}

