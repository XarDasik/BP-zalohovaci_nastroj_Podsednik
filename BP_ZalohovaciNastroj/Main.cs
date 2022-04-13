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

        Backup backupForm = new Backup();
        Recovery recoveryForm;
        public Main()
        {
            InitializeComponent();

            backupForm = new Backup();
            backupForm.TopLevel = false;
            backupForm.FormBorderStyle = FormBorderStyle.None;
            backupForm.Dock = DockStyle.Fill;
            P_Main.Controls.Add(backupForm);
            backupForm.Show();

            recoveryForm = new Recovery();
            recoveryForm.TopLevel = false;
            recoveryForm.FormBorderStyle = FormBorderStyle.None;
            recoveryForm.Dock = DockStyle.Fill;
            P_Main.Controls.Add(recoveryForm);
        }

        private void B_Backup_Click(object sender, EventArgs e)
        {
            recoveryForm.Hide();
            backupForm.Show();
        }

        private void B_Recovery_Click(object sender, EventArgs e)
        {
            backupForm.Hide();
            recoveryForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
