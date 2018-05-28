using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilterContent.Support;
using Website_Filtering.Support;

namespace FilterContent.Support
{
    class CheckListString
    {
        public string[] FileName = {"ComputerScience", "History", "Games", "Healthy", "Sexuality", "Sport" };
        public string content;
        public CheckListString(String content)
        {
            this.content = content;
        }

        public List<KeywordResult> CheckingContent()
        {
            List<KeywordResult> list = new List<KeywordResult>();
            string CurrentDirectory = Environment.CurrentDirectory;
            CurrentDirectory = Directory.GetParent(Directory.GetParent(CurrentDirectory).FullName).FullName;
            KMP getMatch = new KMP();
            foreach(string Name in FileName)
            {
                String txtName = "keyword_" + Name + ".txt";
                int match = 0;
                String filepath = System.IO.Path.Combine(CurrentDirectory, "Library", txtName);
                String[] lines = System.IO.File.ReadAllLines(filepath);
                foreach(String line in lines)
                {
                    match += getMatch.Compare(line, content);
                }
                list.Add(new KeywordResult(Name, match));
            }
            return list;
        }
    }
}
