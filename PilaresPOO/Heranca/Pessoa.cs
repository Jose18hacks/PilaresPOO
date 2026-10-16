using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Heranca
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, Eu sou sou {Nome} e tenho {Idade} Anos.");
        }
    }
}
