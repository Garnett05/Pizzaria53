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
            
            ItensPedido1.Text = Pedido1.QntdTotal.ToString() + " item(s) por: R$ " + Pedido1.ValorTotal.ToString("N2");
            DescricaoPedido1.Text = string.Format("{0}\n {1}\n{2}", Pedido1.Mussarela, Pedido1.TresQueijos, Pedido1.Toscana);
            StatusPedido1.Text = Pedido1.HorarioPedido + " - Status: Em preparo";

        }
        private void goDetailsPage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MainPage());

        }
    }
}