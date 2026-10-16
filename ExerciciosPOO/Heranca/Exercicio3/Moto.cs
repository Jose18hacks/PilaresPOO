using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Heranca.Exercicio3
{
    internal class Moto : Veiculo
    {
        public int Cilindradas { get; set; }
        public Moto(string marca, string modelo, int cilindrardas) : base(marca, modelo)
        {
            Cilindradas = cilindrardas;
        }

        public void ExibirCilindradas()
        {
            Console.WriteLine($"Cilindradas: {Cilindradas}");
        }
    }
}
