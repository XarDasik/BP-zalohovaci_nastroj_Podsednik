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

namespace BP_ZalohovaciNastroj
{
    public partial class ShowProject : Form
    {
        Backup backupForm = new Backup(false);
        List<string> files;
        public ShowProject()
        {
            InitializeComponent();
            backupForm = new Backup(false);
            backupForm.TopLevel = false;
            backupForm.FormBorderStyle = FormBorderStyle.None;
            backupForm.Dock = DockStyle.Fill;
            pnlBackup.Controls.Add(backupForm);

            RefreshLbProjects();
        }
        private void RefreshLbProjects() 
        {
            lbProjects.Items.Clear();
            files = new List<string>();
            if(Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\BackupAppProjects"))
                files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\BackupAppProjects").ToList();

            for (int i = 0; i < files.Count; i++)
            {
                if (files[i].EndsWith(".data"))
                {
                    lbProjects.Items.Add(Path.GetFileNameWithoutExtension(files[i]));

                }
                else
                    files.RemoveAt(i);
            }
        }
        private void btnLoadProject_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                lbProjects.Items.Add(Path.GetFileNameWithoutExtension(openFileDialog1.FileName));
                files.Add(openFileDialog1.FileName);
            }
        }

        private void lbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBackupForm();
        }
        private void ShowBackupForm() 
        {
            if (lbProjects.SelectedIndex < 0)
                return;
            IFormatter formatter = new BinaryFormatter();
            Stream stream1 = new FileStream(String.Format(files[lbProjects.SelectedIndex]), FileMode.Open, FileAccess.Read);
            try
            {
                backupForm.project = (Project)formatter.Deserialize(stream1);
                backupForm.PathFile = files[lbProjects.SelectedIndex];
                backupForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("File is not compatible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                backupForm.Hide();
            }
            stream1.Close();
            backupForm.RefreshFilters();
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            if (lbProjects.SelectedItems.Count != 1)
            {
                MessageBox.Show("Select a project you want to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
               
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the project?", "Delete action", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    File.Delete(files[lbProjects.SelectedIndex]);
                    files.RemoveAt(lbProjects.SelectedIndex);
                    RefreshLbProjects();
                }
                catch (Exception)
                {
                    MessageBox.Show("The project could not been deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }                
            }
        }

        private void ShowProject_Enter(object sender, EventArgs e)
        {
            RefreshLbProjects();
        }

        private void ShowProject_VisibleChanged(object sender, EventArgs e)
        {
            RefreshLbProjects();
        }
    }
}
