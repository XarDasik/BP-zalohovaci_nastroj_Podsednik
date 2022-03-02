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
    public partial class BackUpResultForm : Form
    {
        Dictionary<MyFile, BackUpResult> notBackUped;
        string init_folder;

        private const int RED_DOT_INDEX = 0;
        private const int GREEN_DOT_INDEX = 1;
        private const int GRAY_DOT_INDEX = 2;

        private const int RED_FOLDER_INDEX = 0;
        private const int YELLOW_FOLDER_INDEX = 1;
        private const int GREEN_FOLDER_INDEX = 2;
        private const int EMPTY_FOLDER_INDEX = 3;
        private const int ERROR_FOLDER_INDEX = 4;

        public BackUpResultForm(Dictionary<MyFile, BackUpResult> notBackUped, string init_folder)
        {
            InitializeComponent();
            this.notBackUped = notBackUped;
            this.init_folder = init_folder;
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
                        node.ImageIndex = YELLOW_FOLDER_INDEX;

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
                    node.ImageIndex = YELLOW_FOLDER_INDEX;
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
                if(getColorOfFile(f) != -1)
                {
                    ListViewItem lwi = new ListViewItem(f.Name);
                    lwi.Tag = f;
                    lwi.ImageIndex = getColorOfFile(f);
                    lvw.Items.Add(lwi);
                }
                
            }
        }
        private int getColorOfFile(FileInfo f)
        {
            foreach (var item in notBackUped)
            {
                if (item.Key.File.FullName.Equals(f.FullName))
                {
                    if (item.Value == BackUpResult.ERROR)
                        return RED_DOT_INDEX;
                    else if (item.Value == BackUpResult.NOTNECESSARY) return GRAY_DOT_INDEX;
                    else if (item.Value == BackUpResult.SUCCESSFULL) return GREEN_DOT_INDEX;
                    else
                        return -1;

                }
            }
            return -1;
        }

        private void lvw_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BackUpResultForm_Load(object sender, EventArgs e)
        {
            InitTvw();
        }
    }
}
