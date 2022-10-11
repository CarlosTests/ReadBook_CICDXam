using Microsoft.AppCenter.Analytics;
using ReadBooks.Services;
using Xamarin.Forms;

namespace ReadBooks.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //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

        async void AddBook_ButtonClicked(System.Object sender, System.EventArgs e)
        {
            AppCenterHelper.TrackEvent("go-new-book");
            await Navigation.PushAsync(new NewBookPage());
        }

        async void Login_buttonClicked(System.Object sender, System.EventArgs e)
        {
            AppCenterHelper.TrackEvent("go-login-page");
            await Navigation.PushModalAsync(new LoginPage());
        }
    }
}

