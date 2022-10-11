using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using ReadBooks.Services;
using Xamarin.Forms;

namespace ReadBooks.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void Login_ButtonClicked(System.Object sender, System.EventArgs e)
        {
            try
            {

                AppCenterHelper.TrackEvent("user-loged");

                await Navigation.PopModalAsync();

            }
            catch (Exception ex)
            {
                Dictionary<string, string> statusValues = new Dictionary<string, string>
                {
                    { "Signal", "Strong" },
                    { "NewUser", "False" },
                    { "WiFi", "On" },
                };

                AppCenterHelper.TrackError(ex, statusValues);
            }
        }
    }
}
