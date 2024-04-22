using App1;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevHelp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GitPage : ContentPage
    {
        public GitPage()
        {
            InitializeComponent();
        }

        private async void Return_Buttom(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppMainPage());
        }
        private  void UD_Btn_Clicked(object sender, EventArgs e)
        {
            var isItTrue = ClosedStack.IsVisible;
            if (isItTrue != true)
            {
                ClosedStack.IsVisible = true;
                ButtonUpDown.Text = "˅";
                ShowLabel.IsVisible = false;
            }
            else
            {
                ClosedStack.IsVisible = false;
                ButtonUpDown.Text = "˃";
                ShowLabel.IsVisible = true;
            }
        }
        private void UD_Btn_Clicked2(object sender, EventArgs e)
        {
            var isItTrue = ClosedStack2.IsVisible;
            if (isItTrue != true)
            {
                ClosedStack2.IsVisible = true;
                ButtonUpDown2.Text = "˅";
                ShowLabel2.IsVisible = false;
            }
            else
            {
                ClosedStack2.IsVisible = false;
                ButtonUpDown2.Text = "˃";
                ShowLabel2.IsVisible = true;
            }
        }
    }
}