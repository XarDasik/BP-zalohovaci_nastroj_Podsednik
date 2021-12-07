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
    public partial class TempForm : Form
    {
        public TempForm(FileInfo[] files)
        {
            InitializeComponent();
            foreach (var item in files)
            {
                listBox1.Items.Add(item.FullName);
            }
        }
    }
}
