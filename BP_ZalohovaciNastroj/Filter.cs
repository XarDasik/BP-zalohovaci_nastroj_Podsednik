using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj
{
    abstract class Filter
    {
        public abstract bool Accepts(FileInfo file);
    }
}
