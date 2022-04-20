using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj
{
    enum LargerSmaller
    {
        LARGER, SMALLER
    }
    enum Unit
    {
        B, kB, MB, GB
    }
    class SizeFilter : Filter
    {
        public double Size { get; set; }
        public LargerSmaller LargerSmaller { get; set; }
        public Unit Unit { get; set; } 


        public SizeFilter(bool OperatorNOT, string Name, double Size, LargerSmaller LargerSmaller, Unit Unit) : base(OperatorNOT, Name)
        {
            this.Size = Size;
            this.LargerSmaller = LargerSmaller;
            this.Unit = Unit;
        }       

        public override bool Accepts(FileInfo file, Project project)
        {
            double sizeOfFile = GetSizeOfFile(file);
            bool accepts;

            switch (LargerSmaller)
            {
                case LargerSmaller.LARGER:
                    accepts = sizeOfFile >= Size; break;
                case LargerSmaller.SMALLER:
                    accepts = sizeOfFile <= Size; break;
                default:
                    throw new InvalidOperationException();
            }
            if (OperatorNOT)
            {
                return !accepts;
            }
            else
            {
                return accepts;
            }
        }
        private double GetSizeOfFile(FileInfo file)
        {
            double sizeOfFile = file.Length;
            switch (Unit)
            {
                case Unit.kB:
                    sizeOfFile /= 1024.0; break;
                case Unit.MB:
                    sizeOfFile /= 1024 * 1024; break;
                case Unit.GB:
                     sizeOfFile /= 1024 * 1024 * 1024; break;
                default:
                    throw new InvalidOperationException("This Unit is not compatible: " + Unit);
            }
            return sizeOfFile;
           
        }
        public override string ToString()
        {
            return string.Format("{0}{1}{2} ({3} {4}{5})", Name.Length > 0 ? "<< " + Name + " >>" : "", OperatorNOT ? "(not)" : "", "AggregationFilter", LargerSmaller == LargerSmaller.LARGER ? ">" : "<", Size, Unit);
        }
    }
}
