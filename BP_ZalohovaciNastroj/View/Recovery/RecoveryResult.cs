using BP_ZalohovaciNastroj.View.Recovery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_ZalohovaciNastroj
{
    public partial class RecoveryResult : Form
    {
        Dictionary<FileInfo, Result> result = new Dictionary<FileInfo, Result>();
        string init_folder;

        private const int RED_DOT_INDEX = 0;
        private const int GREEN_DOT_INDEX = 1;
        private const int GRAY_DOT_INDEX = 2;

        private const int RED_FOLDER_INDEX = 0;
        private const int YELLOW_FOLDER_INDEX = 1;
        private const int GREEN_FOLDER_INDEX = 2;
        private const int EMPTY_FOLDER_INDEX = 3;
        private const int ERROR_FOLDER_INDEX = 4;
        private const int GRAY_FOLDER_INDEX = 5;
        
        public RecoveryResult(Dictionary<FileInfo, Result> result, string init_folder)
        {
            this.result = result;
            this.init_folder = init_folder;
            InitializeComponent();
            RecoveryLegend recoveryLegend = new RecoveryLegend();
            recoveryLegend.TopLevel = false;
            recoveryLegend.FormBorderStyle = FormBorderStyle.None;
            recoveryLegend.Dock = DockStyle.Fill;
            recoveryLegend.Show();
            splitContainer2.Panel2.Controls.Add(recoveryLegend);

        }
        private void InitTvw()
        {
            DirectoryInfo rootDirectoryInfo = new DirectoryInfo(init_folder);
            TreeNode mainNode = new TreeNode(rootDirectoryInfo.Name);
            mainNode.ImageIndex = GetColorIndexOfFolder(rootDirectoryInfo);
            mainNode.Tag = rootDirectoryInfo;
            mainNode.SelectedImageIndex = mainNode.ImageIndex;
            tvw.Nodes.Add(mainNode);            

            var folders = System.IO.Directory.GetDirectories(init_folder);
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
                tvw.Nodes[0].Nodes.Add(node);
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
                return GetColorIndexOfFolderByFiles(di);
            }
                
        }
        private int GetColorIndexOfFolderByFiles(DirectoryInfo di)
        {
            if (di.GetFiles().Count() == 0)
                return EMPTY_FOLDER_INDEX;

            int recovered = 0;
            int notRecovered = 0;
            int countOfFiles = 0;
            foreach (FileInfo f in di.GetFiles())
            {
                if (getColorOfFile(f) == GREEN_DOT_INDEX)
                {
                    recovered++;
                    countOfFiles++;
                }
                else if (getColorOfFile(f) == GRAY_DOT_INDEX)
                {
                    notRecovered++;
                    countOfFiles++;
                }
            }

            if (notRecovered == countOfFiles)
                return GRAY_FOLDER_INDEX;
            if (recovered == 0 && countOfFiles > 0 && notRecovered == 0)
                return RED_FOLDER_INDEX;
            else if (recovered < countOfFiles)
                return YELLOW_FOLDER_INDEX;
            else
                return GREEN_FOLDER_INDEX;
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
                string name = f.Name;
                if (getColorOfFile(f) != -1)
                {
                    if (f.Name.Contains("_")) 
                    {
                        if (IsTextDateTime(f.Name.Substring(f.Name.LastIndexOf('_') + 1, f.Name.LastIndexOf('.') - f.Name.LastIndexOf('_') - 1)))
                            name = f.Name.Substring(0, f.Name.LastIndexOf("_")) + f.Extension;
                    }
                    ListViewItem lwi = new ListViewItem(String.Format("{0} ({1})", name, f.CreationTime.ToString("dd.MM.yyyy HH:mm")));
                    lwi.Tag = f;
                    lwi.ImageIndex = getColorOfFile(f);
                    lvw.Items.Add(lwi);
                }
            }
        }
        private static bool IsTextDateTime(string text)
        {
            Regex rx = new Regex("^\\d{4}-\\d{2}-\\d{2}-\\d{2}-\\d{2}-\\d{2}$");
            MatchCollection matches = rx.Matches(text);
            if (matches.Count > 0)
                return true;
            else return false;
        }
        private int getColorOfFile(FileInfo f)
        {
            foreach (var item in result)
            {
                if (item.Key.FullName.Equals(f.FullName))
                {
                    if (item.Value == Result.ERROR)
                        return RED_DOT_INDEX;
                    else if (item.Value == Result.NOTNECESSARY) return GRAY_DOT_INDEX;
                    else if (item.Value == Result.SUCCESSFULL) return GREEN_DOT_INDEX;
                    else
                        return -1;
                }
            }
            return -1;
        }

        private void RecoveryResult_Load(object sender, EventArgs e)
        {
            InitTvw();
        }
    }
}
