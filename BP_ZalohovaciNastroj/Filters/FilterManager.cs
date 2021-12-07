using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj
{
    class FilterManager
    {
        public FileInfo[] Files { get; set; }
        public AggregationFilter AggregationFilter { get; set; }
        public List<FileInfo> applyFilter()
        {
            if (Files.Length > 0)
            {
                FileInfo[] temporaryArray = new FileInfo[Files.Length];
                int lastIndex = 0;

                foreach (FileInfo file in Files)
                {
                    if (AggregationFilter.Accepts(file))
                    {
                        temporaryArray[lastIndex] = file;
                        lastIndex++;
                    }
                }
                FileInfo[] ret = new FileInfo[lastIndex];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = temporaryArray[i];
                }

                return ret.ToList<FileInfo>();
            }
            else
                throw new InvalidProgramException("There is no files to filter.");
        }
    }
}
