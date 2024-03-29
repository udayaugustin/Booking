﻿using System;
using BookingManager.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookingManager
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();            

            MainPage = new InitialValidation();
        }

        protected override void OnStart()
        {
            // Handle when your app starts

            var connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            connection.CreateTableAsync<Booking>();
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
