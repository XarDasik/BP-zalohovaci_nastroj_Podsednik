
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 189);
            this.panel2.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancel.Location = new System.Drawing.Point(395, 132);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 44);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOk.Location = new System.Drawing.Point(243, 132);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(144, 44);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbSaveLocation
            // 
            this.tbSaveLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbSaveLocation.Location = new System.Drawing.Point(197, 49);
            this.tbSaveLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSaveLocation.Name = "tbSaveLocation";
            this.tbSaveLocation.Size = new System.Drawing.Size(451, 23);
            this.tbSaveLocation.TabIndex = 3;
            // 
            // tbNameProject
            // 
            this.tbNameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbNameProject.Location = new System.Drawing.Point(197, 15);
            this.tbNameProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNameProject.Name = "tbNameProject";
            this.tbNameProject.Size = new System.Drawing.Size(496, 23);
            this.tbNameProject.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the project:";
            // 
            // B_DestionationPathLoader
            // 
            this.B_DestionationPathLoader.BackColor = System.Drawing.Color.White;
            this.B_DestionationPathLoader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_DestionationPathLoader.BackgroundImage")));
            this.B_DestionationPathLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_DestionationPathLoader.Location = new System.Drawing.Point(657, 44);
            this.B_DestionationPathLoader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B_DestionationPathLoader.Name = "B_DestionationPathLoader";
            this.B_DestionationPathLoader.Size = new System.Drawing.Size(37, 34);
            this.B_DestionationPathLoader.TabIndex = 7;
            this.B_DestionationPathLoader.UseVisualStyleBackColor = false;
            this.B_DestionationPathLoader.Click += new System.EventHandler(this.B_DestionationPathLoader_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(79, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Save location:";
            // 
            // NewProjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 189);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(747, 236);
            this.MinimumSize = new System.Drawing.Size(747, 236);
            this.Name = "NewProjectDialog";
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