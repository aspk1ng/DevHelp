using App1;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace DevHelp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FeedbackPage : ContentPage
    {

        public FeedbackPage()
        {
            InitializeComponent();
        }
        private async void SendMail(object sender, EventArgs e)
        {
            await Email.ComposeAsync(UserName.Text, UserMessage.Text, UserEmail.Text);
        }

        private async void Return_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppMainPage());
        }
    }
}