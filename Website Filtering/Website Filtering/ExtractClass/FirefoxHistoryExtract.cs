using FilterContent.ExtractClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website_Filtering.ExtractClass
{
    class FirefoxHistoryExtract
    {
        public int NumURL;
        public FirefoxHistoryExtract(int NumURL)
        {
            this.NumURL = NumURL;
        }
        public List<HistoryItem> URLs = new List<HistoryItem>();
        public List<HistoryItem> GetHistory()      
        {
            string documentsFolder = Environment.GetFolderPath
                             (Environment.SpecialFolder.ApplicationData);
            documentsFolder += "\\Mozilla\\Firefox\\Profiles\\";
            if (Directory.Exists(documentsFolder))
            {
                 foreach (string folder in Directory.GetDirectories(documentsFolder))
                 {
                       return ExtractUserHistory(folder);
                 }
            }
            return null;
        }

        List<HistoryItem> ExtractUserHistory(string folder)
        {
            DataTable historyDT = ExtractFromTable("moz_places", folder);
            DataTable visitsDT = ExtractFromTable("moz_historyvisits",folder);
            int Count = 0;
            foreach (DataRow row in historyDT.Rows)
            {
                if (Count == NumURL) break;
                var entryDate = (from dates in visitsDT.AsEnumerable()
                                  where dates["place_id"].ToString() == row["id"].ToString()
                                   select dates).LastOrDefault();
                if (entryDate != null)
                {
                    string url = row["Url"].ToString();
                    string title = row["Title"].ToString();       
                    HistoryItem u = new HistoryItem(url.Replace('\'', ' '),
                                         title.Replace('\'', ' '),
                                         DateTime.Now);
                    URLs.Add(u);
                    Count++;
                }
            }
            return URLs;
        }
 
        void DeleteFromTable(string table, string folder)
        {
            SQLiteConnection sql_con;
            SQLiteCommand sql_cmd;
            string dbPath = folder + "\\places.sqlite";
            if (File.Exists(dbPath))
            {
                sql_con = new SQLiteConnection("Data Source=" + dbPath +
                                    ";Version=3;New=False;Compress=True;");
                sql_con.Open();
                string CommandText = "delete from " + table;
                sql_cmd = new SQLiteCommand(CommandText, sql_con);
                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
            }
        }


        DataTable ExtractFromTable(string table, string folder)
        {
            SQLiteConnection sql_con;
            SQLiteCommand sql_cmd;
            SQLiteDataAdapter DB;
            DataTable DT = new DataTable();
            string dbPath = folder + "\\places.sqlite";
            if (File.Exists(dbPath))
            {
                sql_con = new SQLiteConnection("Data Source=" + dbPath +
                                    ";Version=3;New=False;Compress=True;");
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string CommandText = "select * from " + table;
                DB = new SQLiteDataAdapter(CommandText, sql_con);
                DB.Fill(DT);
                sql_con.Close();
            }
            return DT;
        }
    }
}
