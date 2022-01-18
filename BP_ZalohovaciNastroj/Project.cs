using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_ZalohovaciNastroj
{
    class Project
    {
        public string SourcePath { get; set; }
        public string DestinationPath { get; set; }
        public FilterManager FilterManager { get; set; }
        public int NumberOfBackups { get; set; }
        public AggregationFilter MainFilter { get; set; }
        public Project()
        {
            this.FilterManager = new FilterManager();
            this.MainFilter = new AggregationFilter(false, "Default AggregationFilter", AggregationOperand.AND, new List<Filter>());
        }
        
        public Project(Project project)
        {
            this.SourcePath = project.SourcePath;
            this.DestinationPath = project.DestinationPath;
            this.FilterManager = project.FilterManager;
            this.NumberOfBackups = project.NumberOfBackups;
        }

    }
}
