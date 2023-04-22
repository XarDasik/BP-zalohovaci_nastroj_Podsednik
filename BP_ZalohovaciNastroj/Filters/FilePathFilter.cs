using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj
{
    [Serializable]
    public class FilePathFilter : Filter
    {
        public string RegularExpression { get; set; }
        public FilePathFilter(bool OperatorNOT, string Name, string RegularExpression) : base(OperatorNOT, Name)
        {
            this.RegularExpression = RegularExpression;
        }
        public override bool Accepts(FileInfo file, Project project)
        {
            bool accepts;
            Regex rx = new Regex(RegularExpression);
            MatchCollection matches = rx.Matches(file.FullName);
            if (matches.Count > 0)
                accepts = true;
            else
                accepts = false;            
            if (OperatorNOT)
            {
                return !accepts;
            }
            else
            {
                return accepts; 
            }                
        }
        public override string ToString()
        {
            return string.Format("{0}{1} ({2}{{regex}})", Name.Length > 0 ? "<< " + Name + " >>" : "", OperatorNOT ? "(not)" : "", RegularExpression);
        }
    }
}
