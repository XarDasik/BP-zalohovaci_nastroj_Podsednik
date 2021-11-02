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
        public List<FileInfo> applyFilter(FileInfo[] files, AggregationFilter aggregationFilter)
        {
            if (files.Length > 0)
            {
                FileInfo[] temporaryArray = new FileInfo[files.Length];
                int lastIndex = 0;

                foreach (FileInfo file in files)
                {
                    if (aggregationFilter.Accepts(file))
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
                throw new InvalidProgramException();
        }
    }
}
