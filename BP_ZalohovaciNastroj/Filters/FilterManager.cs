using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj
{
    [Serializable]
    public class FilterManager
    {
        public MyFile[] Files { get; set; }
        public AggregationFilter AggregationFilter { get; set; }
        public void applyFilter(Project project)
        {
            foreach (MyFile file in Files)
            {
                if (AggregationFilter.Accepts(file.File, project))
                {
                    file.ToBackUp = true;
                }
            }
        }
        public MyFile[] ConvertToMyFile(FileInfo[] files)
        {
            MyFile[] ret = new MyFile[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                ret[i] = new MyFile(files[i]);
            }
            return ret;
        }
    }
}
