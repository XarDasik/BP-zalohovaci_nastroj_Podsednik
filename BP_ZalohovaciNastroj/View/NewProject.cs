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
    public partial class NewProject : Form
    {
        public NewProject()
        {
            InitializeComponent();
            Backup backupForm = new Backup(true);
            backupForm.TopLevel = false;
            backupForm.FormBorderStyle = FormBorderStyle.None;
            backupForm.Dock = DockStyle.Fill;
            pnlBackUp.Controls.Add(backupForm);
            backupForm.Show();
            tbNameProject.Text = "project1";
            tbSaveLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BackupAppProjects";
        }

        private void B_DestionationPathLoader_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbSaveLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {

        }
    }
}
