using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pizzaria53.App;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pizzaria53.Cliente
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }
        private void goCardapioPage (object sender, EventArgs args)
        {
            Navigation.PushAsync(new Cliente.Cardapio()); 
        }
        private void goMeuPedidoPage (object sender, EventArgs args)
        {
            if (varPizzaMussarela.QuantidadePizza != 0) {
                
            }
            else if(varPizzaToscana.QuantidadePizza != 0)
            {
                Navigation.PushAsync(new Cliente.MeuPedido());
            }
            else if(varPizza3queijos.QuantidadePizza != 0)
            {
                Navigation.PushAsync(new Cliente.MeuPedido());
            }
            else
            {
                DisplayAlert("Vazio", "O seu carrinho está vazio!", "Ok");
            }
            
        }
    }
}