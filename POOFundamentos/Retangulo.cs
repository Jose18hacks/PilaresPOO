using System;
using System.Collections.Generic;
using System.Text;

namespace POOFundamentos
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalcularArea()
        {
            return Largura * Altura;
        }
        public double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }
    }
}
