using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pizzaria53.Cliente
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cardapio : ContentPage
    {
        public Cardapio()
        {
            InitializeComponent();
        }
        private void goMenuPage (object sender, EventArgs args)
        {
            App.Current.MainPage = new Cliente.Menu.Master();
        }
    }
}