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
        ARCHIVE, READONLY, SYSTEM, ISFILE, ISDIRECTORY
    }
    class AttributeFilter : Filter
    {
        public Attribute Attribute { get; set; }

        public AttributeFilter(bool OperatorNOT, string Name, Attribute Attribute) : base(OperatorNOT, Name)
        {
            this.Attribute = Attribute;
        }

        public override bool Accepts(FileInfo file)
        {            
            throw new NotImplementedException();
            bool accepts;
            switch (Attribute)
            {
                case Attribute.ARCHIVE: accepts = file.Attributes.ToString().Contains("Archive"); //Dodělat
                    break;
                case Attribute.READONLY:
                    accepts = file.Attributes.ToString().Contains("ReadOnly"); //dodělat
                    break;
                case Attribute.SYSTEM:
                    break;
                case Attribute.ISFILE: 
                    break;
                case Attribute.ISDIRECTORY:
                    break;
                default:
                    break;
            }
        }
    }
}
