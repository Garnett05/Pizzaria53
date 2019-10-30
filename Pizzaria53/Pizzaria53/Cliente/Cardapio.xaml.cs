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
        int qntd = 0;
        public Cardapio()
        {
            InitializeComponent();            
        }
        private void ActionMudarIndex(object sender, EventArgs args)
        {
            Picker obj = (Picker)sender;
            qntd = obj.SelectedIndex;
        }
        public async void addMussarela (object sender, EventArgs e)
        {
            var resultado = await DisplayAlert("Confirmação", "Deseja inserir o pedido no seu carrinho?", "Não", "Sim");
            if (resultado == false)
            {
                await DisplayAlert("Confirmação", "Item adicionado ao carrinho!", "Ok");
                CarrinhoPizza carrinhoMussarela = new CarrinhoPizza("Mussarela", 'M', qntd);
                var CardapioOpcoes = new CardapioOpcoes();
                CardapioOpcoes.BindingContext = carrinhoMussarela;
                await Navigation.PushAsync(CardapioOpcoes);
            }
            else
            {
               await DisplayAlert("Confirmação", "O item não foi inserido no carrinho", "Ok");
            }
        }
        private void goMenuPage(object sender, EventArgs args)
        {            
            
        }
    }
}