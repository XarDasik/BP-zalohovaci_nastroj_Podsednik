namespace BP_ZalohovaciNastroj.View.Backup.ProgressWindows
{
    partial class BackupProgress
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblActualFile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 70);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(716, 28);
            this.progressBar1.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(672, 102);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 16);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "File:";
            // 
            // lblActualFile
            // 
            this.lblActualFile.AutoSize = true;
            this.lblActualFile.Location = new System.Drawing.Point(51, 11);
            this.lblActualFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActualFile.Name = "lblActualFile";
            this.lblActualFile.Size = new System.Drawing.Size(44, 16);
            this.lblActualFile.TabIndex = 3;
            this.lblActualFile.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please do not shutdown the computer during the backup";
            // 
            // BackupProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 148);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblActualFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.progressBar1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(766, 195);
            this.Name = "BackupProgress";
            this.ShowInTaskbar = false;
            this.Text = "The backup is in progress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblActualFile;
        private System.Windows.Forms.Label label1;
    }
}