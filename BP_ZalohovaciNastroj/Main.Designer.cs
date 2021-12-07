
namespace BP_ZalohovaciNastroj
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.L_RootPath = new System.Windows.Forms.Label();
            this.TB_RootPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.B_RootPathLoader = new System.Windows.Forms.Button();
            this.GB_GlobalSettings = new System.Windows.Forms.GroupBox();
            this.NUD_NumberOfBackups = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_DestinationPath = new System.Windows.Forms.TextBox();
            this.B_DestionationPathLoader = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GB_Filters = new System.Windows.Forms.GroupBox();
            this.GB_FiltersOptions = new System.Windows.Forms.GroupBox();
            this.TB_NameOfFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChB_Negate = new System.Windows.Forms.CheckBox();
            this.TC_Filters = new System.Windows.Forms.TabControl();
            this.TC_Aggregation = new System.Windows.Forms.TabPage();
            this.RB_OR = new System.Windows.Forms.RadioButton();
            this.RB_And = new System.Windows.Forms.RadioButton();
            this.TC_FilePath = new System.Windows.Forms.TabPage();
            this.TB_PathRegex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TC_Attribute = new System.Windows.Forms.TabPage();
            this.RB_IsDirectory = new System.Windows.Forms.RadioButton();
            this.RB_IsFile = new System.Windows.Forms.RadioButton();
            this.RB_System = new System.Windows.Forms.RadioButton();
            this.RB_ReadOnly = new System.Windows.Forms.RadioButton();
            this.RB_Archive = new System.Windows.Forms.RadioButton();
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
            this.B_Remove = new System.Windows.Forms.Button();
            this.B_AddNext = new System.Windows.Forms.Button();
            this.B_AddChild = new System.Windows.Forms.Button();
            this.B_EditFilter = new System.Windows.Forms.Button();
            this.TV_FiltersView = new System.Windows.Forms.TreeView();
            this.B_SimulateBackup = new System.Windows.Forms.Button();
            this.GB_GlobalSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NumberOfBackups)).BeginInit();
            this.GB_Filters.SuspendLayout();
            this.GB_FiltersOptions.SuspendLayout();
            this.TC_Filters.SuspendLayout();
            this.TC_Aggregation.SuspendLayout();
            this.TC_FilePath.SuspendLayout();
            this.TC_Attribute.SuspendLayout();
            this.TC_DateTime.SuspendLayout();
            this.TC_Size.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Number)).BeginInit();
            this.SuspendLayout();
            // 
            // L_RootPath
            // 
            this.L_RootPath.AutoSize = true;
            this.L_RootPath.Location = new System.Drawing.Point(13, 22);
            this.L_RootPath.Name = "L_RootPath";
            this.L_RootPath.Size = new System.Drawing.Size(58, 13);
            this.L_RootPath.TabIndex = 0;
            this.L_RootPath.Text = "Root Path:";
            // 
            // TB_RootPath
            // 
            this.TB_RootPath.Location = new System.Drawing.Point(98, 19);
            this.TB_RootPath.Name = "TB_RootPath";
            this.TB_RootPath.ReadOnly = true;
            this.TB_RootPath.Size = new System.Drawing.Size(358, 20);
            this.TB_RootPath.TabIndex = 1;
            // 
            // B_RootPathLoader
            // 
            this.B_RootPathLoader.BackColor = System.Drawing.Color.White;
            this.B_RootPathLoader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_RootPathLoader.BackgroundImage")));
            this.B_RootPathLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_RootPathLoader.Location = new System.Drawing.Point(462, 12);
            this.B_RootPathLoader.Name = "B_RootPathLoader";
            this.B_RootPathLoader.Size = new System.Drawing.Size(28, 33);
            this.B_RootPathLoader.TabIndex = 2;
            this.B_RootPathLoader.UseVisualStyleBackColor = false;
            this.B_RootPathLoader.Click += new System.EventHandler(this.B_path_Click);
            // 
            // GB_GlobalSettings
            // 
            this.GB_GlobalSettings.Controls.Add(this.NUD_NumberOfBackups);
            this.GB_GlobalSettings.Controls.Add(this.label5);
            this.GB_GlobalSettings.Controls.Add(this.TB_DestinationPath);
            this.GB_GlobalSettings.Controls.Add(this.B_DestionationPathLoader);
            this.GB_GlobalSettings.Controls.Add(this.label4);
            this.GB_GlobalSettings.Controls.Add(this.TB_RootPath);
            this.GB_GlobalSettings.Controls.Add(this.B_RootPathLoader);
            this.GB_GlobalSettings.Controls.Add(this.L_RootPath);
            this.GB_GlobalSettings.Location = new System.Drawing.Point(13, 13);
            this.GB_GlobalSettings.Name = "GB_GlobalSettings";
            this.GB_GlobalSettings.Size = new System.Drawing.Size(952, 100);
            this.GB_GlobalSettings.TabIndex = 3;
            this.GB_GlobalSettings.TabStop = false;
            this.GB_GlobalSettings.Text = "Global settings";
            // 
            // NUD_NumberOfBackups
            // 
            this.NUD_NumberOfBackups.Location = new System.Drawing.Point(657, 18);
            this.NUD_NumberOfBackups.Name = "NUD_NumberOfBackups";
            this.NUD_NumberOfBackups.Size = new System.Drawing.Size(120, 20);
            this.NUD_NumberOfBackups.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number of old backups:";
            // 
            // TB_DestinationPath
            // 
            this.TB_DestinationPath.Location = new System.Drawing.Point(98, 55);
            this.TB_DestinationPath.Name = "TB_DestinationPath";
            this.TB_DestinationPath.ReadOnly = true;
            this.TB_DestinationPath.Size = new System.Drawing.Size(358, 20);
            this.TB_DestinationPath.TabIndex = 4;
            // 
            // B_DestionationPathLoader
            // 
            this.B_DestionationPathLoader.BackColor = System.Drawing.Color.White;
            this.B_DestionationPathLoader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_DestionationPathLoader.BackgroundImage")));
            this.B_DestionationPathLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_DestionationPathLoader.Location = new System.Drawing.Point(462, 48);
            this.B_DestionationPathLoader.Name = "B_DestionationPathLoader";
            this.B_DestionationPathLoader.Size = new System.Drawing.Size(28, 33);
            this.B_DestionationPathLoader.TabIndex = 5;
            this.B_DestionationPathLoader.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Destination path:";
            // 
            // GB_Filters
            // 
            this.GB_Filters.Controls.Add(this.B_SimulateBackup);
            this.GB_Filters.Controls.Add(this.GB_FiltersOptions);
            this.GB_Filters.Controls.Add(this.B_Remove);
            this.GB_Filters.Controls.Add(this.B_AddNext);
            this.GB_Filters.Controls.Add(this.B_AddChild);
            this.GB_Filters.Controls.Add(this.B_EditFilter);
            this.GB_Filters.Controls.Add(this.TV_FiltersView);
            this.GB_Filters.Location = new System.Drawing.Point(13, 129);
            this.GB_Filters.Name = "GB_Filters";
            this.GB_Filters.Size = new System.Drawing.Size(952, 439);
            this.GB_Filters.TabIndex = 4;
            this.GB_Filters.TabStop = false;
            this.GB_Filters.Text = "Filters:";
            // 
            // GB_FiltersOptions
            // 
            this.GB_FiltersOptions.Controls.Add(this.TB_NameOfFilter);
            this.GB_FiltersOptions.Controls.Add(this.label3);
            this.GB_FiltersOptions.Controls.Add(this.ChB_Negate);
            this.GB_FiltersOptions.Controls.Add(this.TC_Filters);
            this.GB_FiltersOptions.Location = new System.Drawing.Point(360, 35);
            this.GB_FiltersOptions.Name = "GB_FiltersOptions";
            this.GB_FiltersOptions.Size = new System.Drawing.Size(571, 385);
            this.GB_FiltersOptions.TabIndex = 5;
            this.GB_FiltersOptions.TabStop = false;
            // 
            // TB_NameOfFilter
            // 
            this.TB_NameOfFilter.Location = new System.Drawing.Point(248, 334);
            this.TB_NameOfFilter.Name = "TB_NameOfFilter";
            this.TB_NameOfFilter.Size = new System.Drawing.Size(133, 20);
            this.TB_NameOfFilter.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Comment/Name";
            // 
            // ChB_Negate
            // 
            this.ChB_Negate.AutoSize = true;
            this.ChB_Negate.Location = new System.Drawing.Point(25, 337);
            this.ChB_Negate.Name = "ChB_Negate";
            this.ChB_Negate.Size = new System.Drawing.Size(61, 17);
            this.ChB_Negate.TabIndex = 6;
            this.ChB_Negate.Text = "Negate";
            this.ChB_Negate.UseVisualStyleBackColor = true;
            // 
            // TC_Filters
            // 
            this.TC_Filters.Controls.Add(this.TC_Aggregation);
            this.TC_Filters.Controls.Add(this.TC_FilePath);
            this.TC_Filters.Controls.Add(this.TC_Attribute);
            this.TC_Filters.Controls.Add(this.TC_DateTime);
            this.TC_Filters.Controls.Add(this.TC_Size);
            this.TC_Filters.Location = new System.Drawing.Point(21, 30);
            this.TC_Filters.Name = "TC_Filters";
            this.TC_Filters.SelectedIndex = 0;
            this.TC_Filters.Size = new System.Drawing.Size(483, 300);
            this.TC_Filters.TabIndex = 5;
            // 
            // TC_Aggregation
            // 
            this.TC_Aggregation.Controls.Add(this.RB_OR);
            this.TC_Aggregation.Controls.Add(this.RB_And);
            this.TC_Aggregation.Location = new System.Drawing.Point(4, 22);
            this.TC_Aggregation.Name = "TC_Aggregation";
            this.TC_Aggregation.Padding = new System.Windows.Forms.Padding(3);
            this.TC_Aggregation.Size = new System.Drawing.Size(475, 274);
            this.TC_Aggregation.TabIndex = 0;
            this.TC_Aggregation.Text = "Aggregation";
            this.TC_Aggregation.UseVisualStyleBackColor = true;
            // 
            // RB_OR
            // 
            this.RB_OR.AutoSize = true;
            this.RB_OR.Location = new System.Drawing.Point(16, 44);
            this.RB_OR.Name = "RB_OR";
            this.RB_OR.Size = new System.Drawing.Size(183, 17);
            this.RB_OR.TabIndex = 1;
            this.RB_OR.TabStop = true;
            this.RB_OR.Text = "Or (at least one sub-filter satisfied)";
            this.RB_OR.UseVisualStyleBackColor = true;
            // 
            // RB_And
            // 
            this.RB_And.AutoSize = true;
            this.RB_And.Location = new System.Drawing.Point(16, 14);
            this.RB_And.Name = "RB_And";
            this.RB_And.Size = new System.Drawing.Size(151, 17);
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
            this.TC_FilePath.Name = "TC_FilePath";
            this.TC_FilePath.Padding = new System.Windows.Forms.Padding(3);
            this.TC_FilePath.Size = new System.Drawing.Size(475, 274);
            this.TC_FilePath.TabIndex = 1;
            this.TC_FilePath.Text = "File-Path";
            this.TC_FilePath.UseVisualStyleBackColor = true;
            // 
            // TB_PathRegex
            // 
            this.TB_PathRegex.Location = new System.Drawing.Point(32, 40);
            this.TB_PathRegex.Name = "TB_PathRegex";
            this.TB_PathRegex.Size = new System.Drawing.Size(314, 20);
            this.TB_PathRegex.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path regular expression:";
            // 
            // TC_Attribute
            // 
            this.TC_Attribute.Controls.Add(this.RB_IsDirectory);
            this.TC_Attribute.Controls.Add(this.RB_IsFile);
            this.TC_Attribute.Controls.Add(this.RB_System);
            this.TC_Attribute.Controls.Add(this.RB_ReadOnly);
            this.TC_Attribute.Controls.Add(this.RB_Archive);
            this.TC_Attribute.Controls.Add(this.label2);
            this.TC_Attribute.Location = new System.Drawing.Point(4, 22);
            this.TC_Attribute.Name = "TC_Attribute";
            this.TC_Attribute.Padding = new System.Windows.Forms.Padding(3);
            this.TC_Attribute.Size = new System.Drawing.Size(475, 274);
            this.TC_Attribute.TabIndex = 2;
            this.TC_Attribute.Text = "Attribute";
            this.TC_Attribute.UseVisualStyleBackColor = true;
            // 
            // RB_IsDirectory
            // 
            this.RB_IsDirectory.AutoSize = true;
            this.RB_IsDirectory.Location = new System.Drawing.Point(56, 133);
            this.RB_IsDirectory.Name = "RB_IsDirectory";
            this.RB_IsDirectory.Size = new System.Drawing.Size(78, 17);
            this.RB_IsDirectory.TabIndex = 5;
            this.RB_IsDirectory.TabStop = true;
            this.RB_IsDirectory.Text = "Is Directory";
            this.RB_IsDirectory.UseVisualStyleBackColor = true;
            // 
            // RB_IsFile
            // 
            this.RB_IsFile.AutoSize = true;
            this.RB_IsFile.Location = new System.Drawing.Point(56, 110);
            this.RB_IsFile.Name = "RB_IsFile";
            this.RB_IsFile.Size = new System.Drawing.Size(52, 17);
            this.RB_IsFile.TabIndex = 4;
            this.RB_IsFile.TabStop = true;
            this.RB_IsFile.Text = "Is File";
            this.RB_IsFile.UseVisualStyleBackColor = true;
            // 
            // RB_System
            // 
            this.RB_System.AutoSize = true;
            this.RB_System.Location = new System.Drawing.Point(56, 87);
            this.RB_System.Name = "RB_System";
            this.RB_System.Size = new System.Drawing.Size(59, 17);
            this.RB_System.TabIndex = 3;
            this.RB_System.TabStop = true;
            this.RB_System.Text = "System";
            this.RB_System.UseVisualStyleBackColor = true;
            // 
            // RB_ReadOnly
            // 
            this.RB_ReadOnly.AutoSize = true;
            this.RB_ReadOnly.Location = new System.Drawing.Point(56, 64);
            this.RB_ReadOnly.Name = "RB_ReadOnly";
            this.RB_ReadOnly.Size = new System.Drawing.Size(75, 17);
            this.RB_ReadOnly.TabIndex = 2;
            this.RB_ReadOnly.TabStop = true;
            this.RB_ReadOnly.Text = "Read-Only";
            this.RB_ReadOnly.UseVisualStyleBackColor = true;
            // 
            // RB_Archive
            // 
            this.RB_Archive.AutoSize = true;
            this.RB_Archive.Location = new System.Drawing.Point(56, 41);
            this.RB_Archive.Name = "RB_Archive";
            this.RB_Archive.Size = new System.Drawing.Size(61, 17);
            this.RB_Archive.TabIndex = 1;
            this.RB_Archive.TabStop = true;
            this.RB_Archive.Text = "Archive";
            this.RB_Archive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
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
            this.TC_DateTime.Name = "TC_DateTime";
            this.TC_DateTime.Padding = new System.Windows.Forms.Padding(3);
            this.TC_DateTime.Size = new System.Drawing.Size(475, 274);
            this.TC_DateTime.TabIndex = 3;
            this.TC_DateTime.Text = "Date-Time";
            this.TC_DateTime.UseVisualStyleBackColor = true;
            // 
            // CB_DateBeforeAfter
            // 
            this.CB_DateBeforeAfter.DisplayMember = "1";
            this.CB_DateBeforeAfter.FormattingEnabled = true;
            this.CB_DateBeforeAfter.Items.AddRange(new object[] {
            "This date",
            "Before date",
            "After date"});
            this.CB_DateBeforeAfter.Location = new System.Drawing.Point(231, 98);
            this.CB_DateBeforeAfter.Name = "CB_DateBeforeAfter";
            this.CB_DateBeforeAfter.Size = new System.Drawing.Size(121, 21);
            this.CB_DateBeforeAfter.TabIndex = 4;
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(24, 98);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(200, 20);
            this.DTP_Date.TabIndex = 3;
            this.DTP_Date.Value = new System.DateTime(2021, 11, 19, 17, 11, 34, 0);
            // 
            // RB_LastAccessDateTime
            // 
            this.RB_LastAccessDateTime.AutoSize = true;
            this.RB_LastAccessDateTime.Location = new System.Drawing.Point(24, 59);
            this.RB_LastAccessDateTime.Name = "RB_LastAccessDateTime";
            this.RB_LastAccessDateTime.Size = new System.Drawing.Size(135, 17);
            this.RB_LastAccessDateTime.TabIndex = 2;
            this.RB_LastAccessDateTime.TabStop = true;
            this.RB_LastAccessDateTime.Text = "Last Access Date Time";
            this.RB_LastAccessDateTime.UseVisualStyleBackColor = true;
            // 
            // RB_LastWriteDateTime
            // 
            this.RB_LastWriteDateTime.AutoSize = true;
            this.RB_LastWriteDateTime.Location = new System.Drawing.Point(24, 36);
            this.RB_LastWriteDateTime.Name = "RB_LastWriteDateTime";
            this.RB_LastWriteDateTime.Size = new System.Drawing.Size(125, 17);
            this.RB_LastWriteDateTime.TabIndex = 1;
            this.RB_LastWriteDateTime.TabStop = true;
            this.RB_LastWriteDateTime.Text = "Last Write Date Time";
            this.RB_LastWriteDateTime.UseVisualStyleBackColor = true;
            // 
            // RB_CreationDateTime
            // 
            this.RB_CreationDateTime.AutoSize = true;
            this.RB_CreationDateTime.Location = new System.Drawing.Point(24, 13);
            this.RB_CreationDateTime.Name = "RB_CreationDateTime";
            this.RB_CreationDateTime.Size = new System.Drawing.Size(116, 17);
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
            this.TC_Size.Name = "TC_Size";
            this.TC_Size.Padding = new System.Windows.Forms.Padding(3);
            this.TC_Size.Size = new System.Drawing.Size(475, 274);
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
            this.panel1.Location = new System.Drawing.Point(151, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 100);
            this.panel1.TabIndex = 9;
            // 
            // RB_Size_B
            // 
            this.RB_Size_B.AutoSize = true;
            this.RB_Size_B.Location = new System.Drawing.Point(3, 3);
            this.RB_Size_B.Name = "RB_Size_B";
            this.RB_Size_B.Size = new System.Drawing.Size(31, 17);
            this.RB_Size_B.TabIndex = 2;
            this.RB_Size_B.TabStop = true;
            this.RB_Size_B.Text = "b";
            this.RB_Size_B.UseVisualStyleBackColor = true;
            // 
            // RB_Size_MB
            // 
            this.RB_Size_MB.AutoSize = true;
            this.RB_Size_MB.Location = new System.Drawing.Point(3, 49);
            this.RB_Size_MB.Name = "RB_Size_MB";
            this.RB_Size_MB.Size = new System.Drawing.Size(41, 17);
            this.RB_Size_MB.TabIndex = 4;
            this.RB_Size_MB.TabStop = true;
            this.RB_Size_MB.Text = "MB";
            this.RB_Size_MB.UseVisualStyleBackColor = true;
            // 
            // RB_Size_kB
            // 
            this.RB_Size_kB.AutoSize = true;
            this.RB_Size_kB.Location = new System.Drawing.Point(3, 26);
            this.RB_Size_kB.Name = "RB_Size_kB";
            this.RB_Size_kB.Size = new System.Drawing.Size(38, 17);
            this.RB_Size_kB.TabIndex = 3;
            this.RB_Size_kB.TabStop = true;
            this.RB_Size_kB.Text = "kB";
            this.RB_Size_kB.UseVisualStyleBackColor = true;
            // 
            // RB_Size_GB
            // 
            this.RB_Size_GB.AutoSize = true;
            this.RB_Size_GB.Location = new System.Drawing.Point(3, 72);
            this.RB_Size_GB.Name = "RB_Size_GB";
            this.RB_Size_GB.Size = new System.Drawing.Size(40, 17);
            this.RB_Size_GB.TabIndex = 5;
            this.RB_Size_GB.TabStop = true;
            this.RB_Size_GB.Text = "GB";
            this.RB_Size_GB.UseVisualStyleBackColor = true;
            // 
            // NUD_Number
            // 
            this.NUD_Number.Location = new System.Drawing.Point(25, 78);
            this.NUD_Number.Name = "NUD_Number";
            this.NUD_Number.Size = new System.Drawing.Size(120, 20);
            this.NUD_Number.TabIndex = 7;
            // 
            // RB_Maximal
            // 
            this.RB_Maximal.AutoSize = true;
            this.RB_Maximal.Location = new System.Drawing.Point(25, 44);
            this.RB_Maximal.Name = "RB_Maximal";
            this.RB_Maximal.Size = new System.Drawing.Size(84, 17);
            this.RB_Maximal.TabIndex = 1;
            this.RB_Maximal.Text = "Maximal size";
            this.RB_Maximal.UseVisualStyleBackColor = true;
            // 
            // RB_Minimal
            // 
            this.RB_Minimal.AutoSize = true;
            this.RB_Minimal.Checked = true;
            this.RB_Minimal.Location = new System.Drawing.Point(25, 14);
            this.RB_Minimal.Name = "RB_Minimal";
            this.RB_Minimal.Size = new System.Drawing.Size(81, 17);
            this.RB_Minimal.TabIndex = 0;
            this.RB_Minimal.TabStop = true;
            this.RB_Minimal.Text = "Minimal size";
            this.RB_Minimal.UseVisualStyleBackColor = true;
            // 
            // B_Remove
            // 
            this.B_Remove.Location = new System.Drawing.Point(249, 125);
            this.B_Remove.Name = "B_Remove";
            this.B_Remove.Size = new System.Drawing.Size(75, 23);
            this.B_Remove.TabIndex = 4;
            this.B_Remove.Text = "Remove";
            this.B_Remove.UseVisualStyleBackColor = true;
            this.B_Remove.Click += new System.EventHandler(this.B_Remove_Click);
            // 
            // B_AddNext
            // 
            this.B_AddNext.Location = new System.Drawing.Point(249, 95);
            this.B_AddNext.Name = "B_AddNext";
            this.B_AddNext.Size = new System.Drawing.Size(75, 23);
            this.B_AddNext.TabIndex = 3;
            this.B_AddNext.Text = "Add next";
            this.B_AddNext.UseVisualStyleBackColor = true;
            this.B_AddNext.Click += new System.EventHandler(this.B_AddNext_Click);
            // 
            // B_AddChild
            // 
            this.B_AddChild.Location = new System.Drawing.Point(249, 65);
            this.B_AddChild.Name = "B_AddChild";
            this.B_AddChild.Size = new System.Drawing.Size(75, 23);
            this.B_AddChild.TabIndex = 2;
            this.B_AddChild.Text = "Add child";
            this.B_AddChild.UseVisualStyleBackColor = true;
            this.B_AddChild.Click += new System.EventHandler(this.B_AddChild_Click);
            // 
            // B_EditFilter
            // 
            this.B_EditFilter.Location = new System.Drawing.Point(249, 35);
            this.B_EditFilter.Name = "B_EditFilter";
            this.B_EditFilter.Size = new System.Drawing.Size(75, 23);
            this.B_EditFilter.TabIndex = 1;
            this.B_EditFilter.Text = "Edit";
            this.B_EditFilter.UseVisualStyleBackColor = true;
            this.B_EditFilter.Click += new System.EventHandler(this.B_EditFilter_Click);
            // 
            // TV_FiltersView
            // 
            this.TV_FiltersView.HideSelection = false;
            this.TV_FiltersView.Location = new System.Drawing.Point(16, 35);
            this.TV_FiltersView.Name = "TV_FiltersView";
            this.TV_FiltersView.Size = new System.Drawing.Size(226, 398);
            this.TV_FiltersView.TabIndex = 0;
            this.TV_FiltersView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV_FiltersView_AfterSelect);
            // 
            // B_SimulateBackup
            // 
            this.B_SimulateBackup.Location = new System.Drawing.Point(249, 397);
            this.B_SimulateBackup.Name = "B_SimulateBackup";
            this.B_SimulateBackup.Size = new System.Drawing.Size(105, 23);
            this.B_SimulateBackup.TabIndex = 6;
            this.B_SimulateBackup.Text = "Simulate Backup";
            this.B_SimulateBackup.UseVisualStyleBackColor = true;
            this.B_SimulateBackup.Click += new System.EventHandler(this.B_SimulateBackup_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 580);
            this.Controls.Add(this.GB_Filters);
            this.Controls.Add(this.GB_GlobalSettings);
            this.Name = "mainPage";
            this.Text = "Demo Zalohovaci nastroj";
            this.GB_GlobalSettings.ResumeLayout(false);
            this.GB_GlobalSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NumberOfBackups)).EndInit();
            this.GB_Filters.ResumeLayout(false);
            this.GB_FiltersOptions.ResumeLayout(false);
            this.GB_FiltersOptions.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label L_RootPath;
        private System.Windows.Forms.TextBox TB_RootPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button B_RootPathLoader;
        private System.Windows.Forms.GroupBox GB_GlobalSettings;
        private System.Windows.Forms.GroupBox GB_Filters;
        private System.Windows.Forms.Button B_Remove;
        private System.Windows.Forms.Button B_AddNext;
        private System.Windows.Forms.Button B_AddChild;
        private System.Windows.Forms.Button B_EditFilter;
        private System.Windows.Forms.TreeView TV_FiltersView;
        private System.Windows.Forms.GroupBox GB_FiltersOptions;
        private System.Windows.Forms.TabControl TC_Filters;
        private System.Windows.Forms.TabPage TC_Aggregation;
        private System.Windows.Forms.RadioButton RB_OR;
        private System.Windows.Forms.RadioButton RB_And;
        private System.Windows.Forms.TabPage TC_FilePath;
        private System.Windows.Forms.TextBox TB_PathRegex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TC_Attribute;
        private System.Windows.Forms.RadioButton RB_IsDirectory;
        private System.Windows.Forms.RadioButton RB_IsFile;
        private System.Windows.Forms.RadioButton RB_System;
        private System.Windows.Forms.RadioButton RB_ReadOnly;
        private System.Windows.Forms.RadioButton RB_Archive;
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
    }
}

