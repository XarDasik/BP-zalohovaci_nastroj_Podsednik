
namespace BP_ZalohovaciNastroj.View.Backup.Legends
{
    partial class BackupLegendResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupLegendResult));
            this.label7 = new System.Windows.Forms.Label();
            this.pb_gray = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_green = new System.Windows.Forms.PictureBox();
            this.pb_red = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pb_yellow = new System.Windows.Forms.PictureBox();
            this.tvwIml = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pb_error = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_error)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Empty Folder";
            // 
            // pb_gray
            // 
            this.pb_gray.Location = new System.Drawing.Point(306, 9);
            this.pb_gray.Name = "pb_gray";
            this.pb_gray.Size = new System.Drawing.Size(17, 13);
            this.pb_gray.TabIndex = 34;
            this.pb_gray.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "All Subfolders and Files have been backuped";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Not backuped Folders or Files";
            // 
            // pb_green
            // 
            this.pb_green.Location = new System.Drawing.Point(5, 32);
            this.pb_green.Name = "pb_green";
            this.pb_green.Size = new System.Drawing.Size(17, 13);
            this.pb_green.TabIndex = 32;
            this.pb_green.TabStop = false;
            // 
            // pb_red
            // 
            this.pb_red.Location = new System.Drawing.Point(5, 9);
            this.pb_red.Name = "pb_red";
            this.pb_red.Size = new System.Drawing.Size(17, 13);
            this.pb_red.TabIndex = 28;
            this.pb_red.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Partially Folders and Files have been backuped";
            // 
            // pb_yellow
            // 
            this.pb_yellow.Location = new System.Drawing.Point(5, 54);
            this.pb_yellow.Name = "pb_yellow";
            this.pb_yellow.Size = new System.Drawing.Size(17, 13);
            this.pb_yellow.TabIndex = 30;
            this.pb_yellow.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Error";
            // 
            // pb_error
            // 
            this.pb_error.Location = new System.Drawing.Point(306, 32);
            this.pb_error.Name = "pb_error";
            this.pb_error.Size = new System.Drawing.Size(17, 13);
            this.pb_error.TabIndex = 36;
            this.pb_error.TabStop = false;
            // 
            // BackupLegendResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 76);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pb_gray);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pb_green);
            this.Controls.Add(this.pb_red);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pb_yellow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_error);
            this.Name = "BackupLegendResult";
            this.Text = "BackupLegendResult";
            ((System.ComponentModel.ISupportInitialize)(this.pb_gray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pb_gray;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_green;
        private System.Windows.Forms.PictureBox pb_red;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pb_yellow;
        private System.Windows.Forms.ImageList tvwIml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_error;
    }
}