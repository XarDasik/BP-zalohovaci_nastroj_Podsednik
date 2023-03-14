
namespace BP_ZalohovaciNastroj
{
    partial class FilterResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterResult));
            this.tvwFilters = new System.Windows.Forms.TreeView();
            this.dotList = new System.Windows.Forms.ImageList(this.components);
            this.lvw = new System.Windows.Forms.ListView();
            this.tvw = new System.Windows.Forms.TreeView();
            this.tvwIml = new System.Windows.Forms.ImageList(this.components);
            this.B_BackUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwFilters
            // 
            this.tvwFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwFilters.ImageIndex = 0;
            this.tvwFilters.ImageList = this.dotList;
            this.tvwFilters.Location = new System.Drawing.Point(8, 13);
            this.tvwFilters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvwFilters.Name = "tvwFilters";
            this.tvwFilters.SelectedImageIndex = 0;
            this.tvwFilters.Size = new System.Drawing.Size(610, 120);
            this.tvwFilters.TabIndex = 5;
            // 
            // dotList
            // 
            this.dotList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dotList.ImageStream")));
            this.dotList.TransparentColor = System.Drawing.Color.Transparent;
            this.dotList.Images.SetKeyName(0, "reddot.png");
            this.dotList.Images.SetKeyName(1, "greendot.png");
            // 
            // lvw
            // 
            this.lvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw.HideSelection = false;
            this.lvw.Location = new System.Drawing.Point(8, 16);
            this.lvw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvw.Name = "lvw";
            this.lvw.Size = new System.Drawing.Size(610, 224);
            this.lvw.SmallImageList = this.dotList;
            this.lvw.TabIndex = 4;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.View = System.Windows.Forms.View.List;
            this.lvw.SelectedIndexChanged += new System.EventHandler(this.lvw_SelectedIndexChanged);
            // 
            // tvw
            // 
            this.tvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvw.ImageIndex = 0;
            this.tvw.ImageList = this.tvwIml;
            this.tvw.Location = new System.Drawing.Point(8, 16);
            this.tvw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvw.Name = "tvw";
            this.tvw.SelectedImageIndex = 0;
            this.tvw.Size = new System.Drawing.Size(296, 437);
            this.tvw.TabIndex = 3;
            this.tvw.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvw_BeforeExpand);
            this.tvw.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvw_AfterSelect);
            // 
            // tvwIml
            // 
            this.tvwIml.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tvwIml.ImageStream")));
            this.tvwIml.TransparentColor = System.Drawing.Color.Transparent;
            this.tvwIml.Images.SetKeyName(0, "red.png");
            this.tvwIml.Images.SetKeyName(1, "yellow.png");
            this.tvwIml.Images.SetKeyName(2, "green.png");
            this.tvwIml.Images.SetKeyName(3, "gray.png");
            this.tvwIml.Images.SetKeyName(4, "error.png");
            // 
            // B_BackUp
            // 
            this.B_BackUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B_BackUp.Location = new System.Drawing.Point(4, 4);
            this.B_BackUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B_BackUp.Name = "B_BackUp";
            this.B_BackUp.Size = new System.Drawing.Size(304, 17);
            this.B_BackUp.TabIndex = 6;
            this.B_BackUp.Text = "Backup";
            this.B_BackUp.UseVisualStyleBackColor = true;
            this.B_BackUp.Click += new System.EventHandler(this.B_BackUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anonymous Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(5, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "File System:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(941, 484);
            this.splitContainer1.SplitterDistance = 312;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tvw);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 16, 8, 6);
            this.panel1.Size = new System.Drawing.Size(312, 459);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.B_BackUp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 459);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Size = new System.Drawing.Size(312, 25);
            this.panel2.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(626, 484);
            this.splitContainer2.SplitterDistance = 246;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lvw);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8, 16, 8, 6);
            this.panel3.Size = new System.Drawing.Size(626, 246);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Anonymous Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Files:";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.tvwFilters);
            this.splitContainer3.Panel1.Padding = new System.Windows.Forms.Padding(8, 13, 8, 3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(2, 0, 8, 0);
            this.splitContainer3.Size = new System.Drawing.Size(626, 235);
            this.splitContainer3.SplitterDistance = 136;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Anonymous Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(5, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Filter result:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FilterResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 484);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(604, 340);
            this.Name = "FilterResult";
            this.Text = "Filter result";
            this.Load += new System.EventHandler(this.TempForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwFilters;
        private System.Windows.Forms.ListView lvw;
        private System.Windows.Forms.TreeView tvw;
        private System.Windows.Forms.ImageList dotList;
        private System.Windows.Forms.ImageList tvwIml;
        private System.Windows.Forms.Button B_BackUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}