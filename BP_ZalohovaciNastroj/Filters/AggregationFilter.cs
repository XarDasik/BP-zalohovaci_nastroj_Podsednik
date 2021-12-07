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

        public override bool Accepts(FileInfo file)
        {
            switch (Operator){
            case AggregationOperand.AND:
                return AcceptsViaAnd(file);
            case AggregationOperand.OR:
                return AcceptsViaOr(file);
                default:
                    throw new NotImplementedException();
            }
        }

        
        private bool AcceptsViaAnd(FileInfo file)
        {
            foreach (Filter filter in Filters)
            {
                if (filter.Accepts(file) == false)
                    return false;
            }
            if (OperatorNOT)
                return false;
            else return true;
        }
        private bool AcceptsViaOr(FileInfo file)
        {
            foreach (Filter Filter in Filters)
            {
                if (Filter.Accepts(file) == true)
                    return true;
            }
            if (OperatorNOT)
                return true;
            else return false;
        }

    }
}
