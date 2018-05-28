using FilterContent.ExtractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UrlHistoryLibrary;

namespace Website_Filtering.ExtractClass
{
    class IEHistoryExtract
    {
        // List of URL objects
        public List<HistoryItem> URLs = new List<HistoryItem>();
        public List<HistoryItem> GetHistory(int NumURL)
        {
            UrlHistoryWrapperClass urlHistory;
            UrlHistoryWrapperClass.STATURLEnumerator enumerator;
            List<STATURL> list = new List<STATURL>();
            urlHistory = new UrlHistoryWrapperClass();
            enumerator = urlHistory.GetEnumerator();
            enumerator.GetUrlHistory(list);
            int Count = 0;
            foreach (STATURL url in list)
            {
                if (Count == NumURL) break;
                HistoryItem item = new HistoryItem();
                item.URL = url.URL;
                item.Title = url.Title;
                item.VisitedTime = DateTime.Now;
                URLs.Add(item);
                Count++;
            }
            return URLs;
        }
    }
}
