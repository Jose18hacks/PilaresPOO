using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Heranca.Exercicio1
{
    internal class Animal
    {
        public string Nome { get; set; }

        public void Comer()
        {
            Console.WriteLine($"{Nome} Está comendo");
        }
    }
}
