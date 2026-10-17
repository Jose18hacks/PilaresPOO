using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace PilaresPOO.Abstracao
{
    internal interface INotificador
    {
        // Apenas metodos
        void Enviar(string mensagem);
    }

    public class Email : INotificador
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"Email disparado: {mensagem}");
        }
    }

    public class Sms : INotificador
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"SMS disparado: {mensagem}");
        }
    }
}