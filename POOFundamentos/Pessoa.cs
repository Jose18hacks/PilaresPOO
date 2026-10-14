using System;
using System.Collections.Generic;
using System.Text;

namespace POOFundamentos
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}
