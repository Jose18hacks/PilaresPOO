using System;
using System.Collections.Generic;
using System.Text;

namespace POOFundamentos
{
    public class Carros
    {
        //Atributos - Caracteristicas
        public string Marca;
        public string Modelo;
        public int Ano;

        //Metodos - Ações
        //Mostrar as informações do carro
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
        }

    }
}
