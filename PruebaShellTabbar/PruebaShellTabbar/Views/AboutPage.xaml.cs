﻿using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PruebaShellTabbar.Views;

namespace PruebaShellTabbar.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPage());

        }
    }
}