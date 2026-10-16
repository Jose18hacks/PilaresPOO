using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Heranca.Exercicio3
{
    internal class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        
        public Veiculo(string  marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public void Exibir()
        {
            Console.WriteLine($"{Marca} {Modelo}");
        }
    }
}
