using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterContent.ExtractClass
{
    class HistoryItem
    {
        public HistoryItem() {}
        public HistoryItem(String URL, String Title, DateTime VisitedTime)
        {
            this.URL = URL;
            this.Title = Title;
            this.VisitedTime = VisitedTime;
        }
        public string URL { get; set; }
        public string Title { get; set; }
        public DateTime VisitedTime { get; set; }
    }
}
