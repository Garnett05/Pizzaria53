using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static Pizzaria53.App;

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
            else if (size == "P")
            {
                valor = valor - 2;
            }
            valor = valor * qntd;
            return valor;
        }

        public async void addMussarela(object sender, EventArgs e)
        {
            var resultado = await DisplayAlert("Confirmação", "Deseja inserir o pedido no seu carrinho?", "Não", "Sim");
            if (resultado == false)
            {
                var QntdSelecionada = PickerQntdMussarela.Items[PickerQntdMussarela.SelectedIndex];
                varPizzaMussarela.QuantidadePizza = Convert.ToInt32(QntdSelecionada);
                varPizzaMussarela.TamanhoPizza = PickerTamanhoMussarela.Items[PickerTamanhoMussarela.SelectedIndex];                
                varPizzaMussarela.ValorPizzaTotal = ValorPedido(varPizzaMussarela.QuantidadePizza, varPizzaMussarela.ValorPizza, varPizzaMussarela.TamanhoPizza);
                await DisplayAlert("Confirmação", "Item adicionado ao carrinho!", "Ok");
            }
        }
        public async void addToscana(object sender, EventArgs e)
        {
            var resultado = await DisplayAlert("Confirmação", "Deseja inserir o pedido no seu carrinho?", "Não", "Sim");
            if (resultado == false)
            {
                var QntdSelecionada = PickerQntdToscana.Items[PickerQntdToscana.SelectedIndex];
                varPizzaToscana.QuantidadePizza = Convert.ToInt32(QntdSelecionada);
                varPizzaToscana.TamanhoPizza = PickerTamanhoToscana.Items[PickerTamanhoToscana.SelectedIndex];
                varPizzaToscana.ValorPizzaTotal = ValorPedido(varPizzaToscana.QuantidadePizza, varPizzaToscana.ValorPizza, varPizzaToscana.TamanhoPizza);
                await DisplayAlert("Confirmação", "Item adicionado ao carrinho!", "Ok");
            }
        }
        public async void add3queijos(object sender, EventArgs e)
        {
            var resultado = await DisplayAlert("Confirmação", "Deseja inserir o pedido no seu carrinho?", "Não", "Sim");
            if (resultado == false)
            {
                var QntdSelecionada = PickerQntd3queijos.Items[PickerQntd3queijos.SelectedIndex];
                varPizza3queijos.QuantidadePizza = Convert.ToInt32(QntdSelecionada);
                varPizza3queijos.TamanhoPizza = PickerTamanho3queijos.Items[PickerTamanho3queijos.SelectedIndex];
                varPizza3queijos.ValorPizzaTotal = ValorPedido(varPizza3queijos.QuantidadePizza, varPizza3queijos.ValorPizza, varPizza3queijos.TamanhoPizza);
                await DisplayAlert("Confirmação", "Item adicionado ao carrinho!", "Ok");
            }
        }
        private void goMenuPage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ConfirmacaoPedido());

        }
    }
}