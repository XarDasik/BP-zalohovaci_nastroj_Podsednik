using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj.Filters
{
    enum Attribute
    {
        ARCHIVE, READONLY, SYSTEM, ISDIRECTORY
    }
    class AttributeFilter : Filter
    {
        public Attribute[] Attributes { get; set; }

        public AttributeFilter(bool OperatorNOT, string Name, Attribute[] Attribute) : base(OperatorNOT, Name)
        {
            this.Attributes = Attribute;
        }

        public override bool Accepts(FileInfo file, Project project)
        {
            bool accepts = true;
            for (int i = 0; i < Attributes.Length; i++)
            {
                if (!(file.Attributes.ToString().Contains(Attributes[i].ToString())))
                {
                    accepts = false;
                }
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
    }
}
