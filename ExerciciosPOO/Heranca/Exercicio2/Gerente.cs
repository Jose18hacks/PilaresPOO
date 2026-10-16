using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Heranca.Exercicio2
{
    internal class Gerente : Funcionario
    {
        public double Bonus { get; set; }

        public Gerente (string nome, double salario, double bonus) : base(nome, salario) 
        {
            Bonus = bonus;
        }
        public double SalarioComBonus()
        {
            return Salario + Bonus;
        }
    }
}
