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
        private AggregationOperand Operator;
        private Filter[] Filters;

        public AggregationFilter(AggregationOperand Operator, Filter[] filters)
        {
            this.Operator = Operator;
            this.Filters = filters;
        }

        public override bool Accepts(FileInfo file)
        {
            switch (Operator){
            case AggregationOperand.AND:
                return acceptsViaAnd(file);
            case AggregationOperand.OR:
                return acceptsViaOr(file);
            case AggregationOperand.NOT:
                return acceptsViaNot(file);

                default:
                    throw new NotImplementedException();
            }
        }

        
        private bool acceptsViaAnd(FileInfo file)
        {
            foreach (Filter filter in Filters)
            {
                if (filter.Accepts(file) == false)
                    return false;
            }
            return true;
        }
        private bool acceptsViaOr(FileInfo file)
        {
            foreach (Filter Filter in Filters)
            {
                if (Filter.Accepts(file) == true)
                    return true;
            }
            return false;
        }

        private bool acceptsViaNot(FileInfo file)
        {
            foreach (Filter Filter in Filters)
            {
                if (Filter.Accepts(file) == true)
                    return false;
            }
            return true;
        }
    }
}
