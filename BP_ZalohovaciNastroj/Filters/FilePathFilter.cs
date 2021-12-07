using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj
{
    class FilePathFilter : Filter
    {
        public string RegularExpression { get; set; }
        public FilePathFilter(bool OperatorNOT, string Name, string RegularExpression) : base(OperatorNOT, Name)
        {
            this.RegularExpression = RegularExpression;
        }
        public override bool Accepts(FileInfo file)
        {
            bool accepts;
            Regex rx = new Regex(RegularExpression);
            MatchCollection matches = rx.Matches(file.FullName);
            if (matches.Count > 0)
                accepts = true;
            else
                accepts = false;

            if (OperatorNOT)
                return !accepts;
            else
                return accepts;

        }
    }
}
