using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_ZalohovaciNastroj
{
    public partial class Form1 : Form
    {
        public static List<FileInfo> files = new List<FileInfo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void B_path_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TB_path.Text = folderBrowserDialog1.SelectedPath;
                var dir = new DirectoryInfo(TB_path.Text);
                files = dir.GetFiles("*.*", SearchOption.AllDirectories).ToList<FileInfo>();
                foreach (var item in files)
                {
                    Console.WriteLine(item.FullName);
                }

               Console.WriteLine("-----------------------------\n--------------------\n---------------");
                
                foreach (FileInfo item in files)
                {
                    LB_files.Items.Add(item.FullName);
                }

            }
        }

        private void B_addLogicOperand_Click(object sender, EventArgs e)
        {
            if (CB_LogicOperand.SelectedItem != null)
            {
                TV_filters.Nodes.Add(CB_LogicOperand.Items[CB_LogicOperand.SelectedIndex].ToString());
            }
            else
                MessageBox.Show("Vyberte si logický operátor.");
        }

        private void B_addFilter_Click(object sender, EventArgs e)
        {
            if(TV_filters.SelectedNode != null)
            {
                TV_filters.Nodes[TV_filters.SelectedNode.Index].Nodes.Add("Filtr přípona - .txt");
                TV_filters.Nodes[TV_filters.SelectedNode.Index].Nodes.Add("Filtr přípona - .avi");
                files = new FilterManager().applyFilter(files.ToArray(), new AggregationFilter(AggregationOperand.OR, new Filter[] { new ExtensionFilter(".txt"), new ExtensionFilter(".avi") }));
                //files = new FilterManager().applyFilter(files.ToArray(), new AggregationFilter(AggregationOperand.AND, new Filter[] { new SizeFilter(0, Comparator.LARGER), new SizeFilter(1000000000, Comparator.SMALLER) }));
                LB_files.Items.Clear();
                foreach (FileInfo item in files)
                {
                    LB_files.Items.Add(item.FullName);
                }
            }
            else
                MessageBox.Show("Zvolte na který logický operátor chcete přidat filter.");
        }
    }
}
