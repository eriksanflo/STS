﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace STSSolution.Views
{
    public class SplashPage : ContentPage
    {
        Image splashImage;
        AbsoluteLayout sub;
        //private SignInViewModel vm;

        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            sub = new AbsoluteLayout();

            splashImage = new Image
            {
                Source = "Logotipo_200x200.png",
                WidthRequest = 100,
                HeightRequest = 100
            };
            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            sub.Children.Add(splashImage);
            this.BackgroundColor = Color.FromHex("#ffffff");
            this.Content = sub;
        }



        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await splashImage.ScaleTo(1, 2000);
            await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
            await splashImage.ScaleTo(150, 1200, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }

    }
}