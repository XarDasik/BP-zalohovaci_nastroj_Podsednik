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
                case Attribute.ARCHIVE: accepts = file.Attributes.ToString().Contains(FileAttributes.Archive.ToString());
                    break;
                case Attribute.READONLY:
                    accepts = file.Attributes.ToString().Contains(FileAttributes.ReadOnly.ToString());
                    break;
                case Attribute.SYSTEM:
                    accepts = file.Attributes.ToString().Contains(FileAttributes.System.ToString());
                    break;
                case Attribute.ISFILE:
                    accepts = true;
                    //accepts = file.Attributes.ToString().Contains(FileAttributes..ToString());
                    break;
                case Attribute.ISDIRECTORY:
                    accepts = file.Attributes.ToString().Contains(FileAttributes.Directory.ToString());
                    break;
                default:
                    break;
            }
            return accepts;
        }
    }
}
