using System;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace ReadBooks.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set;}

        public DateTime FinishedDate { get; set; }

        public bool SaveBook()
        {
            //Crashes.GenerateTestCrash();
            Analytics.TrackEvent("new-book");
            return true;
        }
    }
}
