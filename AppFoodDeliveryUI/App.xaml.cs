﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFoodDeliveryUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.DeliveryPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
