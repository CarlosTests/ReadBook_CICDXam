using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using ReadBooks.Services;

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

        public override string ToString()
        {
            return $"{Name} - {Author}";
        }

        public bool SaveBook()
        {
            //Crashes.GenerateTestCrash();
            var properties = new Dictionary<string, string>
            {
                { "book_info", this.ToString() },
                { "network", "cellular" }                
            };

            AppCenterHelper.TrackEvent("new-book-saved", properties);
            return true;
        }

    }
}
