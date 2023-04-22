
namespace BP_ZalohovaciNastroj
{
    partial class ShowProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowProject));
            this.lbProjects = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnLoadProject = new System.Windows.Forms.Button();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBackup = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlNewProject = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProjects
            // 
            this.lbProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProjects.FormattingEnabled = true;
            this.lbProjects.ItemHeight = 12;
            this.lbProjects.Location = new System.Drawing.Point(2, 2);
            this.lbProjects.Margin = new System.Windows.Forms.Padding(2);
            this.lbProjects.Name = "lbProjects";
            this.lbProjects.Size = new System.Drawing.Size(110, 367);
            this.lbProjects.TabIndex = 0;
            this.lbProjects.SelectedIndexChanged += new System.EventHandler(this.lbProjects_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlBackup);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(787, 469);
            this.splitContainer1.SplitterDistance = 114;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeleteProject);
            this.panel3.Controls.Add(this.btnLoadProject);
            this.panel3.Controls.Add(this.btnNewProject);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 377);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(114, 92);
            this.panel3.TabIndex = 3;
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteProject.Location = new System.Drawing.Point(4, 56);
            this.btnDeleteProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Padding = new System.Windows.Forms.Padding(2);
            this.btnDeleteProject.Size = new System.Drawing.Size(106, 26);
            this.btnDeleteProject.TabIndex = 2;
            this.btnDeleteProject.Text = "Delete project";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // btnLoadProject
            // 
            this.btnLoadProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoadProject.Location = new System.Drawing.Point(4, 30);
            this.btnLoadProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadProject.Name = "btnLoadProject";
            this.btnLoadProject.Padding = new System.Windows.Forms.Padding(2);
            this.btnLoadProject.Size = new System.Drawing.Size(106, 26);
            this.btnLoadProject.TabIndex = 1;
            this.btnLoadProject.Text = "Load Project";
            this.btnLoadProject.UseVisualStyleBackColor = true;
            this.btnLoadProject.Click += new System.EventHandler(this.btnLoadProject_Click);
            // 
            // btnNewProject
            // 
            this.btnNewProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewProject.Location = new System.Drawing.Point(4, 4);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(106, 26);
            this.btnNewProject.TabIndex = 3;
            this.btnNewProject.Text = "New project";
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbProjects);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 85);
            this.panel2.Size = new System.Drawing.Size(114, 454);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlNewProject);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 15);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projects:";
            // 
            // pnlBackup
            // 
            this.pnlBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackup.Location = new System.Drawing.Point(0, 4);
            this.pnlBackup.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBackup.Name = "pnlBackup";
            this.pnlBackup.Size = new System.Drawing.Size(670, 465);
            this.pnlBackup.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Backup Project files|*.data";
            // 
            // pnlNewProject
            // 
            this.pnlNewProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNewProject.Location = new System.Drawing.Point(0, 0);
            this.pnlNewProject.Name = "pnlNewProject";
            this.pnlNewProject.Size = new System.Drawing.Size(114, 15);
            this.pnlNewProject.TabIndex = 0;
            // 
            // ShowProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 469);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowProject";
            this.Text = "Show project";
            this.VisibleChanged += new System.EventHandler(this.ShowProject_VisibleChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbProjects;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBackup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLoadProject;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Panel pnlNewProject;
    }
}