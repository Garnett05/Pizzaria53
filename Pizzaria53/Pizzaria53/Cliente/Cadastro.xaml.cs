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
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
        }        
        private void goHomePage(object sender, EventArgs args)
        {
            Client cliente = new Client(nome.Text, senha.Text, mail.Text);
            Globais.GlobalNome = cliente.Nome;
            
            App.Current.MainPage = new Cliente.Menu.Master();
        }
    }    
}