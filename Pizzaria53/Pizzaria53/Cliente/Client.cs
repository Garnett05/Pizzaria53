using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria53.Cliente
{
    public class Client
    {
        public string Nome { get; set; }
        public string Mail { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Senha { get; set; }
        public Client() { }
        public Client(string Nome, string Mail, string Telefone, string Endereco, string Senha)
        {
            this.Nome = Nome;
            this.Mail = Mail;
            this.Telefone = Telefone;
            this.Endereco = Endereco;
            this.Senha = Senha;
        }
        public Client(string Nome, string Senha, string Mail)
        {
            this.Nome = Nome;
            this.Senha = Senha;
            this.Mail = Mail;
        }
    }
}
