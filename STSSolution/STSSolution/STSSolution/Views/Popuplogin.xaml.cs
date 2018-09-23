using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace STSSolution.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Popuplogin : PopupPage
    {
        public Popuplogin()
        {
            InitializeComponent();
        }
        private void acceso_btn(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Dashboard());
                PopupNavigation.Instance.PopAllAsync(true);
            }
            catch (Exception ex)
            {

            }
        }
    }
}