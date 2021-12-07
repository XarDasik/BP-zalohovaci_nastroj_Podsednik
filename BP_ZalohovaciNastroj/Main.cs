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

    public partial class Main : Form
    {
        public static List<FileInfo> files = new List<FileInfo>();
        Project project1 = new Project();
        Font font;
        public Main()
        {
            InitializeComponent();

            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.Anonymous_Pro.Length;
            byte[] fontdata = Properties.Resources.Anonymous_Pro;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            font = new Font(pfc.Families[0], 12);
            //ChangeFormFonts();          

            
        }

        public void ChangeFormFonts()
        {
            this.Font = font;
            foreach (Control control in this.Controls)
            {
                ChangeControlsFonts(control);
            }
        }

        private void ChangeControlsFonts(Control container)
        {
            container.Font = font;

            foreach (Control ctrl in container.Controls)
                ChangeControlsFonts(ctrl);
        }

        private void B_path_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                project1.SourcePath = folderBrowserDialog1.SelectedPath;
                TB_RootPath.Text = folderBrowserDialog1.SelectedPath;
                var dir = new DirectoryInfo(TB_RootPath.Text);
                project1.FilterManager.Files = dir.GetFiles("*.*", SearchOption.AllDirectories);
            }
            //files = new FilterManager().applyFilter(files.ToArray(), new AggregationFilter(false, "OR", AggregationOperand.OR, new Filter[] { new FilePathFilter(false, "Snippets", "\\\\TestD\\\\"), new AggregationFilter(false, "", AggregationOperand.AND, new Filter[] { new FilePathFilter(false, "","\\\\Zkouska\\\\") })}));
        }

        private void B_AddChild_Click(object sender, EventArgs e)
        {
            if (!(CanAddChildToNode((Filter)TV_FiltersView.SelectedNode.Tag)))
            {
                MessageBox.Show("You can add a filter only for Aggregation filter");
                return;
            }

            string negateText = ChB_Negate.Checked ? "-" : "+";
            string nameOfTheFilter = TB_NameOfFilter.TextLength > 0 ? "<< " + TB_NameOfFilter.Text + " >>" : "";
            switch (TC_Filters.SelectedIndex)
            {
                case 0:
                    AddAggregationFilterAsChild(negateText, nameOfTheFilter); 
                    break;
                case 1:
                    AddFilePathFilterAsChild(negateText, nameOfTheFilter); break;
                case 2:
                    AddAttributeFilterAsChild(negateText, nameOfTheFilter); break;
                case 3:
                    AddDateTimeFilterAsChild(negateText, nameOfTheFilter); break;
                case 4:
                    AddSizeFilterAsChild(negateText, nameOfTheFilter); break;
                default:
                    break;
            }
        }

        private void B_AddNext_Click(object sender, EventArgs e)
        {
            string negateText = ChB_Negate.Checked ? "-" : "+";
            string nameOfTheFilter = TB_NameOfFilter.TextLength > 0 ? "<< " + TB_NameOfFilter.Text + " >>" : "";
            switch (TC_Filters.SelectedIndex)
            {
                case 0:
                    AddAggregationFilterAsNode(negateText, nameOfTheFilter);
                    break;
                case 1: AddFilePathFilterAsNode(negateText, nameOfTheFilter); break;
                case 2: AddAttributeFilterAsNode(negateText, nameOfTheFilter); break;
                case 3: AddDateTimeFilterAsNode(negateText, nameOfTheFilter); break;
                case 4: AddSizeFilterAsNode(negateText, nameOfTheFilter); break;
                default:
                    break;
            }
        }

        private void AddAggregationFilterAsNode(string negateText, string nameOfTheFilter)
        {
            string node;
            AggregationOperand Ao;
            if (RB_And.Checked)
            {
                node = "(and)";
                Ao = AggregationOperand.AND;
            }
            else if(RB_OR.Checked)
            {
                node = "(or)";
                Ao = AggregationOperand.OR;
            }
            else
            {
                MessageBox.Show("Please choose aggregation operand");
                return;
            }
            

            TV_FiltersView.Nodes.Add(negateText + nameOfTheFilter + node);
            TV_FiltersView.Nodes[TV_FiltersView.Nodes.Count - 1].Tag = new AggregationFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, Ao, new List<Filter>());
            
        }
        private void AddFilePathFilterAsNode(string negateText, string nameOfTheFilter)
        {
            if (TB_PathRegex.Text.Length == 0)
            {
                MessageBox.Show("Please fill Regex first");
                return;
            }
            TV_FiltersView.Nodes.Add(negateText + nameOfTheFilter + " Path Filter");
            TV_FiltersView.Nodes[TV_FiltersView.Nodes.Count - 1].Tag = new FilePathFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, TB_PathRegex.Text);
        }
        private void AddAttributeFilterAsNode(string negateText, string nameOfTheFilter)
        {
            Filters.Attribute attribute;
            if (RB_Archive.Checked)
                attribute = Filters.Attribute.ARCHIVE;
            else if (RB_ReadOnly.Checked)
                attribute = Filters.Attribute.READONLY;
            else if (RB_System.Checked)
                attribute = Filters.Attribute.SYSTEM;
            else if (RB_IsFile.Checked)
                attribute = Filters.Attribute.ISFILE;
            else if (RB_IsDirectory.Checked)
                attribute = Filters.Attribute.ISDIRECTORY;
            else
            {
                MessageBox.Show("Please choose file attribute first");
                return;
            }
            TV_FiltersView.Nodes.Add(negateText + nameOfTheFilter + " Atributte filter");
            TV_FiltersView.Nodes[TV_FiltersView.Nodes.Count - 1].Tag = new AttributeFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, attribute);
        }

        private void AddDateTimeFilterAsNode(string negateText, string nameOfTheFilter)
        {
            BeforeAfter beforeAfter;
            if (CB_DateBeforeAfter.SelectedIndex == 0)
                beforeAfter = BeforeAfter.THISDATE;
            else if (CB_DateBeforeAfter.SelectedIndex == 1)
                beforeAfter = BeforeAfter.BEFORE;
            else if (CB_DateBeforeAfter.SelectedIndex == 2)
                beforeAfter = BeforeAfter.AFTER;
            else
            {
                MessageBox.Show("Please choose comparing first");
                return;
            }

            Flag flag;
            if (RB_CreationDateTime.Checked)
                flag = Flag.CREATION;
            else if (RB_LastWriteDateTime.Checked)
                flag = Flag.LASTWRITE;
            else if (RB_LastAccessDateTime.Checked)
                flag = Flag.LASTACCESS;
            else
            {
                MessageBox.Show("Please choose file flag first");
                return;
            }
            TV_FiltersView.Nodes.Add(negateText + nameOfTheFilter + " Date Time");
            TV_FiltersView.Nodes[TV_FiltersView.Nodes.Count - 1].Tag = new DateTimeFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, beforeAfter, DTP_Date.Value, flag);
        }
        private void AddSizeFilterAsNode(string negateText, string nameOfTheFilter)
        {
            LargerSmaller largerSmaller;
            if (RB_Minimal.Checked)
                largerSmaller = LargerSmaller.LARGER;
            else if (RB_Maximal.Checked)
                largerSmaller = LargerSmaller.SMALLER;
            else
            {
                MessageBox.Show("Please choose comparing first");
                return;
            }
            Unit unit;
            if (RB_Size_B.Checked)
                unit = Unit.B;
            else if (RB_Size_kB.Checked)
                unit = Unit.kB;
            else if (RB_Size_MB.Checked)
                unit = Unit.MB;
            else if (RB_Size_GB.Checked)
                unit = Unit.GB;
            else
            {
                MessageBox.Show("Please choose unit of size first");
                return;
            }
            TV_FiltersView.Nodes.Add(negateText + nameOfTheFilter + " Size filter");
            TV_FiltersView.Nodes[TV_FiltersView.Nodes.Count - 1].Tag = new SizeFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, Decimal.ToDouble(NUD_Number.Value), largerSmaller, unit);

        }
        private void AddAggregationFilterAsChild(string negateText, string nameOfTheFilter)
        {
            string node;
            AggregationOperand Ao;
            if (RB_And.Checked)
            {
                node = "(and)";
                Ao = AggregationOperand.AND;
            }
            else if (RB_OR.Checked)
            {
                node = "(or)";
                Ao = AggregationOperand.OR;
            }
            else
            {
                MessageBox.Show("Please choose aggregation operand");
                return;
            }
            TV_FiltersView.SelectedNode.Nodes.Add(negateText + nameOfTheFilter + node);
            TV_FiltersView.SelectedNode.Nodes[TV_FiltersView.SelectedNode.Nodes.Count - 1].Tag = new AggregationFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, Ao, new List<Filter>());

        }
        private void AddFilePathFilterAsChild(string negateText, string nameOfTheFilter)
        {
            if(TB_PathRegex.Text.Length == 0)
            {
                MessageBox.Show("Please fill Regex first");
                return;
            }
            TV_FiltersView.SelectedNode.Nodes.Add(negateText + nameOfTheFilter + " Path Filter");
            TV_FiltersView.SelectedNode.Nodes[TV_FiltersView.SelectedNode.Nodes.Count-1].Tag = new FilePathFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, TB_PathRegex.Text);
        }
        private void AddAttributeFilterAsChild(string negateText, string nameOfTheFilter)
        {
            Filters.Attribute attribute;
            if (RB_Archive.Checked)
                attribute = Filters.Attribute.ARCHIVE;
            else if(RB_ReadOnly.Checked)
                attribute = Filters.Attribute.READONLY;
            else if(RB_System.Checked)
                attribute = Filters.Attribute.SYSTEM;
            else if(RB_IsFile.Checked)
                attribute = Filters.Attribute.ISFILE;
            else if(RB_IsDirectory.Checked)
                attribute = Filters.Attribute.ISDIRECTORY;
            else
            {
                MessageBox.Show("Please choose file attribute first");
                return;
            }
            TV_FiltersView.SelectedNode.Nodes.Add(negateText + nameOfTheFilter + " Atributte filter");
            TV_FiltersView.SelectedNode.Nodes[TV_FiltersView.SelectedNode.Nodes.Count - 1].Tag = new AttributeFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, attribute);
        }

        private void AddDateTimeFilterAsChild(string negateText, string nameOfTheFilter)
        {
            BeforeAfter beforeAfter;
            if (CB_DateBeforeAfter.SelectedIndex == 0)
                beforeAfter = BeforeAfter.THISDATE;
            else if(CB_DateBeforeAfter.SelectedIndex == 1)
                beforeAfter = BeforeAfter.BEFORE;
            else if(CB_DateBeforeAfter.SelectedIndex ==2)
                beforeAfter = BeforeAfter.AFTER;
            else
            {
                MessageBox.Show("Please choose comparing first");
                return;
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
                return;
            }
            TV_FiltersView.SelectedNode.Nodes.Add(negateText + nameOfTheFilter + " Date Time");
            TV_FiltersView.SelectedNode.Nodes[TV_FiltersView.SelectedNode.Nodes.Count - 1].Tag = new DateTimeFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, beforeAfter, DTP_Date.Value, flag);
            
        }
        private void AddSizeFilterAsChild(string negateText, string nameOfTheFilter)
        {
            LargerSmaller largerSmaller;
            if (RB_Minimal.Checked)
                largerSmaller = LargerSmaller.LARGER;
            else if(RB_Maximal.Checked)
                largerSmaller = LargerSmaller.SMALLER;
            else
            {
                MessageBox.Show("Please choose comparing first");
                return;
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
                return;
            }
            TV_FiltersView.SelectedNode.Nodes.Add(negateText + nameOfTheFilter + " Size filter");
            TV_FiltersView.SelectedNode.Nodes[TV_FiltersView.SelectedNode.Nodes.Count - 1].Tag = new SizeFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, Decimal.ToDouble(NUD_Number.Value), largerSmaller, unit);

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

        private bool CanAddChildToNode(Filter filter)
        {
            if (GetTypeOfFilter(filter) == TypeOfFilter.AGGREGATION)
                return true;
            else return false;
        }

        private void B_Remove_Click(object sender, EventArgs e)
        {
            TV_FiltersView.SelectedNode.Remove();
        }

        private void TV_FiltersView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (GetTypeOfFilter((Filter)TV_FiltersView.SelectedNode.Tag))
            {
                case TypeOfFilter.AGGREGATION: FillDataToTabControlForAggregation(); break; //editace
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
            AttributeFilter attributeFilter = (AttributeFilter)TV_FiltersView.SelectedNode.Tag;
            TC_Filters.SelectedIndex = 2;
            SetNameAndNegate(attributeFilter);

            switch (attributeFilter.Attribute)
            {
                case Filters.Attribute.ARCHIVE: RB_Archive.Checked = true;
                    break;
                case Filters.Attribute.READONLY: RB_ReadOnly.Checked = true;
                    break;
                case Filters.Attribute.SYSTEM: RB_System.Checked = true;
                    break;
                case Filters.Attribute.ISFILE: RB_IsFile.Checked = true;
                    break;
                case Filters.Attribute.ISDIRECTORY: RB_IsDirectory.Checked = true;
                    break;
                default:
                    break;
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
                    CB_DateBeforeAfter.SelectedIndex = 1;
                    break;
                case BeforeAfter.AFTER:
                    CB_DateBeforeAfter.SelectedIndex = 2;
                    break;
                case BeforeAfter.THISDATE:
                    CB_DateBeforeAfter.SelectedIndex = 0;
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
            if(GetTypeOfFilter((Filter) TV_FiltersView.SelectedNode.Tag) == TypeOfFilter.AGGREGATION && TC_Filters.SelectedIndex != 0 && TV_FiltersView.SelectedNode.Nodes.Count > 0)
            {
                MessageBox.Show("Delete subfilters first");
                return;
            }
            string negateText = ChB_Negate.Checked ? "-" : "+";
            string nameOfTheFilter = TB_NameOfFilter.TextLength > 0 ? "<< " + TB_NameOfFilter.Text + " >>" : "";
            switch (TC_Filters.SelectedIndex)
            {
                case 0:
                    EditAggregationFilter(negateText, nameOfTheFilter);
                    break;
                case 1:
                    EditFilePathFilter(negateText, nameOfTheFilter); break;
                case 2:
                    EditAttributeFilter(negateText, nameOfTheFilter); break;
                case 3:
                    EditDateTimeFilter(negateText, nameOfTheFilter); break;
                case 4:
                    EditSizeFilter(negateText, nameOfTheFilter); break;
                default:
                    break;
            }         
        }
        // editace

        private void EditAggregationFilter(string negateText, string nameOfTheFilter)
        {
            string node;
            AggregationOperand Ao;
            if (RB_And.Checked)
            {
                node = "(and)";
                Ao = AggregationOperand.AND;
            }
            else if (RB_OR.Checked)
            {
                node = "(or)";
                Ao = AggregationOperand.OR;
            }
            else
            {
                MessageBox.Show("Please choose aggregation operand");
                return;
            }
            TV_FiltersView.SelectedNode.Text = negateText + nameOfTheFilter + node;
            TV_FiltersView.SelectedNode.Tag = new AggregationFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, Ao, new List<Filter>());
            MessageBox.Show("Editace proběhla úspěšně");

        }
        private void EditFilePathFilter(string negateText, string nameOfTheFilter)
        {
            if (TB_PathRegex.Text.Length == 0)
            {
                MessageBox.Show("Please fill Regex first");
                return;
            }
            TV_FiltersView.SelectedNode.Text = negateText + nameOfTheFilter + " Path Filter";
            TV_FiltersView.SelectedNode.Tag = new FilePathFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, TB_PathRegex.Text);
            MessageBox.Show("Editace proběhla úspěšně");
        }
        private void EditAttributeFilter(string negateText, string nameOfTheFilter)
        {
            Filters.Attribute attribute;
            if (RB_Archive.Checked)
                attribute = Filters.Attribute.ARCHIVE;
            else if (RB_ReadOnly.Checked)
                attribute = Filters.Attribute.READONLY;
            else if (RB_System.Checked)
                attribute = Filters.Attribute.SYSTEM;
            else if (RB_IsFile.Checked)
                attribute = Filters.Attribute.ISFILE;
            else if (RB_IsDirectory.Checked)
                attribute = Filters.Attribute.ISDIRECTORY;
            else
            {
                MessageBox.Show("Please choose file attribute first");
                return;
            }
            TV_FiltersView.SelectedNode.Text = negateText + nameOfTheFilter + " Atributte filter";
            TV_FiltersView.SelectedNode.Tag = new AttributeFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, attribute);
            MessageBox.Show("Editace proběhla úspěšně");
        }

        private void EditDateTimeFilter(string negateText, string nameOfTheFilter)
        {
            BeforeAfter beforeAfter;
            if (CB_DateBeforeAfter.SelectedIndex == 0)
                beforeAfter = BeforeAfter.THISDATE;
            else if (CB_DateBeforeAfter.SelectedIndex == 1)
                beforeAfter = BeforeAfter.BEFORE;
            else if (CB_DateBeforeAfter.SelectedIndex == 2)
                beforeAfter = BeforeAfter.AFTER;
            else
            {
                MessageBox.Show("Please choose comparing first");
                return;
            }

            Flag flag;
            if (RB_CreationDateTime.Checked)
                flag = Flag.CREATION;
            else if (RB_LastWriteDateTime.Checked)
                flag = Flag.LASTWRITE;
            else if (RB_LastAccessDateTime.Checked)
                flag = Flag.LASTACCESS;
            else
            {
                MessageBox.Show("Please choose file flag first");
                return;
            }
            TV_FiltersView.SelectedNode.Text = negateText + nameOfTheFilter + " Date Time";
            TV_FiltersView.SelectedNode.Tag = new DateTimeFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, beforeAfter, DTP_Date.Value, flag);
            MessageBox.Show("Editace proběhla úspěšně");

        }
        private void EditSizeFilter(string negateText, string nameOfTheFilter)
        {
            LargerSmaller largerSmaller;
            if (RB_Minimal.Checked)
                largerSmaller = LargerSmaller.LARGER;
            else if (RB_Maximal.Checked)
                largerSmaller = LargerSmaller.SMALLER;
            else
            {
                MessageBox.Show("Please choose comparing first");
                return;
            }
            Unit unit;
            if (RB_Size_B.Checked)
                unit = Unit.B;
            else if (RB_Size_kB.Checked)
                unit = Unit.kB;
            else if (RB_Size_MB.Checked)
                unit = Unit.MB;
            else if (RB_Size_GB.Checked)
                unit = Unit.GB;
            else
            {
                MessageBox.Show("Please choose unit of size first");
                return;
            }
            TV_FiltersView.SelectedNode.Text = negateText + nameOfTheFilter + " Size filter";
            TV_FiltersView.SelectedNode.Tag = new SizeFilter(ChB_Negate.Checked, TB_NameOfFilter.Text, Decimal.ToDouble(NUD_Number.Value), largerSmaller, unit);
            MessageBox.Show("Editace proběhla úspěšně");
        }

        private void B_SimulateBackup_Click(object sender, EventArgs e)
        {
            SimulateBackup simulateBackup = new SimulateBackup(project1);
            FileInfo[] filteredFiles = simulateBackup.Simulate(TV_FiltersView);
            TempForm tempForm = new TempForm(filteredFiles);
            tempForm.Show();
            
        }
    }
}
