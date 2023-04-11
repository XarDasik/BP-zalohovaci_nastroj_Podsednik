
namespace BP_ZalohovaciNastroj.View
{
    partial class NewProjectDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProjectDialog));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbSaveLocation = new System.Windows.Forms.TextBox();
            this.tbNameProject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_DestionationPathLoader = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.tbSaveLocation);
            this.panel2.Controls.Add(this.tbNameProject);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.B_DestionationPathLoader);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 148);
            this.panel2.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancel.Location = new System.Drawing.Point(296, 102);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 33);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOk.Location = new System.Drawing.Point(182, 102);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(108, 33);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbSaveLocation
            // 
            this.tbSaveLocation.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSaveLocation.Location = new System.Drawing.Point(148, 37);
            this.tbSaveLocation.Name = "tbSaveLocation";
            this.tbSaveLocation.Size = new System.Drawing.Size(339, 18);
            this.tbSaveLocation.TabIndex = 3;
            // 
            // tbNameProject
            // 
            this.tbNameProject.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNameProject.Location = new System.Drawing.Point(148, 11);
            this.tbNameProject.Name = "tbNameProject";
            this.tbNameProject.Size = new System.Drawing.Size(373, 18);
            this.tbNameProject.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the project:";
            // 
            // B_DestionationPathLoader
            // 
            this.B_DestionationPathLoader.BackColor = System.Drawing.Color.White;
            this.B_DestionationPathLoader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_DestionationPathLoader.BackgroundImage")));
            this.B_DestionationPathLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_DestionationPathLoader.Location = new System.Drawing.Point(493, 33);
            this.B_DestionationPathLoader.Name = "B_DestionationPathLoader";
            this.B_DestionationPathLoader.Size = new System.Drawing.Size(28, 26);
            this.B_DestionationPathLoader.TabIndex = 7;
            this.B_DestionationPathLoader.UseVisualStyleBackColor = false;
            this.B_DestionationPathLoader.Click += new System.EventHandler(this.B_DestionationPathLoader_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(52, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Save location:";
            // 
            // NewProjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 148);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(564, 187);
            this.MinimumSize = new System.Drawing.Size(564, 187);
            this.Name = "NewProjectDialog";
            this.ShowIcon = false;
            this.Text = "New project";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbSaveLocation;
        private System.Windows.Forms.TextBox tbNameProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_DestionationPathLoader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}