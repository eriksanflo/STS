using Rg.Plugins.Popup.Services;
using STSSolution.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace STSSolution
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void login_btn(object sender, EventArgs e)
        {
            try
            {

               await PopupNavigation.Instance.PushAsync(new Popuplogin());
              
            }
            catch (Exception ex)
            {

                // DisplayAlert("Se Produjo Un Error"+ ex, "OK");

            }
        }

        private void Registrarse_btn(object sender, EventArgs e)
        {
            try
            {

                Navigation.PushAsync(new Register());

            }
            catch (Exception ex)
            {

            }
        }

        private void restaurar_btn(object sender, EventArgs e)
        {
            try
            {

                Navigation.PushAsync(new RestorePass());

            }
            catch (Exception ex)
            {

            }
        }

    }
}
