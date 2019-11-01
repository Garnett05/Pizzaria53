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
        private void ActionMudarIndex(object sender, EventArgs args)
        {
            Picker obj = (Picker)sender;            
        }
        private float ValorPedido(int qntd, float valor, string size)
        {
            if (size == "G")
            {
                valor = valor + 2;
            }
            else if ( size == "P")
            {
                valor = valor - 2;
            }
            valor = valor * qntd;
            return valor;
        }
        public async void addMussarela (object sender, EventArgs e)
        {
            var resultado = await DisplayAlert("Confirmação", "Deseja inserir o pedido no seu carrinho?", "Não", "Sim");
            if (resultado == false)
            {
                var QntdSelecionada = PickerQntdMussarela.Items[PickerQntdMussarela.SelectedIndex];
                int qntd = Convert.ToInt32(QntdSelecionada);
                string size = PickerTamanhoMussarela.Items[PickerTamanhoMussarela.SelectedIndex];
                float valorMussarela = 22;

                float valorTot = ValorPedido(qntd, valorMussarela, size);

                await DisplayAlert("Confirmação", "Item adicionado ao carrinho!", "Ok");
                CarrinhoPizza carrinhoMussarela = new CarrinhoPizza("Pizza de Mussarela", size, qntd, valorTot);
                var ConfirmacaoPedido = new ConfirmacaoPedido();
                ConfirmacaoPedido.BindingContext = carrinhoMussarela;
                await Navigation.PushAsync(ConfirmacaoPedido);
            }            
        }
        public void addToscana(object sender, EventArgs e)
        {

        }
        public void add3queijos(object sender, EventArgs e)
        {

        }
        private void goMenuPage(object sender, EventArgs args)
        {            
            
        }
    }
}