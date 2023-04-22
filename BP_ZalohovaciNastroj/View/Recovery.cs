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
    public partial class Recovery : Form
    {
        public Recovery()
        {
            InitializeComponent();
        }

        private void B_RootPathLoader_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TB_RootPath.Text = folderBrowserDialog1.SelectedPath;
            }
            if (!Directory.Exists(TB_RootPath.Text))
            {
                MessageBox.Show("Root path doesn't exist. Please select valid path.");
                return;
            }
            ListDirectory(TV_FileSystem, TB_RootPath.Text);
        }

        private void B_DestionationPathLoader_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TB_DestinationPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private static void ListDirectory(TreeView treeView, string path)
        {
            ImageList imageList = treeView.ImageList;
            Dictionary<string, int> imageIndexs = new Dictionary<string, int>();
            imageIndexs.Add("folder", 0);
            treeView.Nodes.Clear();

            var stack = new Stack<TreeNode>();
            var rootDirectory = new DirectoryInfo(path);
            var node = new TreeNode(rootDirectory.Name) { Tag = rootDirectory };
            node.NodeFont = new Font(TreeView.DefaultFont, FontStyle.Bold);
            stack.Push(node);

            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                var directoryInfo = (DirectoryInfo)currentNode.Tag;
                foreach (var directory in directoryInfo.GetDirectories())
                {
                    var childDirectoryNode = new TreeNode(directory.Name) { Tag = directory };
                    childDirectoryNode.NodeFont = new Font(TreeView.DefaultFont, FontStyle.Bold);
                    childDirectoryNode.ImageIndex = 0;
                    childDirectoryNode.SelectedImageIndex = 0;
                    currentNode.Nodes.Add(childDirectoryNode);
                    stack.Push(childDirectoryNode);
                }
                foreach (var file in directoryInfo.GetFiles())
                {
                    bool addFile = true;
                    foreach (TreeNode item in currentNode.Nodes)
                    {
                        if (file.Name.Contains("_") && item.Text.Contains('.'))
                        {
                            if (item.Text.Substring(0, item.Text.LastIndexOf('.')).Equals(file.Name.Substring(0, file.Name.LastIndexOf('_'))) && file.Extension.Equals(item.Text.Substring(item.Text.LastIndexOf('.'))) && IsTextDateTime(file.Name.Substring(file.Name.LastIndexOf('_') +1, file.Name.LastIndexOf('.') - file.Name.LastIndexOf('_') - 1)))
                            {
                                addFile = false;
                                break;
                            }
                        }                  
                    }
                    if (addFile)
                    {
                        TreeNode tn = new TreeNode(file.Name);
                        tn.Tag = file;
                        if (!imageIndexs.ContainsKey(file.Extension))
                        {
                            imageList.Images.Add(FromIconToBitmap(Icon.ExtractAssociatedIcon(file.FullName)));
                            imageIndexs.Add(file.Extension, imageList.Images.Count-1);
                            tn.ImageIndex = imageList.Images.Count - 1;
                            tn.SelectedImageIndex = imageList.Images.Count - 1;
                        }
                        else
                        {
                            tn.ImageIndex = imageIndexs[file.Extension];
                            tn.SelectedImageIndex = imageIndexs[file.Extension];
                        }                                              
                        currentNode.Nodes.Add(tn);
                    }                        
                }                    
            }
            treeView.Nodes.Add(node);
        }
        private static bool IsTextDateTime(string text)
        {
            Regex rx = new Regex("^\\d{4}-\\d{2}-\\d{2}-\\d{2}-\\d{2}-\\d{2}$");
            MatchCollection matches = rx.Matches(text);
            if (matches.Count > 0)
                return true;
            else return false;
        }
        
        public static Bitmap FromIconToBitmap(Icon icon)
        {
            Bitmap bmp = new Bitmap(icon.Width, icon.Height);
            using (Graphics gp = Graphics.FromImage(bmp))
            {
                gp.Clear(Color.Transparent);
                gp.DrawIcon(icon, new Rectangle(0, 0, icon.Width, icon.Height));
            }
            return bmp;
        }
        //https://stackoverflow.com/questions/54657948/black-background-on-file-icon
        //https://www.c-sharpcorner.com/blogs/convert-an-image-to-base64-string-and-base64-string-to-image
        private void TV_FileSystem_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked)
            {
                foreach (TreeNode item in e.Node.Nodes)
                {
                    item.Checked = true;
                }
            }
            else
            {
                foreach (TreeNode item in e.Node.Nodes)
                {
                    item.Checked = false;
                }
            }
        }
        private void B_Recovery_Click(object sender, EventArgs e)
        {            
            List<FileInfo> filesToRecovery = new List<FileInfo>();
            List<String> originalNamesOfFiles = new List<String>();

            FindCheckedNodes(filesToRecovery, TV_FileSystem.Nodes);
            FillOriginalNamesOfFiles(originalNamesOfFiles, filesToRecovery);
            FillFilesByDate(filesToRecovery, DTP_Date.Value);

            foreach (string dirPath in Directory.GetDirectories(TB_RootPath.Text, "*", SearchOption.AllDirectories))
            {
                foreach (var item in filesToRecovery)
                {
                    if(item != null)
                        if(item.DirectoryName.Equals(dirPath))
                            Directory.CreateDirectory(dirPath.Replace(TB_RootPath.Text, TB_DestinationPath.Text));
                }
            }
            int index = 0;
            Dictionary<FileInfo, Result> result = new Dictionary<FileInfo, Result>();
            Dictionary<FileInfo, bool> filesAlreadyExists = new Dictionary<FileInfo, bool>();
            foreach (FileInfo file in filesToRecovery)
            {
                if (file != null)
                {
                    string test = file.FullName.Replace(TB_RootPath.Text, TB_DestinationPath.Text).Substring(0, file.FullName.Replace(TB_RootPath.Text, TB_DestinationPath.Text).LastIndexOf('\\') + 1) + originalNamesOfFiles[index];
                    if (!File.Exists(test))
                    {
                        try
                        {
                            File.Copy(file.FullName, file.FullName.Replace(TB_RootPath.Text, TB_DestinationPath.Text).Substring(0, file.FullName.Replace(TB_RootPath.Text, TB_DestinationPath.Text).LastIndexOf('\\') + 1) + originalNamesOfFiles[index++], false);
                            result.Add(file, Result.SUCCESSFULL);
                        }
                        catch (Exception)
                        {
                            result.Add(file, Result.ERROR);
                            throw;
                        }                        
                        
                    }
                    else
                    {
                        filesAlreadyExists.Add(file, false);
                    }                        
                }
            }
            if (filesAlreadyExists.Count > 0) 
            {
                CopyFileDialog copyFileDialog = new CopyFileDialog(filesAlreadyExists);
                if (copyFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    var files = copyFileDialog.filesToRecovery;
                    foreach (var item in files)
                    {
                        if (item.Value == true)
                        {
                            try
                            {
                                File.Copy(item.Key.FullName, item.Key.FullName.Replace(TB_RootPath.Text, TB_DestinationPath.Text).Substring(0, item.Key.FullName.Replace(TB_RootPath.Text, TB_DestinationPath.Text).LastIndexOf('\\') + 1) + originalNamesOfFiles[index++], true);
                                result.Add(item.Key, Result.SUCCESSFULL);
                            }
                            catch (Exception)
                            {
                                result.Add(item.Key, Result.ERROR);
                                throw;
                            }
                        }
                        else
                        {
                            result.Add(item.Key, Result.NOTNECESSARY);
                        }
                    }
                }
            }
            RecoveryResult recoveryResult = new RecoveryResult(result, TB_RootPath.Text);
            recoveryResult.Show();
          
        }
        private void FillOriginalNamesOfFiles(List<String> originalNamesOfFiles, List<FileInfo> filesToRecovery)
        {
            foreach (var item in filesToRecovery)
            {
                originalNamesOfFiles.Add(item.Name);
            }
        }
        private void FillFilesByDate(List<FileInfo> files, DateTime dateTime)
        {
            for (int i = 0; i < files.Count; i++)
            {
                files[i] = FindTheFileTheNewestByDateTime(files[i], files[i].Directory, dateTime);
            }
        }
        private FileInfo FindTheFileTheNewestByDateTime(FileInfo fileinfo, DirectoryInfo dir, DateTime dateTime)
        {
            FileInfo theNewestFile;
            if (fileinfo.CreationTime < dateTime)
                theNewestFile = fileinfo;
            else if (FindSameFilesInFolder(fileinfo, dir).Count > 0)
                theNewestFile = FindSameFilesInFolder(fileinfo, dir)[0];
            else
                return null;
            bool wasChanged = false;
            foreach (var file in FindSameFilesInFolder(fileinfo, dir))
            {
                if (file.CreationTime < dateTime && DateTime.Compare(file.CreationTime, theNewestFile.CreationTime) > 0)
                {
                    theNewestFile = file;
                    wasChanged = true;
                }
            }
            if (theNewestFile.CreationTime < dateTime)
                return theNewestFile;
            else if (!wasChanged && FindSameFilesInFolder(fileinfo, dir).Count > 1)
                theNewestFile = null;

            return theNewestFile;

        }
        private List<FileInfo> FindSameFilesInFolder(FileInfo fileinfo, DirectoryInfo dir)
        {
            List<FileInfo> files = new List<FileInfo>();
            foreach (FileInfo file in dir.GetFiles())
            {
                if (file.Name.Contains("_"))
                {
                    if (Path.GetFileNameWithoutExtension(fileinfo.FullName).Equals(file.Name.Substring(0, file.Name.LastIndexOf('_'))))
                    {
                        files.Add(file);
                    }
                }
                
            }
            return files;
        }
        private void FindCheckedNodes(List<FileInfo> filesToRecovery, TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
               if(node.Tag is FileInfo)
                    if (node.Checked) filesToRecovery.Add((FileInfo)node.Tag);

                FindCheckedNodes(filesToRecovery, node.Nodes);
            }
            
        }
    }
}
