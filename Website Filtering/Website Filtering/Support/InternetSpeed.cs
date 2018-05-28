using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace FilterContent.Support
{
    class InternetSpeed
    {
        public InternetSpeed() {}
        public double GetDownloadSpeed()
        {
            WebClient wc = new WebClient();
            DateTime dt1 = DateTime.Now;
            byte[] data = wc.DownloadData("http://google.com");
            DateTime dt2 = DateTime.Now;
            return Math.Round((data.Length / 1024) / (dt2 - dt1).TotalSeconds, 2);
        }

        public double GetUploadSpeed()
        {
            double kbsec = 0.0;
            return kbsec;
        }
    }
}
