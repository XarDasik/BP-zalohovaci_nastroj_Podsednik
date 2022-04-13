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
    public partial class CopyFileDialog : Form
    {
        private int actualIndex = 0;
        public Dictionary<FileInfo, bool> filesToRecovery;
        public CopyFileDialog(Dictionary<FileInfo, bool> filesToRecovery)
        {
            InitializeComponent();
            this.filesToRecovery = filesToRecovery;
            RefreshUI();
        }
        private void RefreshUI()
        {
            lblFileName.Text = String.Format("The file {0} already exists", filesToRecovery.ElementAt(actualIndex).Key.FullName);
            lblCountListingOfFiles.Text = String.Format("{0}/{1}",actualIndex+1, filesToRecovery.Count);
            lblActualState.Text = String.Format("Actual Status of file: {0}", filesToRecovery.ElementAt(actualIndex).Value);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            SwitchFileToLeft();                
        }       

        private void btnRight_Click(object sender, EventArgs e)
        {
            SwitchFileToRight();               
        }
        private void SwitchFileToLeft()
        {
            if (actualIndex > 0)
            {
                actualIndex--;                
            }
            RefreshUI();
        }
        private void SwitchFileToRight()
        {
            if (actualIndex < filesToRecovery.Count-1)
            {
                actualIndex++;
            }
            RefreshUI();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            filesToRecovery[filesToRecovery.ElementAt(actualIndex).Key] = true;
            SwitchFileToRight();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            filesToRecovery[filesToRecovery.ElementAt(actualIndex).Key] = false;
            SwitchFileToRight();
        }

        private void btnForEveryFile_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < filesToRecovery.Count; i++)
            {
                filesToRecovery[filesToRecovery.ElementAt(i).Key] = true;
                SwitchFileToRight();
            }
        }
        private void btnForAllFilesInAFolder_Click(object sender, EventArgs e)
        {
            filesToRecovery[filesToRecovery.ElementAt(actualIndex).Key] = true;
            //int farFromOriginalIndex = 1;
            for (int i = 0; i < filesToRecovery.Count; i++)
            {
                if (filesToRecovery.ElementAt(i).Key.DirectoryName.Equals(filesToRecovery.ElementAt(actualIndex).Key.DirectoryName))
                {
                    filesToRecovery[filesToRecovery.ElementAt(i).Key] = true;
                    SwitchFileToRight();
                }
            }            
        }
        private void btnForNoFilesInAFolder_Click(object sender, EventArgs e)
        {
            filesToRecovery[filesToRecovery.ElementAt(actualIndex).Key] = false;
            //int farFromOriginalIndex = 1;
            for (int i = 0; i < filesToRecovery.Count; i++)
            {
                if (filesToRecovery.ElementAt(i).Key.DirectoryName.Equals(filesToRecovery.ElementAt(actualIndex).Key.DirectoryName))
                {
                    filesToRecovery[filesToRecovery.ElementAt(i).Key] = false;
                    SwitchFileToRight();
                }
            }            
        }
    }
}
