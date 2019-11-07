 using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections;
using System.Collections.Generic;

namespace Pizzaria53
{
    public partial class App : Application
    {
        public static double ScreenHeight;
        public static double ScreenWidth;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Cliente.Menu.Master());
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
        public static class varPizzaToscana
        {
            public static string SaborPizza = "Pizza de Toscana";
            public static string TamanhoPizza;
            public static int QuantidadePizza;
            public static float ValorPizza = 22;
            public static float ValorPizzaTotal;
        }
        public static class varPizza3queijos
        {
            public static string SaborPizza = "Pizza de 3 queijos";
            public static string TamanhoPizza;
            public static int QuantidadePizza;
            public static float ValorPizza = 22;
            public static float ValorPizzaTotal;
        }
        public static class Pedido1
        {
            public static float ValorTotal;
            public static int QntdTotal;
            public static string Mussarela;
            public static string Toscana;
            public static string TresQueijos;
            public static string HorarioPedido;
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
