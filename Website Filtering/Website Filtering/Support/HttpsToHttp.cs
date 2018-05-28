using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterContent.Support
{
    class HttpsToHttp
    {
        public String url;
        public HttpsToHttp(String url)
        {
            this.url = url;
        }
        public String Convert()
        {
            String result = "";
            String head = url.Substring(0, 8);
            if(head == "https://")
            {
                result = "http://" + url.Substring(8);
            }
            else
            {
                result = url;
            }
            return result;
        }
    }
}
