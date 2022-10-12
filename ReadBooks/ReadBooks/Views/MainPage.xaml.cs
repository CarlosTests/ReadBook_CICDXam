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
               
        async void Login_buttonClicked(System.Object sender, System.EventArgs e)
        {
            AppCenterHelper.TrackEvent("login_intent");
            await Navigation.PushModalAsync(new LoginPage());
        }

        async void AddBook_ButtonClicked(System.Object sender, System.EventArgs e)
        {
            AppCenterHelper.TrackEvent("add_book_intent");
            await Navigation.PushAsync(new NewBookPage());
        }
    }
}

