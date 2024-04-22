using App1;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevHelp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SharpPage : ContentPage
    {
        public SharpPage()
        {
            InitializeComponent();
        }
        private async void Return_Buttom(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppMainPage());
        }
    }
}