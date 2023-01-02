using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj.Filters
{
    public enum Attribute
    {
        ARCHIVE, READONLY, SYSTEM, ISDIRECTORY
    }
    [Serializable]
    public class AttributeFilter : Filter
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
        public override string ToString()
        {
            string allAttributes = "";
            foreach (var attribute in Attributes)
            {
                string addString = "";
                switch (attribute)
                {
                    case Attribute.ARCHIVE:
                        addString = "Archive";
                        break;
                    case Attribute.READONLY:
                        addString = "Readonly";
                        break;
                    case Attribute.SYSTEM:
                        addString = "System";
                        break;
                    case Attribute.ISDIRECTORY:
                        addString = "IsDirectory";
                        break;
                    default:
                        break;
                }
                if (allAttributes.Length > 0)
                    allAttributes += " " + addString;
                else
                    allAttributes = addString;
            }
            return string.Format("{0}{1} ({2})", Name.Length > 0 ? "<< " + Name + " >>" : "", OperatorNOT ? "(not)" : "", allAttributes);
        }
    }
}
