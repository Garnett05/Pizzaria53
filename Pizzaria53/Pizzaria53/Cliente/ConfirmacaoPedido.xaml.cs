using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Pizzaria53.App;

namespace Pizzaria53.Cliente
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfirmacaoPedido : ContentPage
    {
        float aux;
        public ConfirmacaoPedido()
        {
            InitializeComponent();
            PizzaMussarela.Text = varPizzaMussarela.SaborPizza;
            TamanhoMussarela.Text = "Tamanho: "+ varPizzaMussarela.TamanhoPizza;            
            ValorMussarela.Text = "Valor: R$" + varPizzaMussarela.ValorPizzaTotal.ToString("N2");

            PizzaToscana.Text = varPizzaToscana.SaborPizza;
            TamanhoToscana.Text = "Tamanho: " + varPizzaToscana.TamanhoPizza;
            ValorToscana.Text = "Valor: R$" + varPizzaToscana.ValorPizzaTotal.ToString("N2");

            Pizza3queijos.Text = varPizza3queijos.SaborPizza;
            Tamanho3queijos.Text = "Tamanho: " + varPizza3queijos.TamanhoPizza;
            Valor3queijos.Text = "Valor: R$" + varPizza3queijos.ValorPizzaTotal.ToString("N2");

            if (varPizzaMussarela.QuantidadePizza == 0)
            {
                Stack1.HeightRequest = 0;
            }
            if (varPizzaToscana.QuantidadePizza == 0)
            {
                Stack2.HeightRequest = 0;
            }
            if (varPizza3queijos.QuantidadePizza == 0)
            {
                Stack3.HeightRequest = 0;
            }

            aux = varPizza3queijos.ValorPizzaTotal + varPizzaMussarela.ValorPizzaTotal + varPizzaToscana.ValorPizzaTotal;
            TotalValue.Text = "Total: " + aux.ToString("N2");
        }
        private void enviarPedido(object sender, EventArgs args)
        {
            Pedido1.ValorTotal = aux;            

            if (varPizza3queijos.QuantidadePizza != 0) 
            {
                Pedido1.QntdTotal = varPizza3queijos.QuantidadePizza;
                Pedido1.TresQueijos = varPizza3queijos.SaborPizza;
            }
            if (varPizzaMussarela.QuantidadePizza != 0)
            {
                Pedido1.QntdTotal = Pedido1.QntdTotal + varPizzaMussarela.QuantidadePizza;
                Pedido1.Mussarela = varPizzaMussarela.SaborPizza;
            }
            if (varPizzaToscana.QuantidadePizza != 0)
            {
                Pedido1.QntdTotal = Pedido1.QntdTotal + varPizzaToscana.QuantidadePizza;
                Pedido1.Toscana = varPizzaToscana.SaborPizza;
            }
            Pedido1.HorarioPedido = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
            DisplayAlert("Pedido realizado", "O seu pedido foi realizado com sucesso! Para acompanha-lo, basta acessar o seu carrinho no menu inicial", "Ok");
        }
    }
}