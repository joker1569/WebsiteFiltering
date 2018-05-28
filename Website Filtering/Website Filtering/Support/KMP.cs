using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterContent.Support
{
    class KMP
    {
        public KMP() { }
        public int Compare(String keyword, String content)
        {
            int match = 0;
            keyword = keyword.ToLower();
            int m = keyword.Length, n = content.Length;
            int[] map = new int[m + 5];
            for (int i = 0; i < m + 1; i++) map[i] = -1;
            int si = 1;
            map[si] = 0;
            int sj = map[si];
            while(si < m)
            {
                if (keyword[si] == keyword[sj]) map[si] = map[sj];
                else
                {
                    map[si] = sj;
                    while ((sj >= 0) && (keyword[si] != keyword[sj])) sj = map[sj];
                }
                si++; sj++;
            }
            map[m] = sj;
            si = 0;
            sj = 0;
            while(sj < n)
            {
                while((si >= 0) && (content[sj] != keyword[si]))
                {
                    si = map[si];
                }
                si++;
                if(si == m)
                {
                    match++;
                    si = map[si];
                }
                sj++;
            }
            return match;
        }
    }
}
