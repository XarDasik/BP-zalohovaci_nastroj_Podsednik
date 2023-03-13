
namespace BP_ZalohovaciNastroj
{
    partial class CopyFileDialog
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
            this.btnYes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnForAllFilesInAFolder = new System.Windows.Forms.Button();
            this.btnForEveryFile = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnForNoFilesInAFolder = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.lblCountListingOfFiles = new System.Windows.Forms.Label();
            this.lblActualState = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(12, 152);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(101, 41);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Do you want to copy the file\r\nto the destination anyway?";
            // 
            // btnForAllFilesInAFolder
            // 
            this.btnForAllFilesInAFolder.Location = new System.Drawing.Point(226, 152);
            this.btnForAllFilesInAFolder.Name = "btnForAllFilesInAFolder";
            this.btnForAllFilesInAFolder.Size = new System.Drawing.Size(101, 41);
            this.btnForAllFilesInAFolder.TabIndex = 3;
            this.btnForAllFilesInAFolder.Text = "For all files in\\n a folder";
            this.btnForAllFilesInAFolder.UseVisualStyleBackColor = true;
            this.btnForAllFilesInAFolder.Click += new System.EventHandler(this.btnForAllFilesInAFolder_Click);
            // 
            // btnForEveryFile
            // 
            this.btnForEveryFile.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnForEveryFile.Location = new System.Drawing.Point(440, 152);
            this.btnForEveryFile.Name = "btnForEveryFile";
            this.btnForEveryFile.Size = new System.Drawing.Size(101, 41);
            this.btnForEveryFile.TabIndex = 4;
            this.btnForEveryFile.Text = "For every file";
            this.btnForEveryFile.UseVisualStyleBackColor = true;
            this.btnForEveryFile.Click += new System.EventHandler(this.btnForEveryFile_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoEllipsis = true;
            this.lblFileName.AutoSize = true;
            this.lblFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFileName.Location = new System.Drawing.Point(3, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(100, 24);
            this.lblFileName.TabIndex = 5;
            this.lblFileName.Text = "lblfilename";
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(119, 152);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(101, 41);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnForNoFilesInAFolder
            // 
            this.btnForNoFilesInAFolder.Location = new System.Drawing.Point(333, 152);
            this.btnForNoFilesInAFolder.Name = "btnForNoFilesInAFolder";
            this.btnForNoFilesInAFolder.Size = new System.Drawing.Size(101, 41);
            this.btnForNoFilesInAFolder.TabIndex = 6;
            this.btnForNoFilesInAFolder.Text = "for no files in a folder";
            this.btnForNoFilesInAFolder.UseVisualStyleBackColor = true;
            this.btnForNoFilesInAFolder.Click += new System.EventHandler(this.btnForNoFilesInAFolder_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(433, 105);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(51, 41);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(490, 105);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(51, 41);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // lblCountListingOfFiles
            // 
            this.lblCountListingOfFiles.AutoSize = true;
            this.lblCountListingOfFiles.Location = new System.Drawing.Point(12, 93);
            this.lblCountListingOfFiles.Name = "lblCountListingOfFiles";
            this.lblCountListingOfFiles.Size = new System.Drawing.Size(46, 17);
            this.lblCountListingOfFiles.TabIndex = 9;
            this.lblCountListingOfFiles.Text = "label2";
            // 
            // lblActualState
            // 
            this.lblActualState.AutoSize = true;
            this.lblActualState.Location = new System.Drawing.Point(12, 76);
            this.lblActualState.Name = "lblActualState";
            this.lblActualState.Size = new System.Drawing.Size(46, 17);
            this.lblActualState.TabIndex = 10;
            this.lblActualState.Text = "label2";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(483, 62);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(58, 41);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblFileName);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(551, 56);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // CopyFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(551, 195);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblActualState);
            this.Controls.Add(this.lblCountListingOfFiles);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnForNoFilesInAFolder);
            this.Controls.Add(this.btnForEveryFile);
            this.Controls.Add(this.btnForAllFilesInAFolder);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "CopyFileDialog";
            this.Text = "Dialog";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnForAllFilesInAFolder;
        private System.Windows.Forms.Button btnForEveryFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnForNoFilesInAFolder;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lblCountListingOfFiles;
        private System.Windows.Forms.Label lblActualState;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}