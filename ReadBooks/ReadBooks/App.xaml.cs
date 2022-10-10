using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReadBooks
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart ()
        {
            AppCenter.Start("ios=c821e1d7-4693-4b23-ab7f-43bc6bd4fd36;"+
                            "android=089323c2-51be-4c53-9b79-d336d33754f8",
                            typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

