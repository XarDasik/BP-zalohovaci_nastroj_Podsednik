using BP_ZalohovaciNastroj.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_ZalohovaciNastroj
{
    class SimulateBackup
    {
        public Project project { get; set; }

        public SimulateBackup(Project project)
        {
            this.project = project;
        }
        
        public FileInfo[] Simulate(TreeView treeViewFilters)
        {
            project.FilterManager.AggregationFilter = new AggregationFilter(false, "Default aggregation filter", AggregationOperand.AND, new List<Filter>());
            for (int i = 0; i < treeViewFilters.Nodes.Count; i++)
            {
                DetectNode(treeViewFilters.Nodes[i]);
            }
            return project.FilterManager.applyFilter().ToArray();
        }
        private void DetectNode(TreeNode treeNode)
        {
            if (treeNode.Nodes.Count > 0)
            {
                AddSubfilters(treeNode);
            }
            else
                project.FilterManager.AggregationFilter.Filters.Add((Filter)treeNode.Tag);
        }
        private void AddSubfilters(TreeNode treeNode)
        {
            AggregationFilter aggregationFilter = (AggregationFilter)treeNode.Tag;
            for (int i = 0; i < treeNode.Nodes.Count; i++)
            {
                if (treeNode.Nodes[i].Nodes.Count > 0)
                {

                    AddSubfilters(treeNode.Nodes[i]);
                }
                else
                    aggregationFilter.Filters.Add((Filter)treeNode.Nodes[i].Tag);
            }
            project.FilterManager.AggregationFilter.Filters.Add(aggregationFilter);
        }
    }
}
