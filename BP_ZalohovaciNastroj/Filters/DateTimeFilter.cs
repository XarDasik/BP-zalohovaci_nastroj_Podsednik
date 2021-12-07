using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj.Filters
{
    enum BeforeAfter
    {
        BEFORE, AFTER, THISDATE
    }
    enum Flag
    {
        CREATION,LASTWRITE,LASTACCESS
    }
    class DateTimeFilter : Filter
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

        public override bool Accepts(FileInfo file)
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
                return !accepts;
            else return accepts;

        }
        private bool CompareBasedOnCreation(FileInfo file)
        {
            switch (BeforeAfter)
            {
                case BeforeAfter.BEFORE: 
                    return file.CreationTime.Ticks <= DateTime.Ticks;
                case BeforeAfter.AFTER:
                    return file.CreationTime.Ticks >= DateTime.Ticks;
                case BeforeAfter.THISDATE:
                    return file.CreationTime.Date.Ticks == DateTime.Date.Ticks;
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
                case BeforeAfter.THISDATE:
                    return file.LastWriteTime.Date.Ticks == DateTime.Date.Ticks;
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
                case BeforeAfter.THISDATE:
                    return file.LastAccessTime.Date.Ticks == DateTime.Date.Ticks;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
