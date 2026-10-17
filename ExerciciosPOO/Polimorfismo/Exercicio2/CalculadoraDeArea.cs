using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Polimorfismo.Exercicio2
{
    internal class CalculadoraDeArea
    {
        public double CalcularArea(double lado)
        {
            return lado * lado;
        }
        public double CalcularArea(double lado, double altura)
        {
            return lado * altura;
        }
        
    }
}
