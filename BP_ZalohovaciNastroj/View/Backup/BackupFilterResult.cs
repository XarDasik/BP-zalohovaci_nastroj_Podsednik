﻿using BP_ZalohovaciNastroj.View.Backup;
using BP_ZalohovaciNastroj.View.Backup.ProgressWindows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Hosting;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BP_ZalohovaciNastroj
{
    public partial class FilterResult : Form
    {
        private const int RED_DOT_INDEX = 0;
        private const int GREEN_DOT_INDEX = 1;

        private const int RED_FOLDER_INDEX = 0;
        private const int YELLOW_FOLDER_INDEX = 1;
        private const int GREEN_FOLDER_INDEX = 2;
        private const int EMPTY_FOLDER_INDEX = 3;
        private const int ERROR_FOLDER_INDEX = 4;

        private MyFile[] Files { get; set; }
        private TreeView Filters {get; set;}
        private string init_folder;
        private string destination_folder;
        private int maxCountOfBackups;
        BackupProgress backupProgress = new BackupProgress();
        LoadingForm loadingForm = new LoadingForm();
        Dictionary<MyFile, Result> backupInfo = new Dictionary<MyFile, Result>();
        private string actualFile;
        

        public FilterResult(MyFile[] files, TreeView filters,string init_folder, string destination_folder, int maxCountOfBackups)
        {
            InitializeComponent();
            this.init_folder = @init_folder;
            this.Files = files;
            this.Filters = filters;
            this.destination_folder = @destination_folder;
            this.maxCountOfBackups = maxCountOfBackups;

            this.Text += " - " + (string)new DirectoryInfo(init_folder).FullName;
            BackupLegendFilterResult BackupLegend = new BackupLegendFilterResult();
            BackupLegend.TopLevel = false;
            BackupLegend.FormBorderStyle = FormBorderStyle.None;
            BackupLegend.Dock = DockStyle.Fill;
            BackupLegend.Show();           
           
        }
        private void TempForm_Load(object sender, EventArgs e)
        {
            this.Text += " - " + (string)new DirectoryInfo(init_folder).FullName;
            BackupLegendFilterResult BackupLegend = new BackupLegendFilterResult();
            BackupLegend.TopLevel = false;
            BackupLegend.FormBorderStyle = FormBorderStyle.None;
            BackupLegend.Dock = DockStyle.Fill;
            BackupLegend.Show();
            splitContainer3.Panel2.Controls.Add(BackupLegend);
            backgroundWorker2.RunWorkerAsync();
            loadingForm.ShowDialog();
        }
        private void InitTvw()
        {            
            DirectoryInfo rootDirectoryInfo = new DirectoryInfo(init_folder);
            TreeNode mainNode = new TreeNode(rootDirectoryInfo.Name);
            mainNode.ImageIndex = GetColorIndexOfFolder(rootDirectoryInfo);
            mainNode.Tag = rootDirectoryInfo;
            mainNode.SelectedImageIndex = mainNode.ImageIndex;
            if (loadingForm.IsCanceled) return;
            if (tvw.InvokeRequired)
            {
                tvw.BeginInvoke((MethodInvoker)delegate
                {
                    tvw.Nodes.Add(mainNode);
                });
            }
            var folders = Directory.GetDirectories(init_folder);
            
            foreach (DirectoryInfo di in rootDirectoryInfo.GetDirectories())
            {
                TreeNode node = new TreeNode(di.Name);
                node.Tag = di;
                try
                {
                    if (di.IsEmpty())
                        node.ImageIndex = EMPTY_FOLDER_INDEX;
                    else
                        node.ImageIndex = GetColorIndexOfFolder(di);                    
                }
                catch
                {
                    node.ImageIndex = ERROR_FOLDER_INDEX;
                }
                node.SelectedImageIndex = node.ImageIndex;
                if (node.ImageIndex != ERROR_FOLDER_INDEX && node.ImageIndex != EMPTY_FOLDER_INDEX)
                    node.Nodes.Add(new TreeNode());
                if (tvw.InvokeRequired)
                {
                    if (loadingForm.IsCanceled) return;
                    tvw.BeginInvoke((MethodInvoker)delegate
                    {
                        tvw.Nodes[0].Nodes.Add(node);
                    });
                }
                
            }
            backgroundWorker2.ReportProgress(100);
        }

        private void tvw_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count == 0 || e.Node.Nodes[0].Tag != null) return; 

            e.Node.Nodes.Clear();
            var parent = e.Node.Tag as DirectoryInfo;
            foreach (DirectoryInfo di in parent.GetDirectories())
            {
                TreeNode node = new TreeNode(di.Name);
                node.Tag = di;
                try
                {
                    node.ImageIndex = e.Node.ImageIndex == YELLOW_FOLDER_INDEX ?
                      (di.IsEmpty() ? EMPTY_FOLDER_INDEX : GREEN_FOLDER_INDEX) : e.Node.ImageIndex;
                    node.ImageIndex = GetColorIndexOfFolder(di);
                }
                catch
                {
                    node.ImageIndex = ERROR_FOLDER_INDEX;
                }
                node.SelectedImageIndex = node.ImageIndex;
                if (node.ImageIndex != ERROR_FOLDER_INDEX && node.ImageIndex != EMPTY_FOLDER_INDEX)
                    node.Nodes.Add(new TreeNode());
                e.Node.Nodes.Add(node);
            }
        }
        private int GetColorIndexOfFolder(DirectoryInfo di)
        {
            if (di.GetDirectories().Length == 0)
                return GetColorIndexOfFolderByFiles(di);
            if (GetColorIndexOfFolderByFiles(di) == YELLOW_FOLDER_INDEX)
                return YELLOW_FOLDER_INDEX;

           List<int> temp = new List<int>();

                int actualDirectory = GetColorIndexOfFolderByFiles(di);
                if (actualDirectory == EMPTY_FOLDER_INDEX && di.GetDirectories().Length > 0)
                {
                    foreach (DirectoryInfo item in di.GetDirectories())
                    {
                        int folderColor = GetColorIndexOfFolder(item);
                        if (folderColor != EMPTY_FOLDER_INDEX)
                            temp.Add(folderColor);
                    }
                    for (int i = 0; i < temp.Count - 1; i++)
                    {
                        if (temp[i] != temp[i + 1])
                            return YELLOW_FOLDER_INDEX;
                    }
                    return temp[temp.Count - 1];
                }
                else 
                {
                    temp.Add(actualDirectory);

                    foreach (DirectoryInfo item in di.GetDirectories())
                    {
                        int folderColor = GetColorIndexOfFolder(item);
                        if (folderColor != EMPTY_FOLDER_INDEX)
                            temp.Add(folderColor);
                    }
                    for (int i = 0; i < temp.Count - 1; i++)
                    {
                        if (temp[i] != temp[i + 1])
                            return YELLOW_FOLDER_INDEX;
                    }
                }

                return GetColorIndexOfFolderByFiles(di);
        }
        private int GetColorIndexOfFolderByFiles(DirectoryInfo di)
        {
            if (di.GetFiles().Count() == 0)
                return EMPTY_FOLDER_INDEX;

            int countToBackUp = 0;
            foreach (FileInfo f in di.GetFiles())
            {
                if (IsSetToBackUp(f))
                {
                    countToBackUp++;
                }
            }
            
            if (countToBackUp == 0 && di.GetFiles().Count() > 0)
                return RED_FOLDER_INDEX;
            else if (countToBackUp == 0 && di.GetDirectories().Length > 0)
                return GetColorNextFolder(di);
            else if (countToBackUp < di.GetFiles().Count())
                return YELLOW_FOLDER_INDEX;
            else
                return GREEN_FOLDER_INDEX;
        }
        private int GetColorNextFolder(DirectoryInfo di) 
        {
            List<int> temp = new List<int>();
            foreach (DirectoryInfo item in di.GetDirectories())
            {
                int subDirectory = GetColorIndexOfFolderByFiles(item);
                temp.Add(subDirectory);
                if (item.GetDirectories().Length > 0)
                    temp.Add(GetColorIndexOfFolder(item));
            }
            for (int i = 0; i < temp.Count - 1; i++)
            {
                if (temp[i] != temp[i + 1])
                    return YELLOW_FOLDER_INDEX;
            }
            return temp[0];
        }
        

        private void tvw_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateListView(e.Node);
        }

        private void UpdateListView(TreeNode node)
        {
            lvw.Items.Clear();
            var di = node.Tag as DirectoryInfo;
            foreach (FileInfo f in di.GetFiles())
            {
                ListViewItem lwi = new ListViewItem(f.Name);
                lwi.Tag = f;
                if (IsSetToBackUp(f))
                {
                    lwi.ImageIndex = GREEN_DOT_INDEX;
                }
                else
                    lwi.ImageIndex = RED_DOT_INDEX;
                lvw.Items.Add(lwi);
            }
        }
        private bool IsSetToBackUp(FileInfo f)
        {
            for (int i = 0; i < Files.Length; i++)
            {
                if(Files[i].ToBackUp == true && f.FullName.Equals(Files[i].File.FullName))
                {
                    return true;
                }
            }           
            return false;
        }

        private void lvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            tvwFilters.Nodes.Clear();
            if (lvw.SelectedItems.Count > 0)
                UpdateFilterView((FileInfo)lvw.SelectedItems[0].Tag);
        }

        private void UpdateFilterView(FileInfo f)
        {
            tvwFilters.Nodes.Clear();
            FillFilterView(Filters, f);
            tvwFilters.ExpandAll();
            tvwFilters.Refresh();
        }
        public void FillFilterView(TreeView filters, FileInfo f)
        {            
            TreeNode newTn = new TreeNode("MainFilter");            
            foreach (TreeNode tn in filters.Nodes)
            {
                Filter filter = (Filter)tn.Tag;
                string safeText = tn.Text.Replace('{', '[').Replace('}', ']');
                if (filter.Accepts(f, new Project()))
                      newTn = new TreeNode(String.Format("[Acc] " + safeText), GREEN_DOT_INDEX, GREEN_DOT_INDEX);
                 else
                      newTn = new TreeNode(String.Format("[Rej] " + safeText), RED_DOT_INDEX, RED_DOT_INDEX);
                FillFilterNodeChildren(newTn, tn, f);          
                tvwFilters.Nodes.Add(newTn);
            }
        }
        public void FillFilterNodeChildren(TreeNode parent, TreeNode original, FileInfo f)
        {
            TreeNode newTn;
            foreach (TreeNode tn in original.Nodes)
            {
                Filter filter = (Filter)tn.Tag;
                if (filter.Accepts(f, new Project()))
                    newTn = new TreeNode(tn.Text, GREEN_DOT_INDEX, GREEN_DOT_INDEX);
                   else
                        newTn = new TreeNode(tn.Text, RED_DOT_INDEX, RED_DOT_INDEX);
                    parent.Nodes.Add(newTn);                          
                 FillFilterNodeChildren(newTn, tn, f);
            }
        }
        private int GetFileCount() 
        {
            int ret = 0;
            foreach (MyFile file in Files)
            {
                if (file.ToBackUp) 
                { 
                    ret++;
                }
            }
            return ret;           
        }
        

        private void B_BackUp_Click(object sender, EventArgs e)
        {
            if (GetFileCount() > 0)
            {                
                backgroundWorker1.RunWorkerAsync();
                backupProgress.FileCount = GetFileCount();
                backupProgress.ShowDialog();
            }
            else
                MessageBox.Show("No files to backup.\nEmpty Folder or all files are rejected by filters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void DeleteTheOldestBackup(List<FileInfo> files)
        {
            if(files.Count() > 0)
            {
                int indexOfOldestFile = 0;
                DateTime OldestFile = files[0].CreationTime;
                for (int i = 1; i < files.Count; i++)
                {
                    if (files[i].CreationTime.Ticks < OldestFile.Ticks)
                    {
                        indexOfOldestFile = i;
                        OldestFile = files[i].CreationTime;
                    }
                }
                File.Delete(files[indexOfOldestFile].FullName);
            }             
        }

        private bool IsMaximumBackupsAlready(string fileName, string folderPath, string extension)
        {            
            if (GetOldBackups(fileName, folderPath, extension).Count >= maxCountOfBackups)
                return true;
            else
                return false;
        }

        private List<FileInfo> GetOldBackups(string fileName, string folderPath, string extension)
        {
            List<FileInfo> files = new List<FileInfo>();
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            FileInfo[] allFiles = dir.GetFiles();
            foreach (var item in allFiles)
            {
                if (item.Name.Contains('_'))
                {
                    if (item.Name.Substring(0, item.Name.LastIndexOf('_')).Equals(fileName) && extension.Equals(item.Extension) && IsTextDateTime(item.Name.Substring(item.Name.LastIndexOf('_') +1, item.Name.LastIndexOf('.') - item.Name.LastIndexOf('_')-1))) 
                        files.Add(item);
                }
            }
            return files;
        }
        private bool IsTextDateTime(string text)
        {
            Regex rx = new Regex("^\\d{4}-\\d{2}-\\d{2}-\\d{2}-\\d{2}-\\d{2}$");
            MatchCollection matches = rx.Matches(text);
            if (matches.Count > 0)
                return true;
            else return false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {               
            try
            {
                foreach (string dirPath in Directory.GetDirectories(init_folder, "*", SearchOption.AllDirectories))
                {
                    foreach (var item in Files)
                    {
                        if (item.File.DirectoryName.Equals(dirPath) && item.ToBackUp)
                        {
                            Directory.CreateDirectory(dirPath.Replace(init_folder, destination_folder));
                        }
                    }
                }
                
                
                foreach (string newPath in Directory.GetFiles(init_folder, "*.*", SearchOption.AllDirectories))
                {
                    foreach (var item in Files)
                    {
                        if (item.File.FullName.Equals(newPath) && item.ToBackUp)
                        {
                            if (IsBackupCancelled()) 
                            {
                                backgroundWorker1.ReportProgress(100);
                                return;
                            }
                            actualFile = newPath;
                            backgroundWorker1.ReportProgress(1);
                            try
                            {
                                
                                if (File.Exists(newPath.Replace(init_folder, destination_folder)))
                                {
                                    if (File.GetLastWriteTime(newPath) == File.GetLastWriteTime(newPath.Replace(init_folder, destination_folder)))
                                    {
                                        backupInfo.Add(item, Result.NOTNECESSARY);
                                    }
                                    else 
                                    {
                                        DateTime dateTime = File.GetCreationTime((newPath.Replace(init_folder, destination_folder)));
                                        if (maxCountOfBackups == 0)
                                        {
                                            File.Delete(newPath.Replace(init_folder, destination_folder));
                                            File.Copy(newPath, newPath.Replace(init_folder, destination_folder));
                                        }
                                        else
                                        {
                                            if (IsMaximumBackupsAlready(Path.GetFileNameWithoutExtension(newPath), newPath.Replace(init_folder, destination_folder).Substring(0, newPath.Replace(init_folder, destination_folder).LastIndexOf('\\') + 1), item.File.Extension))
                                            {
                                                DeleteTheOldestBackup(GetOldBackups(Path.GetFileNameWithoutExtension(newPath), newPath.Replace(init_folder, destination_folder).Substring(0, newPath.Replace(init_folder, destination_folder).LastIndexOf('\\') + 1), item.File.Extension));
                                                string newName = (Path.GetFileNameWithoutExtension(newPath) + "_" + dateTime.ToString("yyyy-MM-dd-HH-mm-ss") + Path.GetExtension(newPath));
                                                File.Move(newPath.Replace(init_folder, destination_folder), newPath.Replace(init_folder, destination_folder).Substring(0, newPath.Replace(init_folder, destination_folder).LastIndexOf('\\') + 1) + newName);
                                                File.Copy(newPath, newPath.Replace(init_folder, destination_folder), false);
                                            }
                                            else
                                            {
                                                string newName = (Path.GetFileNameWithoutExtension(newPath) + "_" + dateTime.ToString("yyyy-MM-dd-HH-mm-ss") + Path.GetExtension(newPath));
                                                File.Move(newPath.Replace(init_folder, destination_folder), newPath.Replace(init_folder, destination_folder).Substring(0, newPath.Replace(init_folder, destination_folder).LastIndexOf('\\') + 1) + newName);
                                                File.Copy(newPath, newPath.Replace(init_folder, destination_folder), false);
                                            }

                                        }
                                        backupInfo.Add(item, Result.SUCCESSFULL);
                                    }
                                    
                                }
                                else
                                {
                                    File.Copy(newPath, newPath.Replace(init_folder, destination_folder), false);
                                    backupInfo.Add(item, Result.SUCCESSFULL);
                                }
                            }
                            catch (Exception)
                            {
                                backupInfo.Add(item, Result.ERROR);
                            }
                        }
                    }
                }
               
               backgroundWorker1.ReportProgress(100);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Unknown error. Make sure, you are not moving files during backup.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsBackupCancelled()
        {
            return backupProgress.IsCanceled;

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            backupProgress.ActualFile = actualFile;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backupProgress.Close();
            ShowBackupResult();
                     
        }
        private void ShowBackupResult()
        {
            BackupResult backupResult = new BackupResult(backupInfo, init_folder);            
            backupResult.Show();
            this.Close();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            InitTvw();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadingForm.Close();
        }
    }
}
