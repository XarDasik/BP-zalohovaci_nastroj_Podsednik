using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj.Filters
{
    public enum BeforeAfter
    {
        BEFORE, AFTER
    }
    public enum Flag
    {
        CREATION,LASTWRITE,LASTACCESS
    }
    [Serializable]
    public class DateTimeFilter : Filter
    {
        public BeforeAfter BeforeAfter { get; set; }
        public DateTime DateTime { get; set; }
        public Flag Flag { get; set; }

        public DateTimeFilter(bool OperatorNOT, string Name, BeforeAfter BeforeAfter, DateTime DateTime, Flag Flag) : base (OperatorNOT, Name)
        {
            this.BeforeAfter = BeforeAfter;
            this.DateTime = DateTime;
            this.Flag = Flag; 
        }

        public override bool Accepts(FileInfo file, Project project)
        {
            bool accepts;
            switch (Flag)
            {
                case Flag.CREATION: 
                    accepts = CompareBasedOnCreation(file);
                    break;
                case Flag.LASTWRITE:
                    accepts = CompareBasedOnLastWrite(file);
                    break;
                case Flag.LASTACCESS:
                    accepts = CompareBasedOnLastAccess(file);
                    break;
                default:
                    throw new NotImplementedException();
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
        private bool CompareBasedOnCreation(FileInfo file)
        {
            switch (BeforeAfter)
            {
                case BeforeAfter.BEFORE: 
                    return file.CreationTime.Ticks <= DateTime.Ticks;
                case BeforeAfter.AFTER:
                    return file.CreationTime.Ticks >= DateTime.Ticks;
                default:
                    throw new NotImplementedException();
            }
        }

        private bool CompareBasedOnLastWrite(FileInfo file)
        {
            switch (BeforeAfter)
            {
                case BeforeAfter.BEFORE:
                    return file.LastWriteTime.Ticks <= DateTime.Ticks;
                case BeforeAfter.AFTER:
                    return file.LastWriteTime.Ticks >= DateTime.Ticks;
                default:
                    throw new NotImplementedException();
            }
        }

        private bool CompareBasedOnLastAccess(FileInfo file)
        {
            switch (BeforeAfter)
            {
                case BeforeAfter.BEFORE:
                    return file.LastAccessTime.Ticks <= DateTime.Ticks;
                case BeforeAfter.AFTER:
                    return file.LastAccessTime.Ticks >= DateTime.Ticks;
                default:
                    throw new NotImplementedException();
            }
        }
        public override string ToString()
        {
            return string.Format("{0}{1}{2} ({3} {4})", Name.Length > 0 ? "<< " + Name + " >>" : "", OperatorNOT ? "(not)" : "", Flag == Flag.CREATION ? "Creation" : Flag == Flag.LASTWRITE ? "Last Write" : "Last Access", BeforeAfter == BeforeAfter.AFTER ? "After" : "Before", DateTime.ToString("dd.MM.yyyy HH:mm"));
        }
    }
}
