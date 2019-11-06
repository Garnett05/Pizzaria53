using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Pizzaria53.App;

namespace Pizzaria53.Cliente
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MeuPedido : ContentPage
    {
        public MeuPedido()
        {
            InitializeComponent();
            ItensPedido1.Text = varPizzaMussarela.SaborPizza;
            ValorPedido1.Text = "Total: " + Convert.ToString(varPizzaMussarela.ValorPizzaTotal) + ",00";
        }
        private void goDetailsPage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MainPage());

        }
    }
}