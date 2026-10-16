using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    internal class Boletim
    {
        public string Aluno { get; set; }
        private double Nota;

        public void DefinirNota(double valor)
        {
            if (valor < 0 || valor > 10)
            {
                Console.WriteLine($"Nota inválida! {valor}");
                return;
            }

            Nota = valor;
        }
        public double ObterNota()
        {
            return Nota;
        }
    }
}