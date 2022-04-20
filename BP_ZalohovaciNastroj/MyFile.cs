using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj
{
    public class MyFile
    {
        public FileInfo File { get; set; }
        public bool ToBackUp { get; set; }
        public List<string> ManagedByFilters { get; set; }

        public MyFile(FileInfo File)
        {
            this.File = File;
            ToBackUp = false;
            ManagedByFilters = new List<string>();
        }

    }
}
