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
        private void goCardapio2(object sender, EventArgs args)
        {
            CadUser cadastro = new CadUser(nome.Text, mail.Text, senha.Text, senhaConfirmacao.Text);
            Globais.GlobalNome = cadastro.Nome;

            if (cadastro.Senha == cadastro.SenhaConfirmacao)
            {
                App.Current.MainPage = new Cliente.Cadastro2();
            }
            else { 
                DisplayAlert("Senha", "Atenção: As senhas informadas não estão iguais!", "Ok");
            }
        }
    }    
}