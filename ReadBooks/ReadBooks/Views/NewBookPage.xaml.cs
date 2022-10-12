using System;
using System.Collections.Generic;
using Microsoft.AppCenter;
using ReadBooks.Models;
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
            var newbook = new Book
            {
                Id = "Id123",
                ISBN = "ISBN123432545235",
                Name = "BookName",
                Author = "AuthorName",
                Publisher = "PublisherName",
                FinishedDate = DateTime.Now.AddYears(-3)
            };

            newbook.SaveBook();
        }
    }
}
