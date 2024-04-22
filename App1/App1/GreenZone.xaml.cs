using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.ComponentModel;

namespace DevHelp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreenZone : ContentPage
	{		
        public GreenZone ()
		{
			InitializeComponent ();
		}
		private async void Return_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new AppMainPage());
		}				
	}
}