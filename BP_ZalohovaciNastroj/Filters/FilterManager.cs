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
        //public FileInfo[] Files { get; set; }
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
                /*if (Files.Length > 0)
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
                    throw new InvalidProgramException("There are no files to filter.");*/
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
