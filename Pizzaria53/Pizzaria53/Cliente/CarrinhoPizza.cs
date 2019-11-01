using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria53.Cliente
{
    public class CarrinhoPizza
    {
        public string SaborPizza { get; set; }
        public string TamanhoPizza { get; set; }
        public int QuantidadePizza { get; set; }
        public float ValorPedido { get; set; }

        public CarrinhoPizza() { }

        public CarrinhoPizza(string SaborPizza, string TamanhoPizza, int QuantidadePizza, float ValorPedido)
        {
            this.SaborPizza = SaborPizza;
            this.TamanhoPizza = TamanhoPizza;
            this.QuantidadePizza = QuantidadePizza;
            this.ValorPedido = ValorPedido;
        }
    }
}
