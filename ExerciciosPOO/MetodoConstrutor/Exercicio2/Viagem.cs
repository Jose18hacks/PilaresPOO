using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    internal class Viagem
    {
        public string Destino;
        public int Dias;
        public double ValorDiaria;

        public Viagem(string destino, int dias, double valorDiaria)
        {
            Destino = destino;
            Dias = dias;
            ValorDiaria = valorDiaria;
        }

        public double Calculartotal()
        {
            return Dias * ValorDiaria;
        }
        public void Exibir()
        {
            Console.WriteLine($" Destino: {Destino}\n Dias: {Dias}\n Valor da diária: R$ {ValorDiaria:F2}\n Total: R$ {Calculartotal():F2}");
        }
    }
}