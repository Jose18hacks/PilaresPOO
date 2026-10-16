using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Heranca.Exercicio3
{
    internal class Carro : Veiculo
    {
        public  int Portas { get; set; }
        public Carro(string marca, string modelo, int portas) : base(marca, modelo)
        {
            Portas = portas;
        }

        public void ExibirPortas()
        {
            Console.WriteLine($"Portas: {Portas}");
        }
    }
}
