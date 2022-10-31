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
                var properties = new Dictionary<string, string>
                {
                    { "user", "carlos@mail.pt" },
                    { "network", "WiFi" }
                };

                AppCenterHelper.TrackEvent("logged_in", properties);

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
