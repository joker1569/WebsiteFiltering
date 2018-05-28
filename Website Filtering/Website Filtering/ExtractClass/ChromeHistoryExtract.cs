using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace FilterContent.ExtractClass
{
    class ChromeHistoryExtract
    {
        public String UserName;
        public int NumURL;
        public ChromeHistoryExtract() { }

        public ChromeHistoryExtract(String UserName, int NumURL)
        {
            this.UserName = UserName;
            this.NumURL = NumURL;
        }

        public List<HistoryItem> getHistoryBrowser()
        {
            List<HistoryItem> allHistoryItems = new List<HistoryItem>();
            string chromeHistoryFile = @"C:\Users\" + UserName + @"\AppData\Local\Google\
                                        Chrome\User Data\Default\History";
            if (File.Exists(chromeHistoryFile))
            {
                using (SQLiteConnection connection 
                       = new SQLiteConnection("Data Source=" + chromeHistoryFile))
                {
                    connection.Open();

                    String command = "select * from urls order by last_visit_time desc limit " 
                                   + NumURL.ToString();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command, connection);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);
                    if (dataset != null && dataset.Tables.Count > 0 & dataset.Tables[0] != null)
                    {
                        DataTable dt = dataset.Tables[0];
                        foreach (DataRow historyRow in dt.Rows)
                        {
                            HistoryItem historyItem = new HistoryItem();
                            historyItem.URL = Convert.ToString(historyRow["url"]);
                            historyItem.Title = Convert.ToString(historyRow["title"]);
                            long utcMicroSeconds = Convert.ToInt64(historyRow["last_visit_time"]);
                            DateTime gmtTime = DateTime.FromFileTimeUtc(10 * utcMicroSeconds);
                            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc
                                                (gmtTime, TimeZoneInfo.Local);
                            historyItem.VisitedTime = localTime;
                            allHistoryItems.Add(historyItem);
                        }
                    }
                }
            }
            return allHistoryItems;
        }
    }
}
