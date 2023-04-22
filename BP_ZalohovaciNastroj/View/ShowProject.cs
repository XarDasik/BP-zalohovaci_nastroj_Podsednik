using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_ZalohovaciNastroj
{
    public partial class ShowProject : Form
    {
        public ShowProject()
        {
            InitializeComponent();
            Backup backupForm = new Backup(false);
            backupForm.TopLevel = false;
            backupForm.FormBorderStyle = FormBorderStyle.None;
            backupForm.Dock = DockStyle.Fill;
            pnlBackup.Controls.Add(backupForm);
            backupForm.Show();
        }
    }
}
