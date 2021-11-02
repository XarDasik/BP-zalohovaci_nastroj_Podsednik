using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj
{
    class SizeFilter : Filter
    {
        private readonly int B;
        private readonly Comparator comparator;
        public SizeFilter(int B, Comparator comparator)
        {
            this.B = B;
            this.comparator = comparator;
        }

        public override bool Accepts(FileInfo file)
        {
            switch (comparator)
            {
                case Comparator.LARGER:
                    return file.Length >= B;
                case Comparator.SMALLER:
                    return file.Length <= B;
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
