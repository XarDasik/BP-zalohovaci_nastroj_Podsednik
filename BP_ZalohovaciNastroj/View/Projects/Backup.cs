using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_ZalohovaciNastroj.View
{
    public partial class NewProjectDialog : Form
    {
        Project project;
        public NewProjectDialog(Project project)
        {
            InitializeComponent();
            this.project = project;           
            tbSaveLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\BackupAppProjects";
        }

        private void B_DestionationPathLoader_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbSaveLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbNameProject.Text.Length < 1)
            {
                MessageBox.Show("Please name your new project.");
                return;
            }
            if (!Directory.Exists(tbSaveLocation.Text))
            {
                Directory.CreateDirectory(tbSaveLocation.Text);
            }
            if (File.Exists(String.Format("{0}\\{1}.txt", tbSaveLocation.Text, tbNameProject.Text)))
            {
                MessageBox.Show("Project with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(String.Format("{0}\\{1}.data", tbSaveLocation.Text, tbNameProject.Text), FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, project);
            stream.Close();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
