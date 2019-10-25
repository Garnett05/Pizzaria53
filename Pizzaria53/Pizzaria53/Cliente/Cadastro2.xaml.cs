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
    public partial class Cadastro2 : ContentPage
    {
        public Cadastro2()
        {
            InitializeComponent();
        }
        public void goHomePage (object sender, EventArgs args)
        {
            CadUser2 cadastro2 = new CadUser2(ddd.Text, numeroTel.Text, cep.Text, endereco.Text, numeroEnd.Text, complemento.Text, bairro.Text);
            if (cadastro2.Ddd != null && cadastro2.NumeroTel == null)
            {
                DisplayAlert("Número", "O número do telefone foi preenchido, mas não o ddd. Por favor preencher ambos os campos", "Ok");
            }            
        }        
    }
}