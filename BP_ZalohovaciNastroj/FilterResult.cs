﻿using System;
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

        public FilterResult(MyFile[] files, TreeView filters,string init_folder, string destination_folder)
        {
            InitializeComponent();
            this.init_folder = @init_folder;
            this.Files = files;
            this.Filters = filters;
            this.destination_folder = @destination_folder;
        }
        private void TempForm_Load(object sender, EventArgs e)
        {
            InitTvw();
        }
        private void InitTvw()
        {
            var folders = System.IO.Directory.GetDirectories(init_folder);
            var rootDirectoryInfo = new DirectoryInfo(init_folder);
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
                tvw.Nodes.Add(node);
            }
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
       /* private int GetColorIndexOfFolderByFiles(TreeNode node)
        {
            var di = node.Tag as DirectoryInfo;
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
            else if (countToBackUp < di.GetFiles().Count())
                return YELLOW_FOLDER_INDEX;
            else
                return GREEN_FOLDER_INDEX;
        }*/

        private int GetColorIndexOfFolderByFiles(DirectoryInfo di)
        {
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
            else if (countToBackUp < di.GetFiles().Count())
                return YELLOW_FOLDER_INDEX;
            else
                return GREEN_FOLDER_INDEX;
        }
        private int GetColorIndexOfFolder(DirectoryInfo di)
        {
            if (di.GetDirectories().Length == 0)
                return GetColorIndexOfFolderByFiles(di);
            if (GetColorIndexOfFolderByFiles(di) == YELLOW_FOLDER_INDEX)
                return YELLOW_FOLDER_INDEX;

            int actualDirectory = GetColorIndexOfFolderByFiles(di);
            List<int> temp = new List<int>(); 

            foreach (DirectoryInfo item in di.GetDirectories())
            {                
                int subDirectory = GetColorIndexOfFolderByFiles(item);
                temp.Add(subDirectory);
                if (item.GetDirectories().Length > 0)
                    temp.Add(GetColorIndexOfFolder(item));
            }
            for (int i = 0; i < temp.Count-1; i++)
            {
                if (temp[i] != temp[i + 1])
                    return YELLOW_FOLDER_INDEX;
            }
            return GetColorIndexOfFolderByFiles(di);
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
        public void FillFilterView(TreeView treeview1, FileInfo f)
        {            
            TreeNode newTn = new TreeNode("MainFilter");
            foreach (TreeNode tn in treeview1.Nodes)
            {
                Filter filter = (Filter)tn.Tag;
                 if (filter.Accepts(f, new Project()))
                      newTn = new TreeNode(String.Format("[Acc] " + tn.Text), GREEN_DOT_INDEX, GREEN_DOT_INDEX);
                 else
                      newTn = new TreeNode(String.Format("[Rej] " + tn.Text), RED_DOT_INDEX, RED_DOT_INDEX);
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

        private void B_BackUp_Click(object sender, EventArgs e)
        {
            Dictionary<MyFile,BackUpResult> backupInfo = new Dictionary<MyFile, BackUpResult>();
            try
            {
                foreach (string dirPath in Directory.GetDirectories(init_folder, "*", SearchOption.AllDirectories))
                {
                    foreach (var item in Files)
                    {
                        if (item.File.DirectoryName.Equals(dirPath) && item.ToBackUp)
                            Directory.CreateDirectory(dirPath.Replace(init_folder, destination_folder));
                    }                    
                }
                foreach (string newPath in Directory.GetFiles(init_folder, "*.*", SearchOption.AllDirectories))
                {
                    foreach (var item in Files)
                    {
                        if(item.File.FullName.Equals(newPath) && item.ToBackUp)
                        {
                            try
                            {
                                if (File.Exists(newPath.Replace(init_folder, destination_folder)))
                                {
                                    backupInfo.Add(item, BackUpResult.NOTNECESSARY);
                                }
                                else
                                {
                                    backupInfo.Add(item, BackUpResult.SUCCESSFULL);
                                    File.Copy(newPath, newPath.Replace(init_folder, destination_folder), true);
                                }
                                
                            }
                            catch (Exception)
                            {
                                backupInfo.Add(item, BackUpResult.ERROR);
                                throw;
                            }
                        }                            
                    }                    
                }
                BackUpResultForm backUpResult = new BackUpResultForm(backupInfo, init_folder);
                backUpResult.Show();
            }
            catch (Exception)
            {
                throw;
            }           
        }
    }
}