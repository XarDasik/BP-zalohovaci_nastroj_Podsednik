using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BP_ZalohovaciNastroj.View.Backup.ProgressWindows
{
    public partial class LoadingForm : Form
    {
        public bool IsCanceled { get; set; }        
        public LoadingForm()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Cancelling...";
            IsCanceled = true;
            button1.Enabled = false;
        }
    }
}
