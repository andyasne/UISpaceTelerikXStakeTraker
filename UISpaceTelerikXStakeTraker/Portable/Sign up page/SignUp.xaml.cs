using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UISpaceTelerikXStakeTraker.Portable.Signuppage
{
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
