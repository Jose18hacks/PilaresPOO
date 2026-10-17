using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Lista1_ClassesObjetos.INTERMEDIARIO.Exercicio1
{
    public class ContaBancaria
    {
        public string Titular;
        public double Saldo;

        public double Depositar(double valor)
        {
            Saldo += valor;
            return valor;
        }
        public double Sacar(double valor)
        {
            if (Saldo < valor)
            {
                Console.WriteLine($"Saldo Insuficiente para sacar {valor}!");
                return Saldo;
            }
            else
            {
                Saldo -= valor;
                return Saldo;
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo de {Titular}: R$ {Saldo:F2}");
        }
    }
}