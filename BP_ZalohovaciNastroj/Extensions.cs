using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj
{
    public static class Extensions
    {
        public static bool IsEmpty(this DirectoryInfo di)
        {
            return !(di.GetDirectories().Any() || di.GetFiles().Any());
        }
    }
}
