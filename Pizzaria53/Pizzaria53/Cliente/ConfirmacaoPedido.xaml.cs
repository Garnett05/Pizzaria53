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
        public ConfirmacaoPedido()
        {
            InitializeComponent();
            PizzaMussarela.Text = varPizzaMussarela.SaborPizza;
            TamanhoMussarela.Text = "Tamanho: "+ varPizzaMussarela.TamanhoPizza;
            ValorMussarela.Text = Convert.ToString (varPizzaMussarela.ValorPizzaTotal);

        }        
    }
}