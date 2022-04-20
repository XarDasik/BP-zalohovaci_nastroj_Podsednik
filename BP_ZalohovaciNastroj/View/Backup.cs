using BP_ZalohovaciNastroj.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_ZalohovaciNastroj
{
    enum TypeOfFilter
    {
        AGGREGATION, FILEPATH, ATTRIBUTE, DATETIME, SIZE
    }

    public partial class Backup : Form
    {
        public static List<FileInfo> files = new List<FileInfo>();
        Project project = new Project();

        public Backup(bool isForProject)
        {                   
            InitializeComponent();
            if (isForProject)
            {
                B_SimulateBackup.Visible = false;
                btnSave.Visible = false;
            }
                
        }

        private void B_path_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                project.SourcePath = folderBrowserDialog1.SelectedPath;
                TB_RootPath.Text = folderBrowserDialog1.SelectedPath;                
            }
        }

        private void B_AddChild_Click(object sender, EventArgs e)
        {
            Filter newFilter;
            if(TV_FiltersView.SelectedNode == null)
            {
                MessageBox.Show("Choose aggregation filter");
                return;
            }

            if (!(TV_FiltersView.SelectedNode.Tag is AggregationFilter))
            {
                MessageBox.Show("You can add a filter only for Aggregation filter");
                return;
            }
                        
            switch (TC_Filters.SelectedIndex)
            {
                case 0:
                    newFilter = GetAggregationFilter(); break;
                case 1:
                    newFilter = GetFilePathFilter(); break;
                case 2:
                    newFilter = GetAttributeFilter(); break;
                case 3:
                    newFilter = GetDateTimeFilter(); break;
                case 4:
                    newFilter = GetSizeFilter(); break;
                default: throw new InvalidProgramException("Nobody excepted one more tab");
            }
            TreeNode newNode = BuildNodeForFilter(newFilter, GetNegateForFilter(), GetNameForFilter());
            TreeNode selectedNode = TV_FiltersView.SelectedNode;
            AggregationFilter filter = (AggregationFilter)selectedNode.Tag;
            filter.Filters.Add(newFilter);
            selectedNode.Nodes.Add(newNode);
            selectedNode.Expand();
        }
        private TreeNode BuildNodeForFilter(Filter filter, string negateText, string nameOfTheFilter)
        {
            TreeNode node = new TreeNode()
            {
                Text = filter.ToString(),
                Tag = filter
            };
            return node;
        }
        private string GetNameForFilter()
        {
            string nameOfTheFilter = TB_NameOfFilter.TextLength > 0 ? "<< " + TB_NameOfFilter.Text + " >>" : "";
            return nameOfTheFilter;
        }
        private string GetNegateForFilter()
        {
            string negateText = "";
            if (ChB_Negate.Checked)
                negateText = "(not) ";
            return negateText;
        }

        private void B_AddNext_Click(object sender, EventArgs e)
        {          
            Filter newFilter;            

            switch (TC_Filters.SelectedIndex)
            {
                case 0:
                    newFilter = GetAggregationFilter(); break;
                case 1:
                    newFilter = GetFilePathFilter(); break;
                case 2:
                    newFilter = GetAttributeFilter(); break;
                case 3:
                    newFilter = GetDateTimeFilter(); break;
                case 4:
                    newFilter = GetSizeFilter(); break;
                default: throw new InvalidProgramException("Nobody excepted one more tab");
            }
            if (newFilter == null)
                return;
            TreeNode newNode = BuildNodeForFilter(newFilter, GetNegateForFilter(), GetNameForFilter());
            this.TV_FiltersView.Nodes.Add(newNode);
            project.MainFilter.Filters.Add(newFilter);
        }
        private AggregationFilter GetAggregationFilter()
        {
            AggregationOperand Ao;
            if (RB_And.Checked)
            {
                Ao = AggregationOperand.AND;
            }
            else if (RB_OR.Checked)
            {
                Ao = AggregationOperand.OR;
            }
            else
            {
                MessageBox.Show("Please choose aggregation operand");
                return null;
            }
            return new AggregationFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, Ao, new List<Filter>());

        }
        private FilePathFilter GetFilePathFilter()
        {
            if(TB_PathRegex.Text.Length == 0)
            {
                MessageBox.Show("Please fill Regex first");
                return null;
            }
            return new FilePathFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, TB_PathRegex.Text);
        }
        private AttributeFilter GetAttributeFilter()
        {
            int count = 0;
            foreach (Control c in TC_Filters.TabPages[2].Controls)
            {
                CheckBox cb = c as CheckBox;
                if (cb != null && cb.Checked) count++;
            }
            if(count == 0)
            {
                MessageBox.Show("Please choose file attribute first");
                return null;
            }
            int lastIndex = 0;
            Filters.Attribute[] attributes = new Filters.Attribute[count];
            
            if (CHB_Archive.Checked)
                attributes[lastIndex++] = Filters.Attribute.ARCHIVE;
            if(CHB_ReadOnly.Checked)
                attributes[lastIndex++] = Filters.Attribute.READONLY;
            if(CHB_System.Checked)
                attributes[lastIndex++] = Filters.Attribute.SYSTEM;
            if(CHB_IsDirectory.Checked)
                attributes[lastIndex++] = Filters.Attribute.ISDIRECTORY;          
            
            return new AttributeFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, attributes);
        }

        private DateTimeFilter GetDateTimeFilter()
        {
            BeforeAfter beforeAfter;
            if(CB_DateBeforeAfter.SelectedIndex == 0)
                beforeAfter = BeforeAfter.BEFORE;
            else if(CB_DateBeforeAfter.SelectedIndex == 1)
                beforeAfter = BeforeAfter.AFTER;
            else
            {
                MessageBox.Show("Please choose comparing first");
                return null;
            }

            Flag flag;
            if (RB_CreationDateTime.Checked)
                flag = Flag.CREATION;
            else if(RB_LastWriteDateTime.Checked)
                flag = Flag.LASTWRITE;
            else if(RB_LastAccessDateTime.Checked)
                flag = Flag.LASTACCESS;
            else
            {
                MessageBox.Show("Please choose file flag first");
                return null;
            }
            return new DateTimeFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, beforeAfter, DTP_Date.Value, flag);
            
        }
        private SizeFilter GetSizeFilter()
        {
            LargerSmaller largerSmaller;
            if (RB_Minimal.Checked)
                largerSmaller = LargerSmaller.LARGER;
            else if(RB_Maximal.Checked)
                largerSmaller = LargerSmaller.SMALLER;
            else
            {
                MessageBox.Show("Please choose comparing first");
                return null;
            }
            Unit unit;
            if (RB_Size_B.Checked)
                unit = Unit.B;
            else if (RB_Size_kB.Checked)
                unit = Unit.kB;
            else if (RB_Size_MB.Checked)
                unit = Unit.MB;
            else if(RB_Size_GB.Checked)
                unit = Unit.GB;
            else
            {
                MessageBox.Show("Please choose unit of size first");
                return null;
            }
            return new SizeFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, Decimal.ToDouble(NUD_Number.Value), largerSmaller, unit);
        }

        private TypeOfFilter GetTypeOfFilter(Filter filter)
        {
            if (filter.GetType() == typeof(AggregationFilter))
                return TypeOfFilter.AGGREGATION;
            else if (filter.GetType() == typeof(FilePathFilter))
                return TypeOfFilter.FILEPATH;
            else if (filter.GetType() == typeof(AttributeFilter))
                return TypeOfFilter.ATTRIBUTE;
            else if (filter.GetType() == typeof(DateTimeFilter))
                return TypeOfFilter.DATETIME;
            else if (filter.GetType() == typeof(SizeFilter))
                return TypeOfFilter.SIZE;
            else
                throw new InvalidDataException();
        }

        private void B_Remove_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.TV_FiltersView.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("Pick a filter you want to delete first");
                return;
            }
            Filter selectedFilter = (Filter)selectedNode.Tag;

            AggregationFilter aggFilter = selectedNode.Parent != null ?
              (AggregationFilter)selectedNode.Parent.Tag : null;

            if (aggFilter == null)
            {
                project.MainFilter.Filters.Remove(selectedFilter);
                this.TV_FiltersView.Nodes.Remove(selectedNode);
            }
            else
            {
                aggFilter.Filters.Remove(selectedFilter);
                selectedNode.Parent.Nodes.Remove(selectedNode);
            }
        }

        private void TV_FiltersView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (GetTypeOfFilter((Filter)TV_FiltersView.SelectedNode.Tag))
            {
                case TypeOfFilter.AGGREGATION: FillDataToTabControlForAggregation(); break;
                case TypeOfFilter.FILEPATH: FillDataToTabControlForFilePath(); break;
                case TypeOfFilter.ATTRIBUTE: FillDataToTabControlForAttribute(); break;
                case TypeOfFilter.DATETIME: FillDataToTabControlForDateTime(); break;
                case TypeOfFilter.SIZE: FillDataToTabControlForSize(); break;
                default:
                    break;
            }
        }

        private void FillDataToTabControlForAggregation()
        {
            AggregationFilter aggregationFilter = (AggregationFilter)TV_FiltersView.SelectedNode.Tag;
            TC_Filters.SelectedIndex = 0;
            SetNameAndNegate(aggregationFilter);

            switch (aggregationFilter.Operator)
            {
                case AggregationOperand.AND: RB_And.Checked = true;
                    break;
                case AggregationOperand.OR: RB_OR.Checked = true;
                    break;
                default:
                    break;
            }
        }
        private void FillDataToTabControlForFilePath()
        {
            FilePathFilter filePathFilter = (FilePathFilter)TV_FiltersView.SelectedNode.Tag;
            TC_Filters.SelectedIndex = 1;
            SetNameAndNegate(filePathFilter);

            TB_PathRegex.Text = filePathFilter.RegularExpression;
        }
        private void FillDataToTabControlForAttribute()
        {
            foreach (Control c in TC_Filters.TabPages[2].Controls)
            {
                CheckBox cb = c as CheckBox;
                if(cb !=null)cb.Checked = false;
            }
            AttributeFilter attributeFilter = (AttributeFilter)TV_FiltersView.SelectedNode.Tag;
            TC_Filters.SelectedIndex = 2;
            SetNameAndNegate(attributeFilter);
            
            for (int i = 0; i < attributeFilter.Attributes.Length; i++)
            {
                if(attributeFilter.Attributes[i].Equals(Filters.Attribute.ARCHIVE))
                    CHB_Archive.Checked = true;
                else if(attributeFilter.Attributes[i].Equals(Filters.Attribute.READONLY))
                    CHB_ReadOnly.Checked = true;
                else if(attributeFilter.Attributes[i].Equals(Filters.Attribute.SYSTEM))
                    CHB_System.Checked = true;
                else if(attributeFilter.Attributes[i].Equals(Filters.Attribute.ISDIRECTORY))
                    CHB_IsDirectory.Checked = true;
            }
            
        }
        private void FillDataToTabControlForDateTime()
        {
            DateTimeFilter dateTimeFilter = (DateTimeFilter)TV_FiltersView.SelectedNode.Tag;
            TC_Filters.SelectedIndex = 3;
            SetNameAndNegate(dateTimeFilter);

            switch (dateTimeFilter.BeforeAfter)
            {
                case BeforeAfter.BEFORE:
                    CB_DateBeforeAfter.SelectedIndex = 0;
                    break;
                case BeforeAfter.AFTER:
                    CB_DateBeforeAfter.SelectedIndex = 1;
                    break;
                default:
                    break;
            }
            switch (dateTimeFilter.Flag)
            {
                case Flag.CREATION: RB_CreationDateTime.Checked = true;
                    break;
                case Flag.LASTWRITE: RB_LastWriteDateTime.Checked = true;
                    break;
                case Flag.LASTACCESS: RB_LastAccessDateTime.Checked = true;
                    break;
                default:
                    break;
            }
            DTP_Date.Value = dateTimeFilter.DateTime;
        }
        private void FillDataToTabControlForSize()
        {
            SizeFilter sizeFilter = (SizeFilter)TV_FiltersView.SelectedNode.Tag;
            TC_Filters.SelectedIndex = 4;
            SetNameAndNegate(sizeFilter);

            switch (sizeFilter.LargerSmaller)
            {
                case LargerSmaller.LARGER: RB_Minimal.Checked = true;
                    break;
                case LargerSmaller.SMALLER: RB_Maximal.Checked = true;
                    break;
                default:
                    break;
            }
            switch (sizeFilter.Unit)
            {
                case Unit.B: 
                    RB_Size_B.Checked = true;
                    break;
                case Unit.kB:
                    RB_Size_kB.Checked = true;
                    break;
                case Unit.MB:
                    RB_Size_MB.Checked = true;
                    break;
                case Unit.GB:
                    RB_Size_GB.Checked = true;
                    break;
                default:
                    break;
            }
            NUD_Number.Value = Convert.ToInt32(sizeFilter.Size);
        }
        private void SetNameAndNegate(Filter filter)
        {
            if (filter.OperatorNOT)
                ChB_Negate.Checked = true;
            else ChB_Negate.Checked = false;

            TB_NameOfFilter.Text = filter.Name;
        }

        private void B_EditFilter_Click(object sender, EventArgs e)
        {
            if (TV_FiltersView.SelectedNode == null)
            {
                MessageBox.Show("Select node you want to edit first");
                return;
            }
            if(TV_FiltersView.SelectedNode.Nodes.Count > 0 && TC_Filters.SelectedIndex != 0)
            {
                MessageBox.Show("Delete subfilters first");
                return;
            }
            string negateText = "";
            if(ChB_Negate.Checked)
               negateText = "(not) ";
            string nameOfTheFilter = TB_NameOfFilter.TextLength > 0 ? "<< " + TB_NameOfFilter.Text + " >>" : "";
            EditSelectedNode(negateText, nameOfTheFilter);            
        }
        // editace

        private void EditSelectedNode(string negateText, string nameOfTheFilter)
        {           
            Filter newFilter;            
            switch (TC_Filters.SelectedIndex)
            {
                case 0:
                    newFilter = GetAggregationFilter(); break;
                case 1:
                    newFilter = GetFilePathFilter(); break;
                case 2:
                    newFilter = GetAttributeFilter(); break;
                case 3:
                    newFilter = GetDateTimeFilter(); break;
                case 4:
                    newFilter = GetSizeFilter(); break;
                default: throw new InvalidProgramException("Nobody excepted one more tab");
            }
            if(TV_FiltersView.SelectedNode.Tag is AggregationFilter && newFilter is AggregationFilter)
            {
                AggregationFilter oldFilter = (AggregationFilter)TV_FiltersView.SelectedNode.Tag;
                List<Filter> oldFilters = oldFilter.Filters;
                AggregationFilter filter = (AggregationFilter)newFilter;
                filter.Filters = oldFilters;

                if (TV_FiltersView.SelectedNode.Parent == null)
                {
                    project.MainFilter.Filters[TV_FiltersView.SelectedNode.Index] = filter;
                }
                else
                {
                    AggregationFilter parentNode = (AggregationFilter)TV_FiltersView.SelectedNode.Parent.Tag;
                    parentNode.Filters[TV_FiltersView.SelectedNode.Index] = filter;
                }
            }
            else
            {
                if (TV_FiltersView.SelectedNode.Parent == null)
                {
                    project.MainFilter.Filters[TV_FiltersView.SelectedNode.Index] = newFilter;                    
                }
                else
                {
                    AggregationFilter parentNode = (AggregationFilter)TV_FiltersView.SelectedNode.Parent.Tag;
                    parentNode.Filters[TV_FiltersView.SelectedNode.Index] = newFilter;
                }
            }          

            TreeNode newNode = BuildNodeForFilter(newFilter, negateText, nameOfTheFilter);
            TV_FiltersView.SelectedNode.Text = newNode.Text;
            TV_FiltersView.SelectedNode.Tag = newNode.Tag;
        }

        private void B_SimulateBackup_Click(object sender, EventArgs e)
        {
            if (TB_RootPath.Text.Length == 0 && TB_DestinationPath.Text.Length == 0)
            {
                MessageBox.Show("Select a valid path");
                return;
            }
            var dir = new DirectoryInfo(TB_RootPath.Text);

            if (!dir.Exists)
            {
                MessageBox.Show("Root path doesn't exist. Please select valid path.");
                return;
            }
            FileInfo[] temp = dir.GetFiles("*.*", SearchOption.AllDirectories);
            project.FilterManager.Files = project.FilterManager.ConvertToMyFile(temp);
            project.FilterManager.AggregationFilter = project.MainFilter;
            project.FilterManager.applyFilter(project);
            TreeView FiltersClone = CopyTreeView(TV_FiltersView);

            FilterResult tempForm = new FilterResult(project.FilterManager.Files.ToArray(), FiltersClone, TB_RootPath.Text, TB_DestinationPath.Text, Convert.ToInt32(NUD_NumberOfBackups.Value));
            tempForm.Show();          
               
        }
        private TreeView CopyTreeView(TreeView Original)
        {
            TreeView ret = new TreeView();
            TreeNode newTn;
            foreach (TreeNode tn in Original.Nodes)
            {
                newTn = new TreeNode(tn.Text, tn.ImageIndex, tn.SelectedImageIndex);
                newTn.Tag = tn.Tag;
                CopyChildren(newTn, tn);
                ret.Nodes.Add(newTn);
            }
            return ret;
        }
        
        public void CopyChildren(TreeNode parent, TreeNode original)
        {
            TreeNode newTn;
            foreach (TreeNode tn in original.Nodes)
            {
                newTn = new TreeNode(tn.Text, tn.ImageIndex, tn.SelectedImageIndex);
                newTn.Tag = tn.Tag;
                parent.Nodes.Add(newTn);
                CopyChildren(newTn, tn);
            }
        }

        private void B_DestionationPathLoader_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TB_DestinationPath.Text = folderBrowserDialog1.SelectedPath;                
            }
        }
    }
}
