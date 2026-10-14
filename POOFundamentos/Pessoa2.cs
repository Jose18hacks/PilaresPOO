using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace POOFundamentos
{
    public class Pessoa2
    {
        public string Nome;

        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, eu sou {Nome}");
        }
        public void CumprimentarAlguem(string outraPessoa)
        {
            Console.WriteLine($"Olá, {outraPessoa}. Meu nome é {Nome}");
        }
        public string ObterApresentacao()
        {
            return $"Meu nome é {Nome}";
        }
    }
}
