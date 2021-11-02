
namespace BP_ZalohovaciNastroj
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TB_path = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.TV_filters = new System.Windows.Forms.TreeView();
            this.B_addLogicOperand = new System.Windows.Forms.Button();
            this.CB_LogicOperand = new System.Windows.Forms.ComboBox();
            this.B_addFilter = new System.Windows.Forms.Button();
            this.LB_files = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cesta pro zálohování:";
            // 
            // TB_path
            // 
            this.TB_path.Location = new System.Drawing.Point(158, 90);
            this.TB_path.Name = "TB_path";
            this.TB_path.Size = new System.Drawing.Size(358, 20);
            this.TB_path.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(522, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 33);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.B_path_Click);
            // 
            // TV_filters
            // 
            this.TV_filters.Location = new System.Drawing.Point(67, 184);
            this.TV_filters.Name = "TV_filters";
            this.TV_filters.Size = new System.Drawing.Size(284, 305);
            this.TV_filters.TabIndex = 3;
            // 
            // B_addLogicOperand
            // 
            this.B_addLogicOperand.Location = new System.Drawing.Point(358, 184);
            this.B_addLogicOperand.Name = "B_addLogicOperand";
            this.B_addLogicOperand.Size = new System.Drawing.Size(158, 31);
            this.B_addLogicOperand.TabIndex = 4;
            this.B_addLogicOperand.Text = "Přidat logický operátor";
            this.B_addLogicOperand.UseVisualStyleBackColor = true;
            this.B_addLogicOperand.Click += new System.EventHandler(this.B_addLogicOperand_Click);
            // 
            // CB_LogicOperand
            // 
            this.CB_LogicOperand.FormattingEnabled = true;
            this.CB_LogicOperand.Items.AddRange(new object[] {
            "AND",
            "OR",
            "NOT"});
            this.CB_LogicOperand.Location = new System.Drawing.Point(522, 190);
            this.CB_LogicOperand.Name = "CB_LogicOperand";
            this.CB_LogicOperand.Size = new System.Drawing.Size(121, 21);
            this.CB_LogicOperand.TabIndex = 5;
            // 
            // B_addFilter
            // 
            this.B_addFilter.Location = new System.Drawing.Point(358, 221);
            this.B_addFilter.Name = "B_addFilter";
            this.B_addFilter.Size = new System.Drawing.Size(158, 31);
            this.B_addFilter.TabIndex = 6;
            this.B_addFilter.Text = "Přidat filter";
            this.B_addFilter.UseVisualStyleBackColor = true;
            this.B_addFilter.Click += new System.EventHandler(this.B_addFilter_Click);
            // 
            // LB_files
            // 
            this.LB_files.FormattingEnabled = true;
            this.LB_files.Location = new System.Drawing.Point(691, 190);
            this.LB_files.Name = "LB_files";
            this.LB_files.Size = new System.Drawing.Size(262, 355);
            this.LB_files.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 580);
            this.Controls.Add(this.LB_files);
            this.Controls.Add(this.B_addFilter);
            this.Controls.Add(this.CB_LogicOperand);
            this.Controls.Add(this.B_addLogicOperand);
            this.Controls.Add(this.TV_filters);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_path);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Demo Zalohovaci nastroj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_path;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView TV_filters;
        private System.Windows.Forms.Button B_addLogicOperand;
        private System.Windows.Forms.ComboBox CB_LogicOperand;
        private System.Windows.Forms.Button B_addFilter;
        private System.Windows.Forms.ListBox LB_files;
    }
}

