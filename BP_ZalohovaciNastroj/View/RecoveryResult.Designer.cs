﻿
namespace BP_ZalohovaciNastroj
{
    partial class RecoveryResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoveryResult));
            this.tvw = new System.Windows.Forms.TreeView();
            this.tvwIml = new System.Windows.Forms.ImageList(this.components);
            this.lvw = new System.Windows.Forms.ListView();
            this.dotList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvw
            // 
            this.tvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvw.ImageIndex = 0;
            this.tvw.ImageList = this.tvwIml;
            this.tvw.Location = new System.Drawing.Point(10, 22);
            this.tvw.Name = "tvw";
            this.tvw.SelectedImageIndex = 0;
            this.tvw.Size = new System.Drawing.Size(207, 384);
            this.tvw.TabIndex = 5;
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
            this.tvwIml.Images.SetKeyName(5, "image3.png");
            // 
            // lvw
            // 
            this.lvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw.HideSelection = false;
            this.lvw.Location = new System.Drawing.Point(10, 22);
            this.lvw.Name = "lvw";
            this.lvw.Size = new System.Drawing.Size(549, 384);
            this.lvw.SmallImageList = this.dotList;
            this.lvw.TabIndex = 6;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.View = System.Windows.Forms.View.List;
            this.lvw.SelectedIndexChanged += new System.EventHandler(this.lvw_SelectedIndexChanged);
            // 
            // dotList
            // 
            this.dotList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dotList.ImageStream")));
            this.dotList.TransparentColor = System.Drawing.Color.Transparent;
            this.dotList.Images.SetKeyName(0, "reddot.png");
            this.dotList.Images.SetKeyName(1, "greendot.png");
            this.dotList.Images.SetKeyName(2, "gray_dot.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 415);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tvw);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 22, 10, 9);
            this.panel1.Size = new System.Drawing.Size(227, 415);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Anonymous Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Folders:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDateTime);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lvw);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 22, 10, 9);
            this.panel2.Size = new System.Drawing.Size(569, 415);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anonymous Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Files:";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Anonymous Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateTime.Location = new System.Drawing.Point(62, 6);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 13);
            this.lblDateTime.TabIndex = 11;
            // 
            // RecoveryResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "RecoveryResult";
            this.Text = "RecoveryResult";
            this.Load += new System.EventHandler(this.RecoveryResult_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvw;
        private System.Windows.Forms.ImageList tvwIml;
        private System.Windows.Forms.ListView lvw;
        private System.Windows.Forms.ImageList dotList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateTime;
    }
}