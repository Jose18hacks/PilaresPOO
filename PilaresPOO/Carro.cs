using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    internal class Carro
    {
        public string Marca;
        public string Modelo;

        //Metodo Construtor
        //Não tem tipo de retorno
        //Tem o mesmo nome da classe
        public Carro (string marca, string modelo)
        {
            //Recebe uma marca e um modelo
            Marca = marca;
            Modelo = modelo;
        }
    }
}
