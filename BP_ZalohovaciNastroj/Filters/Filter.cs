﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj
{
    [Serializable]
    public abstract class Filter
    {
        public bool OperatorNOT { get; set; }
        public string Name { get; set; }
        public abstract bool Accepts(FileInfo file, Project project);

        public Filter(bool OperatorNOT, string Name)
        {
            this.OperatorNOT = OperatorNOT;
            this.Name = Name;
        }
    }
}
