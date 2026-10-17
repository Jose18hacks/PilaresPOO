using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PilaresPOO.Polimorfismo
{
    internal class Animal
    {
        public virtual void FazerSom()
        {
            Console.WriteLine("O animal faz som");
        }
    }

    internal class Cachorro : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine("Au au!");
        }
    }

    internal class Gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine("Miau");
        }
    }
}
