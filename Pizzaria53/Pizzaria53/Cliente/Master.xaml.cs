using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pizzaria53.App;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pizzaria53.Cliente.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
            if( Globais.GlobalNome == null) {
                user.Text = "Bem vindo!";
            }
            else
            user.Text = "Olá " + Globais.GlobalNome + "!";
        }
        private void goCardapioPage (object sender, EventArgs args)
        {
            Detail = new Cliente.Cardapio();
        }
        private void goCadastroPage (object sender, EventArgs args)
        {
            Detail = new Cliente.Cadastro();
        }
        private void goLoginPage (object sender, EventArgs args)
        {
            Detail = new Cliente.Login();
        }
    }
}