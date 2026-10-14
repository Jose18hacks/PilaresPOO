using System;
using System.Collections.Generic;
using System.Text;

namespace POOFundamentos
{
    public class Lampada
    {
        public bool Ligada;

        public bool Ligar()
        {
            Ligada = true;
            return Ligada;
        }
        public bool Desligar()
        {
            Ligada = false;
            return Ligada;
        }
        public bool Alternar()
        {
            Ligada = !Ligada;
            return Ligada;
        }
        public void ExibirEstado()
        {
            if (Ligada == true)
            {
                Console.WriteLine("A lampada está ligada!");
            }
            else
            {
                Console.WriteLine("A lampada está desligada!");
            }
        }
    }
}
