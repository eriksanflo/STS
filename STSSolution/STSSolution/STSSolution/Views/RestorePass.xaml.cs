﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace STSSolution.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RestorePass : ContentPage
	{
		public RestorePass ()
		{
			InitializeComponent ();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Blue;// color superior
        }
	}
}