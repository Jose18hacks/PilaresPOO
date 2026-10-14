using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    internal class Boletim
    {
        public string Aluno {  get; set; }
        private double Nota;

        public double DefinirNota(double valor)
        {
            if (Nota <0 || Nota > 10)
            {
                Console.WriteLine($"Nota inválida! {Nota}");
                return Nota;
            }
        }
    }
}
