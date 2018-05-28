using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boilerpipe.Net.Extractors;
using System.Net;
using System.IO;

namespace FilterContent.ExtractClass
{
    class GetContentFromURL
    {
        HistoryItem item;
        String url_x;
        public GetContentFromURL() { }
        public GetContentFromURL(HistoryItem item)
        {
            this.item = item;
        }
        public String ExtractContentFromUrl()
        {
            String text = "";
            String Url = item.URL;
            //Console.WriteLine(Url);
            String htmldoc = String.Empty;
            try
            {
                WebRequest request = WebRequest.Create(Url);
                var myhttpwebrequest = (HttpWebRequest)request;
                myhttpwebrequest.UserAgent = @"Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.0.4) Chrome/15.0.874.121 Gecko/20060508 Firefox/1.5.0.4";
                HttpWebResponse response = (HttpWebResponse)myhttpwebrequest.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream stream = response.GetResponseStream();
                    using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8))
                    {
                        htmldoc = streamReader.ReadToEnd();
                    }
                    //text = CommonExtractors.ArticleExtractor.GetText(htmldoc);                 
                    text = KeepEverythingExtractor.Instance.GetText(htmldoc);
                }
                else
                {
                    text = "";
                }
                response.Close();
            }
            catch(Exception e)
            {
                return "";
            }
            return text;
        }
    }
}
