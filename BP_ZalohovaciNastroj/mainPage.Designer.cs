
namespace BP_ZalohovaciNastroj
{
    partial class mainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.L_RootPath = new System.Windows.Forms.Label();
            this.TB_path = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.B_RootPathLoader = new System.Windows.Forms.Button();
            this.GB_GlobalSettings = new System.Windows.Forms.GroupBox();
            this.GB_Filters = new System.Windows.Forms.GroupBox();
            this.GB_FiltersOptions = new System.Windows.Forms.GroupBox();
            this.TC_Filters = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RB_OR = new System.Windows.Forms.RadioButton();
            this.RB_And = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TB_PathRegex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RB_IsDirectory = new System.Windows.Forms.RadioButton();
            this.RB_IsFile = new System.Windows.Forms.RadioButton();
            this.RB_System = new System.Windows.Forms.RadioButton();
            this.RB_ReadOnly = new System.Windows.Forms.RadioButton();
            this.RB_Archive = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CB_DateBeforeAfter = new System.Windows.Forms.ComboBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.RB_LastAccessDateTime = new System.Windows.Forms.RadioButton();
            this.RB_LastWriteDateTime = new System.Windows.Forms.RadioButton();
            this.RB_CreationDateTime = new System.Windows.Forms.RadioButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.B_Remove = new System.Windows.Forms.Button();
            this.B_AddNextFilter = new System.Windows.Forms.Button();
            this.B_AddChild = new System.Windows.Forms.Button();
            this.B_EditFilter = new System.Windows.Forms.Button();
            this.TV_FiltersView = new System.Windows.Forms.TreeView();
            this.ChB_Negate = new System.Windows.Forms.CheckBox();
            this.RB_Minimal = new System.Windows.Forms.RadioButton();
            this.RB_Maximal = new System.Windows.Forms.RadioButton();
            this.RB_Size_B = new System.Windows.Forms.RadioButton();
            this.RB_Size_kB = new System.Windows.Forms.RadioButton();
            this.RB_Size_MB = new System.Windows.Forms.RadioButton();
            this.RB_Size_GB = new System.Windows.Forms.RadioButton();
            this.NUD_Number = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_NameOfFilter = new System.Windows.Forms.TextBox();
            this.GB_GlobalSettings.SuspendLayout();
            this.GB_Filters.SuspendLayout();
            this.GB_FiltersOptions.SuspendLayout();
            this.TC_Filters.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Number)).BeginInit();
            this.panel1.SuspendLayout();
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
            // TB_path
            // 
            this.TB_path.Location = new System.Drawing.Point(77, 19);
            this.TB_path.Name = "TB_path";
            this.TB_path.Size = new System.Drawing.Size(358, 20);
            this.TB_path.TabIndex = 1;
            // 
            // B_RootPathLoader
            // 
            this.B_RootPathLoader.BackColor = System.Drawing.Color.White;
            this.B_RootPathLoader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_RootPathLoader.BackgroundImage")));
            this.B_RootPathLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_RootPathLoader.Location = new System.Drawing.Point(441, 12);
            this.B_RootPathLoader.Name = "B_RootPathLoader";
            this.B_RootPathLoader.Size = new System.Drawing.Size(28, 33);
            this.B_RootPathLoader.TabIndex = 2;
            this.B_RootPathLoader.UseVisualStyleBackColor = false;
            this.B_RootPathLoader.Click += new System.EventHandler(this.B_path_Click);
            // 
            // GB_GlobalSettings
            // 
            this.GB_GlobalSettings.Controls.Add(this.TB_path);
            this.GB_GlobalSettings.Controls.Add(this.B_RootPathLoader);
            this.GB_GlobalSettings.Controls.Add(this.L_RootPath);
            this.GB_GlobalSettings.Location = new System.Drawing.Point(13, 13);
            this.GB_GlobalSettings.Name = "GB_GlobalSettings";
            this.GB_GlobalSettings.Size = new System.Drawing.Size(952, 100);
            this.GB_GlobalSettings.TabIndex = 3;
            this.GB_GlobalSettings.TabStop = false;
            this.GB_GlobalSettings.Text = "Global settings";
            // 
            // GB_Filters
            // 
            this.GB_Filters.Controls.Add(this.GB_FiltersOptions);
            this.GB_Filters.Controls.Add(this.B_Remove);
            this.GB_Filters.Controls.Add(this.B_AddNextFilter);
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
            // TC_Filters
            // 
            this.TC_Filters.Controls.Add(this.tabPage1);
            this.TC_Filters.Controls.Add(this.tabPage2);
            this.TC_Filters.Controls.Add(this.tabPage3);
            this.TC_Filters.Controls.Add(this.tabPage4);
            this.TC_Filters.Controls.Add(this.tabPage5);
            this.TC_Filters.Location = new System.Drawing.Point(21, 30);
            this.TC_Filters.Name = "TC_Filters";
            this.TC_Filters.SelectedIndex = 0;
            this.TC_Filters.Size = new System.Drawing.Size(483, 300);
            this.TC_Filters.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RB_OR);
            this.tabPage1.Controls.Add(this.RB_And);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(475, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aggregation";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TB_PathRegex);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(475, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File-Path";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RB_IsDirectory);
            this.tabPage3.Controls.Add(this.RB_IsFile);
            this.tabPage3.Controls.Add(this.RB_System);
            this.tabPage3.Controls.Add(this.RB_ReadOnly);
            this.tabPage3.Controls.Add(this.RB_Archive);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(475, 274);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Attribute";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.CB_DateBeforeAfter);
            this.tabPage4.Controls.Add(this.DTP_Date);
            this.tabPage4.Controls.Add(this.RB_LastAccessDateTime);
            this.tabPage4.Controls.Add(this.RB_LastWriteDateTime);
            this.tabPage4.Controls.Add(this.RB_CreationDateTime);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(475, 274);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Date-Time";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel1);
            this.tabPage5.Controls.Add(this.NUD_Number);
            this.tabPage5.Controls.Add(this.RB_Maximal);
            this.tabPage5.Controls.Add(this.RB_Minimal);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(475, 274);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Size";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // B_Remove
            // 
            this.B_Remove.Location = new System.Drawing.Point(249, 125);
            this.B_Remove.Name = "B_Remove";
            this.B_Remove.Size = new System.Drawing.Size(75, 23);
            this.B_Remove.TabIndex = 4;
            this.B_Remove.Text = "Remove";
            this.B_Remove.UseVisualStyleBackColor = true;
            // 
            // B_AddNextFilter
            // 
            this.B_AddNextFilter.Location = new System.Drawing.Point(249, 95);
            this.B_AddNextFilter.Name = "B_AddNextFilter";
            this.B_AddNextFilter.Size = new System.Drawing.Size(75, 23);
            this.B_AddNextFilter.TabIndex = 3;
            this.B_AddNextFilter.Text = "Add next";
            this.B_AddNextFilter.UseVisualStyleBackColor = true;
            // 
            // B_AddChild
            // 
            this.B_AddChild.Location = new System.Drawing.Point(249, 65);
            this.B_AddChild.Name = "B_AddChild";
            this.B_AddChild.Size = new System.Drawing.Size(75, 23);
            this.B_AddChild.TabIndex = 2;
            this.B_AddChild.Text = "Add child";
            this.B_AddChild.UseVisualStyleBackColor = true;
            // 
            // B_EditFilter
            // 
            this.B_EditFilter.Location = new System.Drawing.Point(249, 35);
            this.B_EditFilter.Name = "B_EditFilter";
            this.B_EditFilter.Size = new System.Drawing.Size(75, 23);
            this.B_EditFilter.TabIndex = 1;
            this.B_EditFilter.Text = "Edit";
            this.B_EditFilter.UseVisualStyleBackColor = true;
            // 
            // TV_FiltersView
            // 
            this.TV_FiltersView.Location = new System.Drawing.Point(16, 35);
            this.TV_FiltersView.Name = "TV_FiltersView";
            this.TV_FiltersView.Size = new System.Drawing.Size(226, 398);
            this.TV_FiltersView.TabIndex = 0;
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
            // RB_Minimal
            // 
            this.RB_Minimal.AutoSize = true;
            this.RB_Minimal.Location = new System.Drawing.Point(25, 14);
            this.RB_Minimal.Name = "RB_Minimal";
            this.RB_Minimal.Size = new System.Drawing.Size(81, 17);
            this.RB_Minimal.TabIndex = 0;
            this.RB_Minimal.TabStop = true;
            this.RB_Minimal.Text = "Minimal size";
            this.RB_Minimal.UseVisualStyleBackColor = true;
            // 
            // RB_Maximal
            // 
            this.RB_Maximal.AutoSize = true;
            this.RB_Maximal.Location = new System.Drawing.Point(25, 44);
            this.RB_Maximal.Name = "RB_Maximal";
            this.RB_Maximal.Size = new System.Drawing.Size(84, 17);
            this.RB_Maximal.TabIndex = 1;
            this.RB_Maximal.TabStop = true;
            this.RB_Maximal.Text = "Maximal size";
            this.RB_Maximal.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Comment/Name";
            // 
            // TB_NameOfFilter
            // 
            this.TB_NameOfFilter.Location = new System.Drawing.Point(248, 334);
            this.TB_NameOfFilter.Name = "TB_NameOfFilter";
            this.TB_NameOfFilter.Size = new System.Drawing.Size(133, 20);
            this.TB_NameOfFilter.TabIndex = 8;
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
            this.GB_Filters.ResumeLayout(false);
            this.GB_FiltersOptions.ResumeLayout(false);
            this.GB_FiltersOptions.PerformLayout();
            this.TC_Filters.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Number)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label L_RootPath;
        private System.Windows.Forms.TextBox TB_path;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button B_RootPathLoader;
        private System.Windows.Forms.GroupBox GB_GlobalSettings;
        private System.Windows.Forms.GroupBox GB_Filters;
        private System.Windows.Forms.Button B_Remove;
        private System.Windows.Forms.Button B_AddNextFilter;
        private System.Windows.Forms.Button B_AddChild;
        private System.Windows.Forms.Button B_EditFilter;
        private System.Windows.Forms.TreeView TV_FiltersView;
        private System.Windows.Forms.GroupBox GB_FiltersOptions;
        private System.Windows.Forms.TabControl TC_Filters;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton RB_OR;
        private System.Windows.Forms.RadioButton RB_And;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TB_PathRegex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton RB_IsDirectory;
        private System.Windows.Forms.RadioButton RB_IsFile;
        private System.Windows.Forms.RadioButton RB_System;
        private System.Windows.Forms.RadioButton RB_ReadOnly;
        private System.Windows.Forms.RadioButton RB_Archive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox CB_DateBeforeAfter;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.RadioButton RB_LastAccessDateTime;
        private System.Windows.Forms.RadioButton RB_LastWriteDateTime;
        private System.Windows.Forms.RadioButton RB_CreationDateTime;
        private System.Windows.Forms.TabPage tabPage5;
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
    }
}

