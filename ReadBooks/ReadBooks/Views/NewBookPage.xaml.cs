using System;
using System.Collections.Generic;
using Microsoft.AppCenter;
using ReadBooks.Services;
using Xamarin.Forms;

namespace ReadBooks.Views
{
    public partial class NewBookPage : ContentPage
    {
        public NewBookPage()
        {
            InitializeComponent();
        }
        
        void SaveBook_ButtonClicked(System.Object sender, System.EventArgs e)
        {
            AppCenterHelper.TrackEvent("new-book-added");            
        }
    }
}
