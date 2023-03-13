using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_ZalohovaciNastroj.View.Backup.ProgressWindows
{
    public partial class BackupProgress : Form
    {
        private string _actualFile;
        public string ActualFile {
            get { return _actualFile; }
            set
            {
                _actualFile = value;
                ActualIndex = ActualIndex + 1;
            }
        }
        private int _actualIndex;
        public int ActualIndex
        {
            get { return _actualIndex; }
            set
            {
                _actualIndex = value;
                UpdateUI();
            }
        }
        public int FileCount { get; set; }
        public BackupProgress()
        {
            InitializeComponent();
            
        }
        public void UpdateUI() 
        {           
            progressBar1.Maximum = FileCount;
            lblActualFile.Text = ActualFile;
            lblNumber.Text = String.Format("{0}/{1} files", ActualIndex.ToString(), FileCount.ToString());
            if(ActualIndex <= FileCount)
                progressBar1.Value = ActualIndex;
        }
    }
}
