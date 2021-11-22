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
    
    public partial class mainPage : Form
    {
        public static List<FileInfo> files = new List<FileInfo>();
        public mainPage()
        {
            InitializeComponent();
        }

        private void B_path_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TB_RootPath.Text = folderBrowserDialog1.SelectedPath;
                var dir = new DirectoryInfo(TB_RootPath.Text);
                files = dir.GetFiles("*.*", SearchOption.AllDirectories).ToList<FileInfo>();
                for (int i = 0; i < files.Count; i++)
                {
                    Console.WriteLine(files[i].Name);
                }
                files = new FilterManager().applyFilter(files.ToArray(), new AggregationFilter(false, "OR", AggregationOperand.OR, new Filter[] { new FilePathFilter(false, "Snippets", "\\\\TestD\\\\"), new AggregationFilter(false, "", AggregationOperand.AND, new Filter[] { new FilePathFilter(false, "","\\\\Zkouska\\\\") })}));
                Console.WriteLine("========");
                for (int i = 0; i < files.Count; i++)
                {
                    Console.WriteLine(files[i].Name);
                }
            }
        }

        private void B_addLogicOperand_Click(object sender, EventArgs e)
        {
            
        }

        private void B_addFilter_Click(object sender, EventArgs e)
        {


           
        }
    }
}
