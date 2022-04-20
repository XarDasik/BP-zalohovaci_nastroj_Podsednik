using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj
{
    class AggregationFilter : Filter
    {
        public AggregationOperand Operator { get; set; }
        public List<Filter> Filters { get; set; }


        public AggregationFilter(bool OperatorNOT,string Name, AggregationOperand Operator, List<Filter> filters) : base(OperatorNOT, Name)
        {
            this.Operator = Operator;
            this.Filters = filters;
        }

        public override bool Accepts(FileInfo file, Project project)
        {
            switch (Operator){
            case AggregationOperand.AND:
                return AcceptsViaAnd(file, project);
            case AggregationOperand.OR:
                return AcceptsViaOr(file, project);
                default:
                    throw new NotImplementedException();
            }
        }

        
        private bool AcceptsViaAnd(FileInfo file, Project project)
        {
            foreach (Filter filter in Filters)
            {
                if (filter.Accepts(file, project) == false)
                    return false;
            }
            if (OperatorNOT)
                return false;
            else return true;
        }
        private bool AcceptsViaOr(FileInfo file, Project project)
        {
            foreach (Filter Filter in Filters)
            {
                if (Filter.Accepts(file, project) == true)
                    return true;
            }
            if (OperatorNOT)
                return true;
            else return false;
        }
        public override string ToString()
        {
            return string.Format("{0}{1}{2} ({3})",  Name.Length > 0 ? "<< " + Name + " >>" : "", OperatorNOT ? "(not)" : "", "AggregationFilter", Operator.ToString());
        }
    }
}
