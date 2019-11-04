 using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections;

namespace Pizzaria53
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Cliente.MeuPedido());
        }
        public static class Globais
        {
            public static string GlobalNome;
            public static string SenhaConfirmacao;
            public static ArrayList MeuPedido = new ArrayList();
        }
        public static class varPizzaMussarela
        {
            public static string SaborPizza = "Pizza de Mussarela";
            public static string TamanhoPizza;
            public static int QuantidadePizza;
            public static float ValorPizza = 22;
            public static float ValorPizzaTotal;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
