using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    public class Usuario
    {
        public string Login;
        private string Senha;

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }

        public bool ConferirSenha(string tentativa)
        {
            return tentativa == Senha;
        }
        public void TrocarSenha(string senhaAtual, string novaSenha)
        {
            if (senhaAtual == Senha)
            {
                Senha = novaSenha;
                Console.WriteLine("Senha Alterada!");
            }
            else
            {
                Console.WriteLine("Senha atual Incorreta!");
            }
        }
    }
}