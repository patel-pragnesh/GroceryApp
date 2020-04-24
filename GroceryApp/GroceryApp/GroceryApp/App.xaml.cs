﻿using GroceryApp.Views.Drawer;
using GroceryApp.Views.Screens;
using GroceryApp.Views.TabBars;
using Plugin.SharedTransitions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroceryApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            ///MainPage = new SharedTransitionNavigationPage(new FinalBillView());
            //MainPage = new NavigationPage(new DetailProductView());
            //MainPage = new SharedTransitionNavigationPage(new TabBarCustomer());

            //MainPage = new AppDrawer();
            MainPage = new ReviewManagerView();
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
