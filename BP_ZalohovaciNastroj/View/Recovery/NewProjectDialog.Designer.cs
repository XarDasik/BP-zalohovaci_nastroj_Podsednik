
namespace BP_ZalohovaciNastroj
{
    partial class Recovery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recovery));
            this.label1 = new System.Windows.Forms.Label();
            this.TB_RootPath = new System.Windows.Forms.TextBox();
            this.B_RootPathLoader = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_DestinationPath = new System.Windows.Forms.TextBox();
            this.B_DestionationPathLoader = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.B_Recovery = new System.Windows.Forms.Button();
            this.TV_FileSystem = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblForTreeView = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Root Path:";
            // 
            // TB_RootPath
            // 
            this.TB_RootPath.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_RootPath.Location = new System.Drawing.Point(124, 17);
            this.TB_RootPath.Name = "TB_RootPath";
            this.TB_RootPath.Size = new System.Drawing.Size(358, 18);
            this.TB_RootPath.TabIndex = 1;
            // 
            // B_RootPathLoader
            // 
            this.B_RootPathLoader.BackColor = System.Drawing.Color.White;
            this.B_RootPathLoader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_RootPathLoader.BackgroundImage")));
            this.B_RootPathLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_RootPathLoader.Location = new System.Drawing.Point(488, 12);
            this.B_RootPathLoader.Name = "B_RootPathLoader";
            this.B_RootPathLoader.Size = new System.Drawing.Size(28, 28);
            this.B_RootPathLoader.TabIndex = 3;
            this.B_RootPathLoader.UseVisualStyleBackColor = false;
            this.B_RootPathLoader.Click += new System.EventHandler(this.B_RootPathLoader_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination Path:";
            // 
            // TB_DestinationPath
            // 
            this.TB_DestinationPath.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_DestinationPath.Location = new System.Drawing.Point(124, 50);
            this.TB_DestinationPath.Name = "TB_DestinationPath";
            this.TB_DestinationPath.Size = new System.Drawing.Size(358, 18);
            this.TB_DestinationPath.TabIndex = 5;
            // 
            // B_DestionationPathLoader
            // 
            this.B_DestionationPathLoader.BackColor = System.Drawing.Color.White;
            this.B_DestionationPathLoader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_DestionationPathLoader.BackgroundImage")));
            this.B_DestionationPathLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_DestionationPathLoader.Location = new System.Drawing.Point(488, 45);
            this.B_DestionationPathLoader.Name = "B_DestionationPathLoader";
            this.B_DestionationPathLoader.Size = new System.Drawing.Size(28, 28);
            this.B_DestionationPathLoader.TabIndex = 6;
            this.B_DestionationPathLoader.UseVisualStyleBackColor = false;
            this.B_DestionationPathLoader.Click += new System.EventHandler(this.B_DestionationPathLoader_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DTP_Date);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TB_RootPath);
            this.panel1.Controls.Add(this.B_DestionationPathLoader);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TB_DestinationPath);
            this.panel1.Controls.Add(this.B_RootPathLoader);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 83);
            this.panel1.TabIndex = 7;
            // 
            // DTP_Date
            // 
            this.DTP_Date.CustomFormat = "dd.MM.yyyy HH:mm";
            this.DTP_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Date.Location = new System.Drawing.Point(628, 17);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(162, 18);
            this.DTP_Date.TabIndex = 7;
            this.DTP_Date.Value = new System.DateTime(2022, 1, 13, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Recovery to date:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(805, 374);
            this.panel2.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.B_Recovery);
            this.panel4.Controls.Add(this.TV_FileSystem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 52);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5, 5, 5, 35);
            this.panel4.Size = new System.Drawing.Size(785, 312);
            this.panel4.TabIndex = 2;
            // 
            // B_Recovery
            // 
            this.B_Recovery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Recovery.Location = new System.Drawing.Point(615, 283);
            this.B_Recovery.Name = "B_Recovery";
            this.B_Recovery.Size = new System.Drawing.Size(162, 23);
            this.B_Recovery.TabIndex = 7;
            this.B_Recovery.Text = "Recovery selected files";
            this.B_Recovery.UseVisualStyleBackColor = true;
            this.B_Recovery.Click += new System.EventHandler(this.B_Recovery_Click);
            // 
            // TV_FileSystem
            // 
            this.TV_FileSystem.CheckBoxes = true;
            this.TV_FileSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TV_FileSystem.ImageIndex = 0;
            this.TV_FileSystem.ImageList = this.imageList1;
            this.TV_FileSystem.Location = new System.Drawing.Point(5, 5);
            this.TV_FileSystem.Name = "TV_FileSystem";
            this.TV_FileSystem.SelectedImageIndex = 0;
            this.TV_FileSystem.Size = new System.Drawing.Size(775, 272);
            this.TV_FileSystem.TabIndex = 0;
            this.TV_FileSystem.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TV_FileSystem_AfterCheck);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblForTreeView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(785, 42);
            this.panel3.TabIndex = 1;
            // 
            // lblForTreeView
            // 
            this.lblForTreeView.AutoSize = true;
            this.lblForTreeView.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblForTreeView.Location = new System.Drawing.Point(3, 23);
            this.lblForTreeView.Name = "lblForTreeView";
            this.lblForTreeView.Size = new System.Drawing.Size(155, 12);
            this.lblForTreeView.TabIndex = 0;
            this.lblForTreeView.Text = "Select folders and files:";
            // 
            // Recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Recovery";
            this.Text = "Recovery";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_RootPath;
        private System.Windows.Forms.Button B_RootPathLoader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_DestinationPath;
        private System.Windows.Forms.Button B_DestionationPathLoader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblForTreeView;
        private System.Windows.Forms.TreeView TV_FileSystem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button B_Recovery;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
    }
}