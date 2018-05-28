using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website_Filtering.Support
{
    class KeywordResult
    {
        public KeywordResult() { }
        public KeywordResult(String Name, int matchCount)
        {
            this.Name = Name;
            this.matchCount = matchCount;
        }
        public String Name { get; set; }
        public int matchCount { get; set; }
    }
}
