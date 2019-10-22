using Pizzaria53.Models;
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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SignInProcedure(object sender, EventArgs args)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation() != true)
            {
                DisplayAlert("Login", "Login realizado com sucesso", "Ok");
            }
            else
            {
                DisplayAlert("Login", "Não foi posível realizar o login. Usuário e/ou senha vazio(s)", "Ok");
            }
        }
    }
}