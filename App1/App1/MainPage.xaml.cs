using DevHelp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class AppMainPage : ContentPage
    {        
        public AppMainPage()
        {
            InitializeComponent();           
        }
        protected override void OnAppearing()
        {
            
        }
        private async void GitButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GitPage());
        }
        private async void CsharpButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SharpPage());
        }
        private async void Feedback_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FeedbackPage());
        }
        private async void GreenZone_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GreenZone());
        }
    }
}
