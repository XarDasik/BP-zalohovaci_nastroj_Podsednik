
namespace BP_ZalohovaciNastroj
{
    partial class Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            this.L_RootPath = new System.Windows.Forms.Label();
            this.TB_RootPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.B_RootPathLoader = new System.Windows.Forms.Button();
            this.GB_GlobalSettings = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NUD_NumberOfBackups = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_DestinationPath = new System.Windows.Forms.TextBox();
            this.B_DestionationPathLoader = new System.Windows.Forms.Button();
            this.B_SimulateBackup = new System.Windows.Forms.Button();
            this.GB_FiltersOptions = new System.Windows.Forms.GroupBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.TC_Filters = new System.Windows.Forms.TabControl();
            this.TC_Aggregation = new System.Windows.Forms.TabPage();
            this.RB_OR = new System.Windows.Forms.RadioButton();
            this.RB_And = new System.Windows.Forms.RadioButton();
            this.TC_FilePath = new System.Windows.Forms.TabPage();
            this.TB_PathRegex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TC_Attribute = new System.Windows.Forms.TabPage();
            this.CHB_IsDirectory = new System.Windows.Forms.CheckBox();
            this.CHB_System = new System.Windows.Forms.CheckBox();
            this.CHB_ReadOnly = new System.Windows.Forms.CheckBox();
            this.CHB_Archive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TC_DateTime = new System.Windows.Forms.TabPage();
            this.CB_DateBeforeAfter = new System.Windows.Forms.ComboBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.RB_LastAccessDateTime = new System.Windows.Forms.RadioButton();
            this.RB_LastWriteDateTime = new System.Windows.Forms.RadioButton();
            this.RB_CreationDateTime = new System.Windows.Forms.RadioButton();
            this.TC_Size = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RB_Size_B = new System.Windows.Forms.RadioButton();
            this.RB_Size_MB = new System.Windows.Forms.RadioButton();
            this.RB_Size_kB = new System.Windows.Forms.RadioButton();
            this.RB_Size_GB = new System.Windows.Forms.RadioButton();
            this.NUD_Number = new System.Windows.Forms.NumericUpDown();
            this.RB_Maximal = new System.Windows.Forms.RadioButton();
            this.RB_Minimal = new System.Windows.Forms.RadioButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnCreateNewProject = new System.Windows.Forms.Button();
            this.TB_NameOfFilter = new System.Windows.Forms.TextBox();
            this.ChB_Negate = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.B_Remove = new System.Windows.Forms.Button();
            this.B_AddNext = new System.Windows.Forms.Button();
            this.B_AddChild = new System.Windows.Forms.Button();
            this.B_EditFilter = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel9 = new System.Windows.Forms.Panel();
            this.TV_FiltersView = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GB_GlobalSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NumberOfBackups)).BeginInit();
            this.GB_FiltersOptions.SuspendLayout();
            this.panel13.SuspendLayout();
            this.TC_Filters.SuspendLayout();
            this.TC_Aggregation.SuspendLayout();
            this.TC_FilePath.SuspendLayout();
            this.TC_Attribute.SuspendLayout();
            this.TC_DateTime.SuspendLayout();
            this.TC_Size.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Number)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_RootPath
            // 
            this.L_RootPath.AutoSize = true;
            this.L_RootPath.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L_RootPath.Location = new System.Drawing.Point(46, 14);
            this.L_RootPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_RootPath.Name = "L_RootPath";
            this.L_RootPath.Size = new System.Drawing.Size(65, 12);
            this.L_RootPath.TabIndex = 0;
            this.L_RootPath.Text = "Root Path:";
            // 
            // TB_RootPath
            // 
            this.TB_RootPath.Location = new System.Drawing.Point(115, 11);
            this.TB_RootPath.Margin = new System.Windows.Forms.Padding(2);
            this.TB_RootPath.Name = "TB_RootPath";
            this.TB_RootPath.Size = new System.Drawing.Size(284, 18);
            this.TB_RootPath.TabIndex = 1;
            this.TB_RootPath.TextChanged += new System.EventHandler(this.TB_RootPath_TextChanged);
            // 
            // B_RootPathLoader
            // 
            this.B_RootPathLoader.BackColor = System.Drawing.Color.White;
            this.B_RootPathLoader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_RootPathLoader.BackgroundImage")));
            this.B_RootPathLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_RootPathLoader.Location = new System.Drawing.Point(403, 10);
            this.B_RootPathLoader.Margin = new System.Windows.Forms.Padding(2);
            this.B_RootPathLoader.Name = "B_RootPathLoader";
            this.B_RootPathLoader.Size = new System.Drawing.Size(21, 21);
            this.B_RootPathLoader.TabIndex = 2;
            this.B_RootPathLoader.UseVisualStyleBackColor = false;
            this.B_RootPathLoader.Click += new System.EventHandler(this.B_path_Click);
            // 
            // GB_GlobalSettings
            // 
            this.GB_GlobalSettings.Controls.Add(this.label6);
            this.GB_GlobalSettings.Controls.Add(this.L_RootPath);
            this.GB_GlobalSettings.Controls.Add(this.label4);
            this.GB_GlobalSettings.Controls.Add(this.NUD_NumberOfBackups);
            this.GB_GlobalSettings.Controls.Add(this.label5);
            this.GB_GlobalSettings.Controls.Add(this.TB_DestinationPath);
            this.GB_GlobalSettings.Controls.Add(this.B_DestionationPathLoader);
            this.GB_GlobalSettings.Controls.Add(this.TB_RootPath);
            this.GB_GlobalSettings.Controls.Add(this.B_RootPathLoader);
            this.GB_GlobalSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.GB_GlobalSettings.Location = new System.Drawing.Point(0, 0);
            this.GB_GlobalSettings.Margin = new System.Windows.Forms.Padding(2);
            this.GB_GlobalSettings.Name = "GB_GlobalSettings";
            this.GB_GlobalSettings.Padding = new System.Windows.Forms.Padding(2);
            this.GB_GlobalSettings.Size = new System.Drawing.Size(703, 74);
            this.GB_GlobalSettings.TabIndex = 3;
            this.GB_GlobalSettings.TabStop = false;
            this.GB_GlobalSettings.Text = "Global settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(3, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "Top filters are aggregated via AND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(4, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Destination path:";
            // 
            // NUD_NumberOfBackups
            // 
            this.NUD_NumberOfBackups.Location = new System.Drawing.Point(599, 10);
            this.NUD_NumberOfBackups.Margin = new System.Windows.Forms.Padding(2);
            this.NUD_NumberOfBackups.Name = "NUD_NumberOfBackups";
            this.NUD_NumberOfBackups.Size = new System.Drawing.Size(90, 18);
            this.NUD_NumberOfBackups.TabIndex = 7;
            this.NUD_NumberOfBackups.ValueChanged += new System.EventHandler(this.NUD_NumberOfBackups_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number of older backups:";
            // 
            // TB_DestinationPath
            // 
            this.TB_DestinationPath.Location = new System.Drawing.Point(115, 36);
            this.TB_DestinationPath.Margin = new System.Windows.Forms.Padding(2);
            this.TB_DestinationPath.Name = "TB_DestinationPath";
            this.TB_DestinationPath.Size = new System.Drawing.Size(284, 18);
            this.TB_DestinationPath.TabIndex = 4;
            this.TB_DestinationPath.TextChanged += new System.EventHandler(this.TB_DestinationPath_TextChanged);
            // 
            // B_DestionationPathLoader
            // 
            this.B_DestionationPathLoader.BackColor = System.Drawing.Color.White;
            this.B_DestionationPathLoader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_DestionationPathLoader.BackgroundImage")));
            this.B_DestionationPathLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_DestionationPathLoader.Location = new System.Drawing.Point(403, 34);
            this.B_DestionationPathLoader.Margin = new System.Windows.Forms.Padding(2);
            this.B_DestionationPathLoader.Name = "B_DestionationPathLoader";
            this.B_DestionationPathLoader.Size = new System.Drawing.Size(21, 21);
            this.B_DestionationPathLoader.TabIndex = 5;
            this.B_DestionationPathLoader.UseVisualStyleBackColor = false;
            this.B_DestionationPathLoader.Click += new System.EventHandler(this.B_DestionationPathLoader_Click);
            // 
            // B_SimulateBackup
            // 
            this.B_SimulateBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_SimulateBackup.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_SimulateBackup.Location = new System.Drawing.Point(0, 49);
            this.B_SimulateBackup.Margin = new System.Windows.Forms.Padding(2);
            this.B_SimulateBackup.Name = "B_SimulateBackup";
            this.B_SimulateBackup.Size = new System.Drawing.Size(86, 44);
            this.B_SimulateBackup.TabIndex = 6;
            this.B_SimulateBackup.Text = "Preview";
            this.B_SimulateBackup.UseVisualStyleBackColor = true;
            this.B_SimulateBackup.Click += new System.EventHandler(this.B_SimulateBackup_Click);
            // 
            // GB_FiltersOptions
            // 
            this.GB_FiltersOptions.Controls.Add(this.panel13);
            this.GB_FiltersOptions.Controls.Add(this.panel12);
            this.GB_FiltersOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_FiltersOptions.Location = new System.Drawing.Point(0, 0);
            this.GB_FiltersOptions.Margin = new System.Windows.Forms.Padding(2);
            this.GB_FiltersOptions.Name = "GB_FiltersOptions";
            this.GB_FiltersOptions.Padding = new System.Windows.Forms.Padding(2);
            this.GB_FiltersOptions.Size = new System.Drawing.Size(357, 395);
            this.GB_FiltersOptions.TabIndex = 5;
            this.GB_FiltersOptions.TabStop = false;
            this.GB_FiltersOptions.Text = "Filter settings";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.TC_Filters);
            this.panel13.Controls.Add(this.panel3);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(2, 13);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel13.Size = new System.Drawing.Size(353, 350);
            this.panel13.TabIndex = 11;
            // 
            // TC_Filters
            // 
            this.TC_Filters.Controls.Add(this.TC_Aggregation);
            this.TC_Filters.Controls.Add(this.TC_FilePath);
            this.TC_Filters.Controls.Add(this.TC_Attribute);
            this.TC_Filters.Controls.Add(this.TC_DateTime);
            this.TC_Filters.Controls.Add(this.TC_Size);
            this.TC_Filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC_Filters.Location = new System.Drawing.Point(8, 7);
            this.TC_Filters.Margin = new System.Windows.Forms.Padding(2);
            this.TC_Filters.Name = "TC_Filters";
            this.TC_Filters.SelectedIndex = 0;
            this.TC_Filters.Size = new System.Drawing.Size(337, 295);
            this.TC_Filters.TabIndex = 5;
            // 
            // TC_Aggregation
            // 
            this.TC_Aggregation.Controls.Add(this.RB_OR);
            this.TC_Aggregation.Controls.Add(this.RB_And);
            this.TC_Aggregation.Location = new System.Drawing.Point(4, 21);
            this.TC_Aggregation.Margin = new System.Windows.Forms.Padding(2);
            this.TC_Aggregation.Name = "TC_Aggregation";
            this.TC_Aggregation.Padding = new System.Windows.Forms.Padding(2);
            this.TC_Aggregation.Size = new System.Drawing.Size(329, 270);
            this.TC_Aggregation.TabIndex = 0;
            this.TC_Aggregation.Text = "Aggregation";
            this.TC_Aggregation.UseVisualStyleBackColor = true;
            // 
            // RB_OR
            // 
            this.RB_OR.AutoSize = true;
            this.RB_OR.Location = new System.Drawing.Point(15, 33);
            this.RB_OR.Margin = new System.Windows.Forms.Padding(2);
            this.RB_OR.Name = "RB_OR";
            this.RB_OR.Size = new System.Drawing.Size(251, 16);
            this.RB_OR.TabIndex = 1;
            this.RB_OR.TabStop = true;
            this.RB_OR.Text = "Or (at least one sub-filter satisfied)";
            this.RB_OR.UseVisualStyleBackColor = true;
            // 
            // RB_And
            // 
            this.RB_And.AutoSize = true;
            this.RB_And.Location = new System.Drawing.Point(15, 14);
            this.RB_And.Margin = new System.Windows.Forms.Padding(2);
            this.RB_And.Name = "RB_And";
            this.RB_And.Size = new System.Drawing.Size(209, 16);
            this.RB_And.TabIndex = 0;
            this.RB_And.TabStop = true;
            this.RB_And.Text = "And (all sub-filters satisfied)";
            this.RB_And.UseVisualStyleBackColor = true;
            // 
            // TC_FilePath
            // 
            this.TC_FilePath.Controls.Add(this.TB_PathRegex);
            this.TC_FilePath.Controls.Add(this.label1);
            this.TC_FilePath.Location = new System.Drawing.Point(4, 22);
            this.TC_FilePath.Margin = new System.Windows.Forms.Padding(2);
            this.TC_FilePath.Name = "TC_FilePath";
            this.TC_FilePath.Padding = new System.Windows.Forms.Padding(2);
            this.TC_FilePath.Size = new System.Drawing.Size(329, 308);
            this.TC_FilePath.TabIndex = 1;
            this.TC_FilePath.Text = "File-Path";
            this.TC_FilePath.UseVisualStyleBackColor = true;
            // 
            // TB_PathRegex
            // 
            this.TB_PathRegex.Location = new System.Drawing.Point(16, 26);
            this.TB_PathRegex.Margin = new System.Windows.Forms.Padding(2);
            this.TB_PathRegex.Name = "TB_PathRegex";
            this.TB_PathRegex.Size = new System.Drawing.Size(236, 18);
            this.TB_PathRegex.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path regular expression:";
            // 
            // TC_Attribute
            // 
            this.TC_Attribute.Controls.Add(this.CHB_IsDirectory);
            this.TC_Attribute.Controls.Add(this.CHB_System);
            this.TC_Attribute.Controls.Add(this.CHB_ReadOnly);
            this.TC_Attribute.Controls.Add(this.CHB_Archive);
            this.TC_Attribute.Controls.Add(this.label2);
            this.TC_Attribute.Location = new System.Drawing.Point(4, 21);
            this.TC_Attribute.Margin = new System.Windows.Forms.Padding(2);
            this.TC_Attribute.Name = "TC_Attribute";
            this.TC_Attribute.Padding = new System.Windows.Forms.Padding(2);
            this.TC_Attribute.Size = new System.Drawing.Size(329, 311);
            this.TC_Attribute.TabIndex = 2;
            this.TC_Attribute.Text = "Attribute";
            this.TC_Attribute.UseVisualStyleBackColor = true;
            // 
            // CHB_IsDirectory
            // 
            this.CHB_IsDirectory.AutoSize = true;
            this.CHB_IsDirectory.Location = new System.Drawing.Point(41, 76);
            this.CHB_IsDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.CHB_IsDirectory.Name = "CHB_IsDirectory";
            this.CHB_IsDirectory.Size = new System.Drawing.Size(96, 16);
            this.CHB_IsDirectory.TabIndex = 9;
            this.CHB_IsDirectory.Text = "Is Directory";
            this.CHB_IsDirectory.UseVisualStyleBackColor = true;
            // 
            // CHB_System
            // 
            this.CHB_System.AutoSize = true;
            this.CHB_System.Location = new System.Drawing.Point(41, 60);
            this.CHB_System.Margin = new System.Windows.Forms.Padding(2);
            this.CHB_System.Name = "CHB_System";
            this.CHB_System.Size = new System.Drawing.Size(60, 16);
            this.CHB_System.TabIndex = 8;
            this.CHB_System.Text = "System";
            this.CHB_System.UseVisualStyleBackColor = true;
            // 
            // CHB_ReadOnly
            // 
            this.CHB_ReadOnly.AutoSize = true;
            this.CHB_ReadOnly.Location = new System.Drawing.Point(41, 44);
            this.CHB_ReadOnly.Margin = new System.Windows.Forms.Padding(2);
            this.CHB_ReadOnly.Name = "CHB_ReadOnly";
            this.CHB_ReadOnly.Size = new System.Drawing.Size(78, 16);
            this.CHB_ReadOnly.TabIndex = 7;
            this.CHB_ReadOnly.Text = "Read-Only";
            this.CHB_ReadOnly.UseVisualStyleBackColor = true;
            // 
            // CHB_Archive
            // 
            this.CHB_Archive.AutoSize = true;
            this.CHB_Archive.Location = new System.Drawing.Point(42, 29);
            this.CHB_Archive.Margin = new System.Windows.Forms.Padding(2);
            this.CHB_Archive.Name = "CHB_Archive";
            this.CHB_Archive.Size = new System.Drawing.Size(66, 16);
            this.CHB_Archive.TabIndex = 6;
            this.CHB_Archive.Text = "Archive";
            this.CHB_Archive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Attribute:";
            // 
            // TC_DateTime
            // 
            this.TC_DateTime.Controls.Add(this.CB_DateBeforeAfter);
            this.TC_DateTime.Controls.Add(this.DTP_Date);
            this.TC_DateTime.Controls.Add(this.RB_LastAccessDateTime);
            this.TC_DateTime.Controls.Add(this.RB_LastWriteDateTime);
            this.TC_DateTime.Controls.Add(this.RB_CreationDateTime);
            this.TC_DateTime.Location = new System.Drawing.Point(4, 22);
            this.TC_DateTime.Margin = new System.Windows.Forms.Padding(2);
            this.TC_DateTime.Name = "TC_DateTime";
            this.TC_DateTime.Padding = new System.Windows.Forms.Padding(2);
            this.TC_DateTime.Size = new System.Drawing.Size(329, 308);
            this.TC_DateTime.TabIndex = 3;
            this.TC_DateTime.Text = "Date-Time";
            this.TC_DateTime.UseVisualStyleBackColor = true;
            // 
            // CB_DateBeforeAfter
            // 
            this.CB_DateBeforeAfter.DisplayMember = "1";
            this.CB_DateBeforeAfter.FormattingEnabled = true;
            this.CB_DateBeforeAfter.Items.AddRange(new object[] {
            "Before date",
            "After date"});
            this.CB_DateBeforeAfter.Location = new System.Drawing.Point(174, 68);
            this.CB_DateBeforeAfter.Margin = new System.Windows.Forms.Padding(2);
            this.CB_DateBeforeAfter.Name = "CB_DateBeforeAfter";
            this.CB_DateBeforeAfter.Size = new System.Drawing.Size(92, 20);
            this.CB_DateBeforeAfter.TabIndex = 4;
            // 
            // DTP_Date
            // 
            this.DTP_Date.CustomFormat = "dd.MM.yyyy HH:mm";
            this.DTP_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Date.Location = new System.Drawing.Point(19, 68);
            this.DTP_Date.Margin = new System.Windows.Forms.Padding(2);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(151, 18);
            this.DTP_Date.TabIndex = 3;
            this.DTP_Date.Value = new System.DateTime(2022, 1, 13, 0, 0, 0, 0);
            // 
            // RB_LastAccessDateTime
            // 
            this.RB_LastAccessDateTime.AutoSize = true;
            this.RB_LastAccessDateTime.Location = new System.Drawing.Point(19, 43);
            this.RB_LastAccessDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.RB_LastAccessDateTime.Name = "RB_LastAccessDateTime";
            this.RB_LastAccessDateTime.Size = new System.Drawing.Size(149, 16);
            this.RB_LastAccessDateTime.TabIndex = 2;
            this.RB_LastAccessDateTime.TabStop = true;
            this.RB_LastAccessDateTime.Text = "Last Access Date Time";
            this.RB_LastAccessDateTime.UseVisualStyleBackColor = true;
            // 
            // RB_LastWriteDateTime
            // 
            this.RB_LastWriteDateTime.AutoSize = true;
            this.RB_LastWriteDateTime.Location = new System.Drawing.Point(19, 29);
            this.RB_LastWriteDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.RB_LastWriteDateTime.Name = "RB_LastWriteDateTime";
            this.RB_LastWriteDateTime.Size = new System.Drawing.Size(143, 16);
            this.RB_LastWriteDateTime.TabIndex = 1;
            this.RB_LastWriteDateTime.TabStop = true;
            this.RB_LastWriteDateTime.Text = "Last Write Date Time";
            this.RB_LastWriteDateTime.UseVisualStyleBackColor = true;
            // 
            // RB_CreationDateTime
            // 
            this.RB_CreationDateTime.AutoSize = true;
            this.RB_CreationDateTime.Location = new System.Drawing.Point(19, 14);
            this.RB_CreationDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.RB_CreationDateTime.Name = "RB_CreationDateTime";
            this.RB_CreationDateTime.Size = new System.Drawing.Size(131, 16);
            this.RB_CreationDateTime.TabIndex = 0;
            this.RB_CreationDateTime.TabStop = true;
            this.RB_CreationDateTime.Text = "Creation Date Time";
            this.RB_CreationDateTime.UseVisualStyleBackColor = true;
            // 
            // TC_Size
            // 
            this.TC_Size.Controls.Add(this.panel1);
            this.TC_Size.Controls.Add(this.NUD_Number);
            this.TC_Size.Controls.Add(this.RB_Maximal);
            this.TC_Size.Controls.Add(this.RB_Minimal);
            this.TC_Size.Location = new System.Drawing.Point(4, 22);
            this.TC_Size.Margin = new System.Windows.Forms.Padding(2);
            this.TC_Size.Name = "TC_Size";
            this.TC_Size.Padding = new System.Windows.Forms.Padding(2);
            this.TC_Size.Size = new System.Drawing.Size(329, 308);
            this.TC_Size.TabIndex = 4;
            this.TC_Size.Text = "Size";
            this.TC_Size.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RB_Size_B);
            this.panel1.Controls.Add(this.RB_Size_MB);
            this.panel1.Controls.Add(this.RB_Size_kB);
            this.panel1.Controls.Add(this.RB_Size_GB);
            this.panel1.Location = new System.Drawing.Point(115, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 65);
            this.panel1.TabIndex = 9;
            // 
            // RB_Size_B
            // 
            this.RB_Size_B.AutoSize = true;
            this.RB_Size_B.Location = new System.Drawing.Point(2, 2);
            this.RB_Size_B.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Size_B.Name = "RB_Size_B";
            this.RB_Size_B.Size = new System.Drawing.Size(29, 16);
            this.RB_Size_B.TabIndex = 2;
            this.RB_Size_B.TabStop = true;
            this.RB_Size_B.Text = "b";
            this.RB_Size_B.UseVisualStyleBackColor = true;
            // 
            // RB_Size_MB
            // 
            this.RB_Size_MB.AutoSize = true;
            this.RB_Size_MB.Location = new System.Drawing.Point(2, 31);
            this.RB_Size_MB.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Size_MB.Name = "RB_Size_MB";
            this.RB_Size_MB.Size = new System.Drawing.Size(35, 16);
            this.RB_Size_MB.TabIndex = 4;
            this.RB_Size_MB.TabStop = true;
            this.RB_Size_MB.Text = "MB";
            this.RB_Size_MB.UseVisualStyleBackColor = true;
            // 
            // RB_Size_kB
            // 
            this.RB_Size_kB.AutoSize = true;
            this.RB_Size_kB.Location = new System.Drawing.Point(2, 17);
            this.RB_Size_kB.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Size_kB.Name = "RB_Size_kB";
            this.RB_Size_kB.Size = new System.Drawing.Size(35, 16);
            this.RB_Size_kB.TabIndex = 3;
            this.RB_Size_kB.TabStop = true;
            this.RB_Size_kB.Text = "kB";
            this.RB_Size_kB.UseVisualStyleBackColor = true;
            // 
            // RB_Size_GB
            // 
            this.RB_Size_GB.AutoSize = true;
            this.RB_Size_GB.Location = new System.Drawing.Point(2, 46);
            this.RB_Size_GB.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Size_GB.Name = "RB_Size_GB";
            this.RB_Size_GB.Size = new System.Drawing.Size(35, 16);
            this.RB_Size_GB.TabIndex = 5;
            this.RB_Size_GB.TabStop = true;
            this.RB_Size_GB.Text = "GB";
            this.RB_Size_GB.UseVisualStyleBackColor = true;
            // 
            // NUD_Number
            // 
            this.NUD_Number.Location = new System.Drawing.Point(20, 55);
            this.NUD_Number.Margin = new System.Windows.Forms.Padding(2);
            this.NUD_Number.Name = "NUD_Number";
            this.NUD_Number.Size = new System.Drawing.Size(90, 18);
            this.NUD_Number.TabIndex = 7;
            // 
            // RB_Maximal
            // 
            this.RB_Maximal.AutoSize = true;
            this.RB_Maximal.Location = new System.Drawing.Point(20, 33);
            this.RB_Maximal.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Maximal.Name = "RB_Maximal";
            this.RB_Maximal.Size = new System.Drawing.Size(95, 16);
            this.RB_Maximal.TabIndex = 1;
            this.RB_Maximal.Text = "Maximal size";
            this.RB_Maximal.UseVisualStyleBackColor = true;
            // 
            // RB_Minimal
            // 
            this.RB_Minimal.AutoSize = true;
            this.RB_Minimal.Checked = true;
            this.RB_Minimal.Location = new System.Drawing.Point(20, 14);
            this.RB_Minimal.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Minimal.Name = "RB_Minimal";
            this.RB_Minimal.Size = new System.Drawing.Size(95, 16);
            this.RB_Minimal.TabIndex = 0;
            this.RB_Minimal.TabStop = true;
            this.RB_Minimal.Text = "Minimal size";
            this.RB_Minimal.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnCreateNewProject);
            this.panel12.Controls.Add(this.TB_NameOfFilter);
            this.panel12.Controls.Add(this.ChB_Negate);
            this.panel12.Controls.Add(this.label3);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(2, 363);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(353, 30);
            this.panel12.TabIndex = 10;
            // 
            // btnCreateNewProject
            // 
            this.btnCreateNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNewProject.Font = new System.Drawing.Font("Anonymous Pro", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateNewProject.Location = new System.Drawing.Point(207, 2);
            this.btnCreateNewProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateNewProject.Name = "btnCreateNewProject";
            this.btnCreateNewProject.Size = new System.Drawing.Size(144, 26);
            this.btnCreateNewProject.TabIndex = 8;
            this.btnCreateNewProject.Text = "Create a new project";
            this.btnCreateNewProject.UseVisualStyleBackColor = true;
            this.btnCreateNewProject.Click += new System.EventHandler(this.btnCreateNewProject_Click);
            // 
            // TB_NameOfFilter
            // 
            this.TB_NameOfFilter.Location = new System.Drawing.Point(150, 6);
            this.TB_NameOfFilter.Margin = new System.Windows.Forms.Padding(2);
            this.TB_NameOfFilter.Name = "TB_NameOfFilter";
            this.TB_NameOfFilter.Size = new System.Drawing.Size(100, 18);
            this.TB_NameOfFilter.TabIndex = 8;
            // 
            // ChB_Negate
            // 
            this.ChB_Negate.AutoSize = true;
            this.ChB_Negate.Location = new System.Drawing.Point(10, 8);
            this.ChB_Negate.Margin = new System.Windows.Forms.Padding(2);
            this.ChB_Negate.Name = "ChB_Negate";
            this.ChB_Negate.Size = new System.Drawing.Size(60, 16);
            this.ChB_Negate.TabIndex = 6;
            this.ChB_Negate.Text = "Negate";
            this.ChB_Negate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Comment/Name:";
            // 
            // B_Remove
            // 
            this.B_Remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B_Remove.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_Remove.Location = new System.Drawing.Point(0, 0);
            this.B_Remove.Margin = new System.Windows.Forms.Padding(2);
            this.B_Remove.Name = "B_Remove";
            this.B_Remove.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.B_Remove.Size = new System.Drawing.Size(86, 41);
            this.B_Remove.TabIndex = 4;
            this.B_Remove.Text = "Remove the filter";
            this.B_Remove.UseVisualStyleBackColor = true;
            this.B_Remove.Click += new System.EventHandler(this.B_Remove_Click);
            // 
            // B_AddNext
            // 
            this.B_AddNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B_AddNext.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_AddNext.Location = new System.Drawing.Point(0, 0);
            this.B_AddNext.Margin = new System.Windows.Forms.Padding(2);
            this.B_AddNext.Name = "B_AddNext";
            this.B_AddNext.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.B_AddNext.Size = new System.Drawing.Size(86, 41);
            this.B_AddNext.TabIndex = 3;
            this.B_AddNext.Text = "Add as top filter";
            this.B_AddNext.UseVisualStyleBackColor = true;
            this.B_AddNext.Click += new System.EventHandler(this.B_AddNext_Click);
            // 
            // B_AddChild
            // 
            this.B_AddChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B_AddChild.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_AddChild.Location = new System.Drawing.Point(0, 0);
            this.B_AddChild.Margin = new System.Windows.Forms.Padding(2);
            this.B_AddChild.Name = "B_AddChild";
            this.B_AddChild.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.B_AddChild.Size = new System.Drawing.Size(86, 41);
            this.B_AddChild.TabIndex = 2;
            this.B_AddChild.Text = "Add as subfilter";
            this.B_AddChild.UseVisualStyleBackColor = true;
            this.B_AddChild.Click += new System.EventHandler(this.B_AddChild_Click);
            // 
            // B_EditFilter
            // 
            this.B_EditFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B_EditFilter.Location = new System.Drawing.Point(0, 10);
            this.B_EditFilter.Margin = new System.Windows.Forms.Padding(2);
            this.B_EditFilter.Name = "B_EditFilter";
            this.B_EditFilter.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.B_EditFilter.Size = new System.Drawing.Size(337, 31);
            this.B_EditFilter.TabIndex = 1;
            this.B_EditFilter.Text = "Apply changes";
            this.B_EditFilter.UseVisualStyleBackColor = true;
            this.B_EditFilter.Click += new System.EventHandler(this.B_EditFilter_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 74);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel9);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GB_FiltersOptions);
            this.splitContainer1.Size = new System.Drawing.Size(703, 395);
            this.splitContainer1.SplitterDistance = 343;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.TV_FiltersView);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(8, 5, 8, 7);
            this.panel9.Size = new System.Drawing.Size(257, 395);
            this.panel9.TabIndex = 3;
            // 
            // TV_FiltersView
            // 
            this.TV_FiltersView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TV_FiltersView.HideSelection = false;
            this.TV_FiltersView.Location = new System.Drawing.Point(8, 5);
            this.TV_FiltersView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.TV_FiltersView.Name = "TV_FiltersView";
            this.TV_FiltersView.Size = new System.Drawing.Size(241, 383);
            this.TV_FiltersView.TabIndex = 0;
            this.TV_FiltersView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV_FiltersView_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(257, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 395);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnSave);
            this.panel7.Controls.Add(this.B_SimulateBackup);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 292);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(86, 103);
            this.panel7.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(0, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 44);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save changes in the project";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.B_Remove);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 82);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(86, 41);
            this.panel6.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.B_AddNext);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 41);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(86, 41);
            this.panel5.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.B_AddChild);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(86, 41);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.B_EditFilter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(8, 302);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel3.Size = new System.Drawing.Size(337, 41);
            this.panel3.TabIndex = 7;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 469);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.GB_GlobalSettings);
            this.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(620, 389);
            this.Name = "Backup";
            this.Text = "Backup tool";
            this.GB_GlobalSettings.ResumeLayout(false);
            this.GB_GlobalSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NumberOfBackups)).EndInit();
            this.GB_FiltersOptions.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.TC_Filters.ResumeLayout(false);
            this.TC_Aggregation.ResumeLayout(false);
            this.TC_Aggregation.PerformLayout();
            this.TC_FilePath.ResumeLayout(false);
            this.TC_FilePath.PerformLayout();
            this.TC_Attribute.ResumeLayout(false);
            this.TC_Attribute.PerformLayout();
            this.TC_DateTime.ResumeLayout(false);
            this.TC_DateTime.PerformLayout();
            this.TC_Size.ResumeLayout(false);
            this.TC_Size.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Number)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label L_RootPath;
        private System.Windows.Forms.TextBox TB_RootPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button B_RootPathLoader;
        private System.Windows.Forms.GroupBox GB_GlobalSettings;
        private System.Windows.Forms.Button B_Remove;
        private System.Windows.Forms.Button B_AddNext;
        private System.Windows.Forms.Button B_AddChild;
        private System.Windows.Forms.Button B_EditFilter;
        private System.Windows.Forms.GroupBox GB_FiltersOptions;
        private System.Windows.Forms.TabControl TC_Filters;
        private System.Windows.Forms.TabPage TC_Aggregation;
        private System.Windows.Forms.RadioButton RB_OR;
        private System.Windows.Forms.RadioButton RB_And;
        private System.Windows.Forms.TabPage TC_FilePath;
        private System.Windows.Forms.TextBox TB_PathRegex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TC_Attribute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage TC_DateTime;
        private System.Windows.Forms.ComboBox CB_DateBeforeAfter;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.RadioButton RB_LastAccessDateTime;
        private System.Windows.Forms.RadioButton RB_LastWriteDateTime;
        private System.Windows.Forms.RadioButton RB_CreationDateTime;
        private System.Windows.Forms.TabPage TC_Size;
        private System.Windows.Forms.CheckBox ChB_Negate;
        private System.Windows.Forms.RadioButton RB_Maximal;
        private System.Windows.Forms.RadioButton RB_Minimal;
        private System.Windows.Forms.RadioButton RB_Size_GB;
        private System.Windows.Forms.RadioButton RB_Size_MB;
        private System.Windows.Forms.RadioButton RB_Size_kB;
        private System.Windows.Forms.RadioButton RB_Size_B;
        private System.Windows.Forms.NumericUpDown NUD_Number;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_NameOfFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_DestinationPath;
        private System.Windows.Forms.Button B_DestionationPathLoader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUD_NumberOfBackups;
        private System.Windows.Forms.Button B_SimulateBackup;
        private System.Windows.Forms.CheckBox CHB_IsDirectory;
        private System.Windows.Forms.CheckBox CHB_System;
        private System.Windows.Forms.CheckBox CHB_ReadOnly;
        private System.Windows.Forms.CheckBox CHB_Archive;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView TV_FiltersView;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreateNewProject;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
    }
}

