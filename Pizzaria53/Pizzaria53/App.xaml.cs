 using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pizzaria53
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Cliente.Home());
        }
        public static class Globais
        {
            public static string GlobalNome;
            public static string SenhaConfirmacao;
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
