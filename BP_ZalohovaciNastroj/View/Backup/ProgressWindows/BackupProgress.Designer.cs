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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupProgress));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblActualFile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 36);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(537, 21);
            this.progressBar1.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(480, 60);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(83, 12);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "calculating..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "File:";
            // 
            // lblActualFile
            // 
            this.lblActualFile.AutoSize = true;
            this.lblActualFile.Location = new System.Drawing.Point(48, 8);
            this.lblActualFile.Name = "lblActualFile";
            this.lblActualFile.Size = new System.Drawing.Size(83, 12);
            this.lblActualFile.TabIndex = 3;
            this.lblActualFile.Text = "inializing...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(95, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please do not shutdown the computer during the backup";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(455, 76);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BackupProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 117);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblActualFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.progressBar1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(578, 156);
            this.MinimumSize = new System.Drawing.Size(577, 150);
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
        private System.Windows.Forms.Button btnCancel;
    }
}