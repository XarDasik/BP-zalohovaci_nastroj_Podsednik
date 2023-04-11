
namespace BP_ZalohovaciNastroj
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_Recovery = new System.Windows.Forms.Button();
            this.B_ShowProjects = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.P_Main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.B_Recovery);
            this.panel1.Controls.Add(this.B_ShowProjects);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 497);
            this.panel1.TabIndex = 1;
            // 
            // B_Recovery
            // 
            this.B_Recovery.Dock = System.Windows.Forms.DockStyle.Top;
            this.B_Recovery.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_Recovery.Location = new System.Drawing.Point(0, 77);
            this.B_Recovery.Margin = new System.Windows.Forms.Padding(2);
            this.B_Recovery.Name = "B_Recovery";
            this.B_Recovery.Size = new System.Drawing.Size(104, 26);
            this.B_Recovery.TabIndex = 0;
            this.B_Recovery.Text = "Recovery";
            this.B_Recovery.UseVisualStyleBackColor = true;
            this.B_Recovery.Click += new System.EventHandler(this.B_Recovery_Click);
            // 
            // B_ShowProjects
            // 
            this.B_ShowProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.B_ShowProjects.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_ShowProjects.Location = new System.Drawing.Point(0, 51);
            this.B_ShowProjects.Margin = new System.Windows.Forms.Padding(2);
            this.B_ShowProjects.Name = "B_ShowProjects";
            this.B_ShowProjects.Size = new System.Drawing.Size(104, 26);
            this.B_ShowProjects.TabIndex = 3;
            this.B_ShowProjects.Text = "Projects";
            this.B_ShowProjects.UseVisualStyleBackColor = true;
            this.B_ShowProjects.Click += new System.EventHandler(this.B_ShowProjects_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 51);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup\r\ntool";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_Main
            // 
            this.P_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_Main.Location = new System.Drawing.Point(104, 0);
            this.P_Main.Margin = new System.Windows.Forms.Padding(2);
            this.P_Main.Name = "P_Main";
            this.P_Main.Size = new System.Drawing.Size(810, 497);
            this.P_Main.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 497);
            this.Controls.Add(this.P_Main);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(679, 435);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Tool";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B_Recovery;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel P_Main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_ShowProjects;
    }
}