using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria53.Cliente
{
    public class CadUser
    {
        public string Nome { get; set; }
        public string Mail { get; set; }        
        public string Senha { get; set; }
        public string SenhaConfirmacao { get; set; }

        public CadUser() { }

        public CadUser(string Nome, string Mail, string Senha, string SenhaConfirmacao)
        {
            this.Nome = Nome;
            this.Mail = Mail;
            this.Senha = Senha;
            this.SenhaConfirmacao = SenhaConfirmacao;
        }
    }
}
