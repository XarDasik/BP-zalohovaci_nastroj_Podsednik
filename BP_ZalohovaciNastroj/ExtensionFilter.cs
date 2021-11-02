using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj
{
    class ExtensionFilter : Filter
    {
        private readonly string fileExtension;
        public ExtensionFilter(string fileExtension)
        {
            this.fileExtension = fileExtension;
        }
        public override bool Accepts(FileInfo file)
        {
            return file.Extension.Equals(fileExtension.ToLower());
        }
    }
}
