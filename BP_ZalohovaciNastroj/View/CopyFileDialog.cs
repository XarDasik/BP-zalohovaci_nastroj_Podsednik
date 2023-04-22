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
    public partial class Main : Form
    {
        Backup backupForm = new Backup(false);
        Recovery recoveryForm;
        ShowProject showProject;
        public Main()
        {
            InitializeComponent();

            backupForm = new Backup(true);
            backupForm.TopLevel = false;
            backupForm.FormBorderStyle = FormBorderStyle.None;
            backupForm.Dock = DockStyle.Fill;
            P_Main.Controls.Add(backupForm);

            recoveryForm = new Recovery();
            recoveryForm.TopLevel = false;
            recoveryForm.FormBorderStyle = FormBorderStyle.None;
            recoveryForm.Dock = DockStyle.Fill;
            P_Main.Controls.Add(recoveryForm);

            showProject = new ShowProject();
            showProject.TopLevel = false;
            showProject.FormBorderStyle = FormBorderStyle.None;
            showProject.Dock = DockStyle.Fill;
            P_Main.Controls.Add(showProject);
        }
        private void B_Recovery_Click(object sender, EventArgs e)
        {
            HideAllForms();
            recoveryForm.Show();
        }

        private void B_NewProject_Click(object sender, EventArgs e)
        {
            HideAllForms();
            backupForm.Show();
        }
        private void HideAllForms()
        {
            recoveryForm.Hide();
            backupForm.Hide();
            showProject.Hide();
        }

        private void B_ShowProjects_Click(object sender, EventArgs e)
        {
            HideAllForms();
            showProject.Show();
        }
    }
}
