﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria53.Cliente
{
    public class CarrinhoPizza
    {
        public string SaborPizza { get; set; }
        public char TamanhoPizza { get; set; }
        public int QuantidadePizza { get; set; }

        public CarrinhoPizza() { }

        public CarrinhoPizza(string SaborPizza, char TamanhoPizza, int QuantidadePizza)
        {
            this.SaborPizza = SaborPizza;
            this.TamanhoPizza = TamanhoPizza;
            this.QuantidadePizza = QuantidadePizza;
        }
    }
}
