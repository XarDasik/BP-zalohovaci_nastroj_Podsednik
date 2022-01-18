
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
            this.SuspendLayout();
            // 
            // tvwFilters
            // 
            this.tvwFilters.ImageIndex = 0;
            this.tvwFilters.ImageList = this.dotList;
            this.tvwFilters.Location = new System.Drawing.Point(268, 324);
            this.tvwFilters.Name = "tvwFilters";
            this.tvwFilters.SelectedImageIndex = 0;
            this.tvwFilters.Size = new System.Drawing.Size(807, 185);
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
            this.lvw.HideSelection = false;
            this.lvw.Location = new System.Drawing.Point(268, 12);
            this.lvw.Name = "lvw";
            this.lvw.Size = new System.Drawing.Size(807, 306);
            this.lvw.SmallImageList = this.dotList;
            this.lvw.TabIndex = 4;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.View = System.Windows.Forms.View.List;
            this.lvw.SelectedIndexChanged += new System.EventHandler(this.lvw_SelectedIndexChanged);
            // 
            // tvw
            // 
            this.tvw.ImageIndex = 0;
            this.tvw.ImageList = this.tvwIml;
            this.tvw.Location = new System.Drawing.Point(12, 12);
            this.tvw.Name = "tvw";
            this.tvw.SelectedImageIndex = 0;
            this.tvw.Size = new System.Drawing.Size(250, 497);
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
            this.B_BackUp.Location = new System.Drawing.Point(13, 516);
            this.B_BackUp.Name = "B_BackUp";
            this.B_BackUp.Size = new System.Drawing.Size(249, 35);
            this.B_BackUp.TabIndex = 6;
            this.B_BackUp.Text = "Backup";
            this.B_BackUp.UseVisualStyleBackColor = true;
            this.B_BackUp.Click += new System.EventHandler(this.B_BackUp_Click);
            // 
            // FilterResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 554);
            this.Controls.Add(this.B_BackUp);
            this.Controls.Add(this.tvwFilters);
            this.Controls.Add(this.lvw);
            this.Controls.Add(this.tvw);
            this.Name = "FilterResult";
            this.Text = "tempForm";
            this.Load += new System.EventHandler(this.TempForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwFilters;
        private System.Windows.Forms.ListView lvw;
        private System.Windows.Forms.TreeView tvw;
        private System.Windows.Forms.ImageList dotList;
        private System.Windows.Forms.ImageList tvwIml;
        private System.Windows.Forms.Button B_BackUp;
    }
}