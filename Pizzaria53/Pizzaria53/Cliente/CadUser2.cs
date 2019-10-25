using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria53.Cliente
{
    public class CadUser2
    {
        public string Ddd { get; set; }
        public string NumeroTel { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string NumeroEnd { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }

        public CadUser2() { }

        public CadUser2(string Ddd, string NumeroTel, string Cep, string Endereco, string NumeroEnd,  string Complemento, string Bairro)
        {
            this.Ddd = Ddd;
            this.NumeroTel = NumeroTel;
            this.Cep = Cep;
            this.Endereco = Endereco;
            this.NumeroEnd = NumeroEnd;
            this.Complemento = Complemento;
            this.Bairro = Bairro;
        }
    }
}
