﻿using System;
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
            App.Current.MainPage = new NavigationPage(new Cliente.Menu.Master());
        }        
    }
}