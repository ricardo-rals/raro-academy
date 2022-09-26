using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autorizacao
{
    public class Usuario
    {
        public string Email {get;set;}
        public string Senha {get;set;}
        public string ConfirmacaoSenha {get; set;}
        public Usuario(string Email, string Senha, string ConfirmacaoSenha)
        {
            this.Email = Email;
            this.Senha = Senha;
            this.ConfirmacaoSenha = ConfirmacaoSenha;
        }


    }
}