
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_ShowProjects = new System.Windows.Forms.Button();
            this.B_NewProject = new System.Windows.Forms.Button();
            this.B_Recovery = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.B_ShowProjects);
            this.panel1.Controls.Add(this.B_NewProject);
            this.panel1.Controls.Add(this.B_Recovery);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 703);
            this.panel1.TabIndex = 0;
            // 
            // B_ShowProjects
            // 
            this.B_ShowProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.B_ShowProjects.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_ShowProjects.Location = new System.Drawing.Point(0, 94);
            this.B_ShowProjects.Name = "B_ShowProjects";
            this.B_ShowProjects.Size = new System.Drawing.Size(135, 36);
            this.B_ShowProjects.TabIndex = 2;
            this.B_ShowProjects.Text = "My Projects";
            this.B_ShowProjects.UseVisualStyleBackColor = true;
            this.B_ShowProjects.Click += new System.EventHandler(this.B_ShowProjects_Click);
            // 
            // B_NewProject
            // 
            this.B_NewProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.B_NewProject.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_NewProject.Location = new System.Drawing.Point(0, 58);
            this.B_NewProject.Name = "B_NewProject";
            this.B_NewProject.Size = new System.Drawing.Size(135, 36);
            this.B_NewProject.TabIndex = 1;
            this.B_NewProject.Text = "New project";
            this.B_NewProject.UseVisualStyleBackColor = true;
            this.B_NewProject.Click += new System.EventHandler(this.B_NewProject_Click);
            // 
            // B_Recovery
            // 
            this.B_Recovery.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.B_Recovery.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_Recovery.Location = new System.Drawing.Point(0, 667);
            this.B_Recovery.Name = "B_Recovery";
            this.B_Recovery.Size = new System.Drawing.Size(135, 36);
            this.B_Recovery.TabIndex = 2;
            this.B_Recovery.Text = "Recovery";
            this.B_Recovery.UseVisualStyleBackColor = true;
            this.B_Recovery.Click += new System.EventHandler(this.B_Recovery_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 58);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anonymous Pro", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup\r\ntool";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_Main
            // 
            this.P_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_Main.Location = new System.Drawing.Point(135, 0);
            this.P_Main.Name = "P_Main";
            this.P_Main.Size = new System.Drawing.Size(1083, 703);
            this.P_Main.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 703);
            this.Controls.Add(this.P_Main);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(1234, 742);
            this.Name = "Main";
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
        private System.Windows.Forms.Button B_NewProject;
        private System.Windows.Forms.Button B_ShowProjects;
    }
}