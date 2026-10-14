using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    internal class Livro
    {
        public string Titulo;
        public string Autor;
        public int Paginas;

        public Livro(string titulo, string autor, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
        }

        public void Exibir()
        {
            Console.WriteLine($" Nome do livro: {Titulo}\n Autor: {Autor}\n Paginas: {Paginas}");
        }
    }
}
