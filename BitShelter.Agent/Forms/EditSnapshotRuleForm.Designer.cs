namespace BitShelter.Agent.Forms
{
  partial class EditSnapshotRuleForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.lblName = new System.Windows.Forms.Label();
      this.tbName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
      this.cbEnabled = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
      this.btnCreate = new Syncfusion.Windows.Forms.ButtonAdv();
      this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
      this.lblGenSched = new System.Windows.Forms.Label();
      this.lblHumanSched = new System.Windows.Forms.Label();
      this.tbGenCron = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
      this.lblGenCron = new System.Windows.Forms.Label();
      this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
      this.tpSnapshot = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
      this.btnSystemProtection = new System.Windows.Forms.Button();
      this.lblSnapLimitCount = new System.Windows.Forms.Label();
      this.lblSnapLimit = new System.Windows.Forms.Label();
      this.btnSnapLimitChange = new System.Windows.Forms.Button();
      this.cblDriveLetters = new EWSoftware.ListControls.CheckBoxList();
      this.cbLifetime = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
      this.nbLifetime = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
      this.lblDriveLetters = new System.Windows.Forms.Label();
      this.lblLifetimeHelp = new System.Windows.Forms.Label();
      this.lblLifetime = new System.Windows.Forms.Label();
      this.tpSchedule = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
      this.gbPeriod = new System.Windows.Forms.GroupBox();
      this.dtpPeriodEnd = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
      this.rbPeriodEndDate = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
      this.rbPeriodEndNever = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
      this.lblPeriodEnd = new System.Windows.Forms.Label();
      this.dtpPeriodStart = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
      this.lblPeriodStart = new System.Windows.Forms.Label();
      this.gbFreq = new System.Windows.Forms.GroupBox();
      this.plFreqCron = new System.Windows.Forms.Panel();
      this.cbFreqCronExcluding = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
      this.dtpFreqCronExcludingTo = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
      this.dtpFreqCronExcludingFrom = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
      this.lblFreqCronEnd = new System.Windows.Forms.Label();
      this.lblFreqCronStart = new System.Windows.Forms.Label();
      this.lblFreqCronHelp = new System.Windows.Forms.Label();
      this.llbFreqCronGen = new System.Windows.Forms.LinkLabel();
      this.llbFreqCronHelp = new System.Windows.Forms.LinkLabel();
      this.tbFreqCron = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
      this.lblFreqCron = new System.Windows.Forms.Label();
      this.plFreqMonthly = new System.Windows.Forms.Panel();
      this.cblFreqMonthlyDays = new EWSoftware.ListControls.CheckBoxList();
      this.lblFreqMonthlyDays = new System.Windows.Forms.Label();
      this.cblFreqMonthlyMonths = new EWSoftware.ListControls.CheckBoxList();
      this.lblFreqMonthlyMonths = new System.Windows.Forms.Label();
      this.rbFreqCron = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
      this.plFreqWeekly = new System.Windows.Forms.Panel();
      this.rbFreqWeeklyOn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
      this.rbFreqWeeklyEvery = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
      this.cbFreqWeeklySaturday = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
      this.cbFreqWeeklyFriday = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
      this.cbFreqWeeklyThursday = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
      this.cbFreqWeeklyWednesday = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
      this.cbFreqWeeklyTuesday = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
      this.cbFreqWeeklyMonday = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
      this.cbFreqWeeklySunday = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
      this.lblFreqWeeklyWeeks = new System.Windows.Forms.Label();
      this.nbFreqWeekly = new System.Windows.Forms.NumericUpDown();
      this.plFreqDaily = new System.Windows.Forms.Panel();
      this.lblFreqDailyDays = new System.Windows.Forms.Label();
      this.nbFreqDaily = new System.Windows.Forms.NumericUpDown();
      this.lblFreqDailyEvery = new System.Windows.Forms.Label();
      this.rbFreqMonthly = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
      this.rbFreqWeekly = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
      this.rbFreqDaily = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
      this.gbDailyFreq = new System.Windows.Forms.GroupBox();
      this.cbDailyFreqEveryExcluding = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
      this.dtpDailyFreqEveryExcludingTo = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
      this.dtpDailyFreqEveryExcludingFrom = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
      this.lblDailyFreqEveryEndAt = new System.Windows.Forms.Label();
      this.cbDailyFreqEvery = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
      this.nbDailyFreqEvery = new System.Windows.Forms.NumericUpDown();
      this.lblDailyFreqEveryStartAt = new System.Windows.Forms.Label();
      this.dtpDailyFreqOnce = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
      this.rbDailyFreqEvery = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
      this.rbDailyFreqOnce = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
      this.tbBackup = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
      this.btnBackupDelete = new Syncfusion.Windows.Forms.ButtonAdv();
      this.btnBackupAdd = new Syncfusion.Windows.Forms.ButtonAdv();
      this.cbBackupTotalMaxSizeUnit = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
      this.nbBackupTotalMaxSize = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
      this.cbBackupNotificationsEnabled = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
      this.lblBackupTotalMaxSize = new System.Windows.Forms.Label();
      this.glBackup = new Syncfusion.Windows.Forms.Grid.GridListControl();
      this.cbBackupEnable = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
      this.tbAdvanced = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
      this.cbPruningStrategy = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
      this.lblPruningStrategy = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.tbSnapExclWriters = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
      this.tbSnapInclWriters = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
      this.lblSnapExclWriters = new System.Windows.Forms.Label();
      this.lblSnapInclWriters = new System.Windows.Forms.Label();
      this.lblAdvWarning = new System.Windows.Forms.Label();
      this.nbSnapFailRetryCount = new System.Windows.Forms.NumericUpDown();
      this.cbSnapFailRestartVSS = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
      this.lblSnapFailRetryCount = new System.Windows.Forms.Label();
      this.cbSnapType = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
      this.lblSnapType = new System.Windows.Forms.Label();
      this.cbSnapContext = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
      this.lblSnapContext = new System.Windows.Forms.Label();
      this.lblMaxCountVal = new System.Windows.Forms.Label();
      this.lblMaxCount = new System.Windows.Forms.Label();
      this.skinManager = new Syncfusion.Windows.Forms.SkinManager(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.tbName)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbEnabled)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbGenCron)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
      this.tabControlAdv1.SuspendLayout();
      this.tpSnapshot.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cblDriveLetters)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbLifetime)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nbLifetime)).BeginInit();
      this.tpSchedule.SuspendLayout();
      this.gbPeriod.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtpPeriodEnd)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbPeriodEndDate)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbPeriodEndNever)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtpPeriodStart)).BeginInit();
      this.gbFreq.SuspendLayout();
      this.plFreqCron.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cbFreqCronExcluding)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtpFreqCronExcludingTo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtpFreqCronExcludingFrom)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbFreqCron)).BeginInit();
      this.plFreqMonthly.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cblFreqMonthlyDays)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cblFreqMonthlyMonths)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbFreqCron)).BeginInit();
      this.plFreqWeekly.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.rbFreqWeeklyOn)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbFreqWeeklyEvery)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbFreqWeeklySaturday)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbFreqWeeklyFriday)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbFreqWeeklyThursday)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbFreqWeeklyWednesday)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbFreqWeeklyTuesday)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbFreqWeeklyMonday)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbFreqWeeklySunday)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nbFreqWeekly)).BeginInit();
      this.plFreqDaily.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nbFreqDaily)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbFreqMonthly)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbFreqWeekly)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbFreqDaily)).BeginInit();
      this.gbDailyFreq.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cbDailyFreqEveryExcluding)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtpDailyFreqEveryExcludingTo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtpDailyFreqEveryExcludingFrom)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbDailyFreqEvery)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nbDailyFreqEvery)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtpDailyFreqOnce)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbDailyFreqEvery)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbDailyFreqOnce)).BeginInit();
      this.tbBackup.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cbBackupTotalMaxSizeUnit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nbBackupTotalMaxSize)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbBackupNotificationsEnabled)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.glBackup)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbBackupEnable)).BeginInit();
      this.tbAdvanced.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cbPruningStrategy)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbSnapExclWriters)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbSnapInclWriters)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nbSnapFailRetryCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbSnapFailRestartVSS)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbSnapType)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbSnapContext)).BeginInit();
      this.SuspendLayout();
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Location = new System.Drawing.Point(13, 13);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(38, 13);
      this.lblName.TabIndex = 1;
      this.lblName.Text = "Name:";
      // 
      // tbName
      // 
      this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbName.BeforeTouchSize = new System.Drawing.Size(298, 20);
      this.tbName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbName.Location = new System.Drawing.Point(136, 10);
      this.tbName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.tbName.Name = "tbName";
      this.tbName.Size = new System.Drawing.Size(217, 20);
      this.tbName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
      this.tbName.TabIndex = 0;
      this.tbName.TextChanged += new System.EventHandler(this.onChange_RefreshUI);
      // 
      // cbEnabled
      // 
      this.cbEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cbEnabled.AutoSize = true;
      this.cbEnabled.BeforeTouchSize = new System.Drawing.Size(61, 16);
      this.cbEnabled.Checked = true;
      this.cbEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbEnabled.Location = new System.Drawing.Point(401, 13);
      this.cbEnabled.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.cbEnabled.Name = "cbEnabled";
      this.cbEnabled.Size = new System.Drawing.Size(61, 16);
      this.cbEnabled.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
      this.cbEnabled.TabIndex = 1;
      this.cbEnabled.Text = "Enabled";
      this.cbEnabled.ThemesEnabled = true;
      // 
      // btnCreate
      // 
      this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCreate.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
      this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.btnCreate.BeforeTouchSize = new System.Drawing.Size(110, 33);
      this.btnCreate.ForeColor = System.Drawing.Color.White;
      this.btnCreate.IsBackStageButton = false;
      this.btnCreate.Location = new System.Drawing.Point(367, 543);
      this.btnCreate.Name = "btnCreate";
      this.btnCreate.Size = new System.Drawing.Size(110, 33);
      this.btnCreate.TabIndex = 6;
      this.btnCreate.Text = "Create";
      this.btnCreate.UseVisualStyle = true;
      this.btnCreate.UseVisualStyleBackColor = true;
      this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
      this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.btnCancel.BeforeTouchSize = new System.Drawing.Size(110, 33);
      this.btnCancel.ForeColor = System.Drawing.Color.White;
      this.btnCancel.IsBackStageButton = false;
      this.btnCancel.Location = new System.Drawing.Point(251, 543);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(110, 33);
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyle = true;
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // lblGenSched
      // 
      this.lblGenSched.AutoSize = true;
      this.lblGenSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblGenSched.Location = new System.Drawing.Point(7, 490);
      this.lblGenSched.Name = "lblGenSched";
      this.lblGenSched.Size = new System.Drawing.Size(68, 16);
      this.lblGenSched.TabIndex = 8;
      this.lblGenSched.Text = "Schedule:";
      // 
      // lblHumanSched
      // 
      this.lblHumanSched.AutoSize = true;
      this.lblHumanSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHumanSched.Location = new System.Drawing.Point(78, 491);
      this.lblHumanSched.MaximumSize = new System.Drawing.Size(391, 72);
      this.lblHumanSched.Name = "lblHumanSched";
      this.lblHumanSched.Size = new System.Drawing.Size(95, 16);
      this.lblHumanSched.TabIndex = 9;
      this.lblHumanSched.Text = "Every 1 minute";
      // 
      // tbGenCron
      // 
      this.tbGenCron.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.tbGenCron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
      this.tbGenCron.BeforeTouchSize = new System.Drawing.Size(298, 20);
      this.tbGenCron.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.tbGenCron.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbGenCron.Location = new System.Drawing.Point(76, 547);
      this.tbGenCron.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.tbGenCron.Name = "tbGenCron";
      this.tbGenCron.ReadOnly = true;
      this.tbGenCron.Size = new System.Drawing.Size(156, 20);
      this.tbGenCron.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
      this.tbGenCron.TabIndex = 10;
      // 
      // lblGenCron
      // 
      this.lblGenCron.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblGenCron.AutoSize = true;
      this.lblGenCron.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblGenCron.Location = new System.Drawing.Point(8, 548);
      this.lblGenCron.Name = "lblGenCron";
      this.lblGenCron.Size = new System.Drawing.Size(63, 15);
      this.lblGenCron.TabIndex = 11;
      this.lblGenCron.Text = "Gen. cron:";
      // 
      // tabControlAdv1
      // 
      this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty;
      this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(492, 428);
      this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
      this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
      this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
      this.tabControlAdv1.Controls.Add(this.tpSnapshot);
      this.tabControlAdv1.Controls.Add(this.tpSchedule);
      this.tabControlAdv1.Controls.Add(this.tbBackup);
      this.tabControlAdv1.Controls.Add(this.tbAdvanced);
      this.tabControlAdv1.FocusOnTabClick = false;
      this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
      this.tabControlAdv1.Location = new System.Drawing.Point(-5, 36);
      this.tabControlAdv1.Multiline = true;
      this.tabControlAdv1.Name = "tabControlAdv1";
      this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
      this.tabControlAdv1.ShowSeparator = false;
      this.tabControlAdv1.Size = new System.Drawing.Size(492, 428);
      this.tabControlAdv1.TabIndex = 12;
      this.tabControlAdv1.ThemesEnabled = true;
      // 
      // tpSnapshot
      // 
      this.tpSnapshot.Controls.Add(this.btnSystemProtection);
      this.tpSnapshot.Controls.Add(this.lblSnapLimitCount);
      this.tpSnapshot.Controls.Add(this.lblSnapLimit);
      this.tpSnapshot.Controls.Add(this.btnSnapLimitChange);
      this.tpSnapshot.Controls.Add(this.cblDriveLetters);
      this.tpSnapshot.Controls.Add(this.cbLifetime);
      this.tpSnapshot.Controls.Add(this.nbLifetime);
      this.tpSnapshot.Controls.Add(this.lblDriveLetters);
      this.tpSnapshot.Controls.Add(this.lblLifetimeHelp);
      this.tpSnapshot.Controls.Add(this.lblLifetime);
      this.tpSnapshot.Image = null;
      this.tpSnapshot.ImageSize = new System.Drawing.Size(16, 16);
      this.tpSnapshot.Location = new System.Drawing.Point(3, 27);
      this.tpSnapshot.Name = "tpSnapshot";
      this.tpSnapshot.ShowCloseButton = true;
      this.tpSnapshot.Size = new System.Drawing.Size(485, 397);
      this.tpSnapshot.TabIndex = 3;
      this.tpSnapshot.Text = "General";
      this.tpSnapshot.ThemesEnabled = true;
      // 
      // btnSystemProtection
      // 
      this.btnSystemProtection.Location = new System.Drawing.Point(348, 196);
      this.btnSystemProtection.Name = "btnSystemProtection";
      this.btnSystemProtection.Size = new System.Drawing.Size(124, 29);
      this.btnSystemProtection.TabIndex = 10;
      this.btnSystemProtection.Text = "Enable other Drive(s)";
      this.btnSystemProtection.UseVisualStyleBackColor = true;
      this.btnSystemProtection.Click += new System.EventHandler(this.btnSystemProtection_Click);
      // 
      // lblSnapLimitCount
      // 
      this.lblSnapLimitCount.AutoSize = true;
      this.lblSnapLimitCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSnapLimitCount.Location = new System.Drawing.Point(95, 204);
      this.lblSnapLimitCount.Name = "lblSnapLimitCount";
      this.lblSnapLimitCount.Size = new System.Drawing.Size(21, 13);
      this.lblSnapLimitCount.TabIndex = 9;
      this.lblSnapLimitCount.Text = "64";
      // 
      // lblSnapLimit
      // 
      this.lblSnapLimit.AutoSize = true;
      this.lblSnapLimit.Location = new System.Drawing.Point(10, 204);
      this.lblSnapLimit.Name = "lblSnapLimit";
      this.lblSnapLimit.Size = new System.Drawing.Size(75, 13);
      this.lblSnapLimit.TabIndex = 8;
      this.lblSnapLimit.Text = "Snapshot limit:";
      // 
      // btnSnapLimitChange
      // 
      this.btnSnapLimitChange.Location = new System.Drawing.Point(218, 196);
      this.btnSnapLimitChange.Name = "btnSnapLimitChange";
      this.btnSnapLimitChange.Size = new System.Drawing.Size(124, 29);
      this.btnSnapLimitChange.TabIndex = 7;
      this.btnSnapLimitChange.Text = "Raise limit";
      this.btnSnapLimitChange.UseVisualStyleBackColor = true;
      this.btnSnapLimitChange.Click += new System.EventHandler(this.btnSnapLimitChange_Click);
      // 
      // cblDriveLetters
      // 
      this.cblDriveLetters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cblDriveLetters.BindingMembersBindingContext = null;
      this.cblDriveLetters.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
      this.cblDriveLetters.LayoutMethod = EWSoftware.ListControls.LayoutMethod.AcrossThenDown;
      this.cblDriveLetters.Location = new System.Drawing.Point(95, 51);
      this.cblDriveLetters.Name = "cblDriveLetters";
      this.cblDriveLetters.Size = new System.Drawing.Size(384, 134);
      this.cblDriveLetters.TabIndex = 6;
      this.cblDriveLetters.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.cblDriveLetters.ItemCheckStateChanged += new System.EventHandler<EWSoftware.ListControls.ItemCheckStateEventArgs>(this.cblDriveLetters_ItemCheckStateChanged);
      // 
      // cbLifetime
      // 
      this.cbLifetime.AllowNewText = false;
      this.cbLifetime.BackColor = System.Drawing.Color.White;
      this.cbLifetime.BeforeTouchSize = new System.Drawing.Size(133, 21);
      this.cbLifetime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbLifetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbLifetime.Location = new System.Drawing.Point(165, 17);
      this.cbLifetime.Name = "cbLifetime";
      this.cbLifetime.Size = new System.Drawing.Size(133, 21);
      this.cbLifetime.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
      this.cbLifetime.TabIndex = 4;
      this.cbLifetime.SelectedIndexChanged += new System.EventHandler(this.refreshUI_Event);
      // 
      // nbLifetime
      // 
      this.nbLifetime.BeforeTouchSize = new System.Drawing.Size(64, 20);
      this.nbLifetime.Location = new System.Drawing.Point(95, 17);
      this.nbLifetime.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
      this.nbLifetime.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.nbLifetime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nbLifetime.Name = "nbLifetime";
      this.nbLifetime.Size = new System.Drawing.Size(64, 20);
      this.nbLifetime.TabIndex = 3;
      this.nbLifetime.ThemesEnabled = true;
      this.nbLifetime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nbLifetime.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
      this.nbLifetime.ValueChanged += new System.EventHandler(this.refreshUI_Event);
      // 
      // lblDriveLetters
      // 
      this.lblDriveLetters.AutoSize = true;
      this.lblDriveLetters.Location = new System.Drawing.Point(7, 51);
      this.lblDriveLetters.Name = "lblDriveLetters";
      this.lblDriveLetters.Size = new System.Drawing.Size(66, 13);
      this.lblDriveLetters.TabIndex = 2;
      this.lblDriveLetters.Text = "Drive letters:";
      // 
      // lblLifetimeHelp
      // 
      this.lblLifetimeHelp.AutoSize = true;
      this.lblLifetimeHelp.Location = new System.Drawing.Point(15, 372);
      this.lblLifetimeHelp.Name = "lblLifetimeHelp";
      this.lblLifetimeHelp.Size = new System.Drawing.Size(295, 13);
      this.lblLifetimeHelp.TabIndex = 1;
      this.lblLifetimeHelp.Text = "* How long each snapshots will be preserved before deletion.";
      // 
      // lblLifetime
      // 
      this.lblLifetime.AutoSize = true;
      this.lblLifetime.Location = new System.Drawing.Point(7, 19);
      this.lblLifetime.Name = "lblLifetime";
      this.lblLifetime.Size = new System.Drawing.Size(50, 13);
      this.lblLifetime.TabIndex = 0;
      this.lblLifetime.Text = "Lifetime*:";
      // 
      // tpSchedule
      // 
      this.tpSchedule.Controls.Add(this.gbPeriod);
      this.tpSchedule.Controls.Add(this.gbFreq);
      this.tpSchedule.Controls.Add(this.gbDailyFreq);
      this.tpSchedule.Image = null;
      this.tpSchedule.ImageSize = new System.Drawing.Size(16, 16);
      this.tpSchedule.Location = new System.Drawing.Point(3, 27);
      this.tpSchedule.Name = "tpSchedule";
      this.tpSchedule.ShowCloseButton = false;
      this.tpSchedule.Size = new System.Drawing.Size(485, 397);
      this.tpSchedule.TabIndex = 1;
      this.tpSchedule.Text = "Schedule";
      this.tpSchedule.ThemesEnabled = true;
      // 
      // gbPeriod
      // 
      this.gbPeriod.Controls.Add(this.dtpPeriodEnd);
      this.gbPeriod.Controls.Add(this.rbPeriodEndDate);
      this.gbPeriod.Controls.Add(this.rbPeriodEndNever);
      this.gbPeriod.Controls.Add(this.lblPeriodEnd);
      this.gbPeriod.Controls.Add(this.dtpPeriodStart);
      this.gbPeriod.Controls.Add(this.lblPeriodStart);
      this.gbPeriod.Location = new System.Drawing.Point(16, 280);
      this.gbPeriod.Name = "gbPeriod";
      this.gbPeriod.Size = new System.Drawing.Size(454, 112);
      this.gbPeriod.TabIndex = 8;
      this.gbPeriod.TabStop = false;
      this.gbPeriod.Text = "Period";
      // 
      // dtpPeriodEnd
      // 
      this.dtpPeriodEnd.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
      this.dtpPeriodEnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.dtpPeriodEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.dtpPeriodEnd.CalendarSize = new System.Drawing.Size(189, 176);
      this.dtpPeriodEnd.CustomFormat = "dddd, dd MMM yyyy @ HH:mm:ss";
      this.dtpPeriodEnd.DropDownImage = null;
      this.dtpPeriodEnd.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpPeriodEnd.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpPeriodEnd.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
      this.dtpPeriodEnd.EnableNullDate = false;
      this.dtpPeriodEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpPeriodEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpPeriodEnd.Location = new System.Drawing.Point(174, 80);
      this.dtpPeriodEnd.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpPeriodEnd.MinValue = new System.DateTime(((long)(0)));
      this.dtpPeriodEnd.Name = "dtpPeriodEnd";
      this.dtpPeriodEnd.ShowCheckBox = false;
      this.dtpPeriodEnd.Size = new System.Drawing.Size(200, 20);
      this.dtpPeriodEnd.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
      this.dtpPeriodEnd.TabIndex = 5;
      this.dtpPeriodEnd.ThemedChildControls = true;
      this.dtpPeriodEnd.ThemesEnabled = true;
      this.dtpPeriodEnd.Value = new System.DateTime(2018, 4, 12, 20, 47, 47, 560);
      this.dtpPeriodEnd.ValueChanged += new System.EventHandler(this.onChange_RefreshUI);
      // 
      // rbPeriodEndDate
      // 
      this.rbPeriodEndDate.AutoSize = true;
      this.rbPeriodEndDate.BeforeTouchSize = new System.Drawing.Size(93, 16);
      this.rbPeriodEndDate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.rbPeriodEndDate.Location = new System.Drawing.Point(70, 81);
      this.rbPeriodEndDate.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.rbPeriodEndDate.Name = "rbPeriodEndDate";
      this.rbPeriodEndDate.Size = new System.Drawing.Size(93, 16);
      this.rbPeriodEndDate.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
      this.rbPeriodEndDate.TabIndex = 4;
      this.rbPeriodEndDate.TabStop = false;
      this.rbPeriodEndDate.Text = "Specified date:";
      this.rbPeriodEndDate.ThemesEnabled = true;
      this.rbPeriodEndDate.CheckChanged += new System.EventHandler(this.rbPeriodEndDate_CheckedChanged);
      // 
      // rbPeriodEndNever
      // 
      this.rbPeriodEndNever.AutoSize = true;
      this.rbPeriodEndNever.BeforeTouchSize = new System.Drawing.Size(51, 16);
      this.rbPeriodEndNever.Checked = true;
      this.rbPeriodEndNever.ForeColor = System.Drawing.SystemColors.ControlText;
      this.rbPeriodEndNever.Location = new System.Drawing.Point(70, 57);
      this.rbPeriodEndNever.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.rbPeriodEndNever.Name = "rbPeriodEndNever";
      this.rbPeriodEndNever.Size = new System.Drawing.Size(51, 16);
      this.rbPeriodEndNever.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
      this.rbPeriodEndNever.TabIndex = 3;
      this.rbPeriodEndNever.Text = "Never";
      this.rbPeriodEndNever.ThemesEnabled = true;
      this.rbPeriodEndNever.CheckChanged += new System.EventHandler(this.rbPeriodEndNever_CheckedChanged);
      // 
      // lblPeriodEnd
      // 
      this.lblPeriodEnd.AutoSize = true;
      this.lblPeriodEnd.Location = new System.Drawing.Point(17, 59);
      this.lblPeriodEnd.Name = "lblPeriodEnd";
      this.lblPeriodEnd.Size = new System.Drawing.Size(44, 13);
      this.lblPeriodEnd.TabIndex = 2;
      this.lblPeriodEnd.Text = "End on:";
      // 
      // dtpPeriodStart
      // 
      this.dtpPeriodStart.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
      this.dtpPeriodStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.dtpPeriodStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.dtpPeriodStart.CalendarSize = new System.Drawing.Size(189, 176);
      this.dtpPeriodStart.CustomFormat = "dddd, dd MMM yyyy @ HH:mm:ss";
      this.dtpPeriodStart.DropDownImage = null;
      this.dtpPeriodStart.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpPeriodStart.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpPeriodStart.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
      this.dtpPeriodStart.EnableNullDate = false;
      this.dtpPeriodStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpPeriodStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpPeriodStart.Location = new System.Drawing.Point(70, 27);
      this.dtpPeriodStart.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpPeriodStart.MinValue = new System.DateTime(((long)(0)));
      this.dtpPeriodStart.Name = "dtpPeriodStart";
      this.dtpPeriodStart.ShowCheckBox = false;
      this.dtpPeriodStart.Size = new System.Drawing.Size(200, 20);
      this.dtpPeriodStart.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
      this.dtpPeriodStart.TabIndex = 1;
      this.dtpPeriodStart.ThemedChildControls = true;
      this.dtpPeriodStart.ThemesEnabled = true;
      this.dtpPeriodStart.Value = new System.DateTime(2018, 4, 12, 20, 47, 47, 671);
      this.dtpPeriodStart.ValueChanged += new System.EventHandler(this.onChange_RefreshUI);
      // 
      // lblPeriodStart
      // 
      this.lblPeriodStart.AutoSize = true;
      this.lblPeriodStart.Location = new System.Drawing.Point(17, 29);
      this.lblPeriodStart.Name = "lblPeriodStart";
      this.lblPeriodStart.Size = new System.Drawing.Size(47, 13);
      this.lblPeriodStart.TabIndex = 0;
      this.lblPeriodStart.Text = "Start on:";
      // 
      // gbFreq
      // 
      this.gbFreq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gbFreq.Controls.Add(this.plFreqCron);
      this.gbFreq.Controls.Add(this.plFreqMonthly);
      this.gbFreq.Controls.Add(this.rbFreqCron);
      this.gbFreq.Controls.Add(this.plFreqWeekly);
      this.gbFreq.Controls.Add(this.plFreqDaily);
      this.gbFreq.Controls.Add(this.rbFreqMonthly);
      this.gbFreq.Controls.Add(this.rbFreqWeekly);
      this.gbFreq.Controls.Add(this.rbFreqDaily);
      this.gbFreq.Location = new System.Drawing.Point(16, 138);
      this.gbFreq.Name = "gbFreq";
      this.gbFreq.Size = new System.Drawing.Size(454, 135);
      this.gbFreq.TabIndex = 7;
      this.gbFreq.TabStop = false;
      this.gbFreq.Text = "Frequency";
      // 
      // plFreqCron
      // 
      this.plFreqCron.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.plFreqCron.Controls.Add(this.cbFreqCronExcluding);
      this.plFreqCron.Controls.Add(this.dtpFreqCronExcludingTo);
      this.plFreqCron.Controls.Add(this.dtpFreqCronExcludingFrom);
      this.plFreqCron.Controls.Add(this.lblFreqCronEnd);
      this.plFreqCron.Controls.Add(this.lblFreqCronStart);
      this.plFreqCron.Controls.Add(this.lblFreqCronHelp);
      this.plFreqCron.Controls.Add(this.llbFreqCronGen);
      this.plFreqCron.Controls.Add(this.llbFreqCronHelp);
      this.plFreqCron.Controls.Add(this.tbFreqCron);
      this.plFreqCron.Controls.Add(this.lblFreqCron);
      this.plFreqCron.Location = new System.Drawing.Point(110, 10);
      this.plFreqCron.Name = "plFreqCron";
      this.plFreqCron.Size = new System.Drawing.Size(338, 120);
      this.plFreqCron.TabIndex = 21;
      // 
      // cbFreqCronExcluding
      // 
      this.cbFreqCronExcluding.AutoSize = true;
      this.cbFreqCronExcluding.BeforeTouchSize = new System.Drawing.Size(71, 16);
      this.cbFreqCronExcluding.Location = new System.Drawing.Point(14, 50);
      this.cbFreqCronExcluding.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.cbFreqCronExcluding.Name = "cbFreqCronExcluding";
      this.cbFreqCronExcluding.Size = new System.Drawing.Size(71, 16);
      this.cbFreqCronExcluding.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
      this.cbFreqCronExcluding.TabIndex = 13;
      this.cbFreqCronExcluding.Text = "Excluding:";
      this.cbFreqCronExcluding.ThemesEnabled = true;
      this.cbFreqCronExcluding.CheckedChanged += new System.EventHandler(this.cbFreqCronExcluding_CheckedChanged);
      // 
      // dtpFreqCronExcludingTo
      // 
      this.dtpFreqCronExcludingTo.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
      this.dtpFreqCronExcludingTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.dtpFreqCronExcludingTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.dtpFreqCronExcludingTo.CalendarSize = new System.Drawing.Size(189, 176);
      this.dtpFreqCronExcludingTo.DropDownImage = null;
      this.dtpFreqCronExcludingTo.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpFreqCronExcludingTo.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpFreqCronExcludingTo.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
      this.dtpFreqCronExcludingTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpFreqCronExcludingTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.dtpFreqCronExcludingTo.Location = new System.Drawing.Point(139, 75);
      this.dtpFreqCronExcludingTo.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpFreqCronExcludingTo.MinValue = new System.DateTime(((long)(0)));
      this.dtpFreqCronExcludingTo.Name = "dtpFreqCronExcludingTo";
      this.dtpFreqCronExcludingTo.ShowCheckBox = false;
      this.dtpFreqCronExcludingTo.ShowDropButton = false;
      this.dtpFreqCronExcludingTo.ShowUpDown = true;
      this.dtpFreqCronExcludingTo.Size = new System.Drawing.Size(82, 20);
      this.dtpFreqCronExcludingTo.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
      this.dtpFreqCronExcludingTo.TabIndex = 11;
      this.dtpFreqCronExcludingTo.ThemesEnabled = true;
      this.dtpFreqCronExcludingTo.Value = new System.DateTime(2018, 3, 29, 23, 0, 0, 0);
      this.dtpFreqCronExcludingTo.ValueChanged += new System.EventHandler(this.onChange_RefreshUI);
      // 
      // dtpFreqCronExcludingFrom
      // 
      this.dtpFreqCronExcludingFrom.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
      this.dtpFreqCronExcludingFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.dtpFreqCronExcludingFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.dtpFreqCronExcludingFrom.CalendarSize = new System.Drawing.Size(189, 176);
      this.dtpFreqCronExcludingFrom.DropDownImage = null;
      this.dtpFreqCronExcludingFrom.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpFreqCronExcludingFrom.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpFreqCronExcludingFrom.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
      this.dtpFreqCronExcludingFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpFreqCronExcludingFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.dtpFreqCronExcludingFrom.Location = new System.Drawing.Point(139, 49);
      this.dtpFreqCronExcludingFrom.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpFreqCronExcludingFrom.MinValue = new System.DateTime(((long)(0)));
      this.dtpFreqCronExcludingFrom.Name = "dtpFreqCronExcludingFrom";
      this.dtpFreqCronExcludingFrom.ShowCheckBox = false;
      this.dtpFreqCronExcludingFrom.ShowDropButton = false;
      this.dtpFreqCronExcludingFrom.ShowUpDown = true;
      this.dtpFreqCronExcludingFrom.Size = new System.Drawing.Size(82, 20);
      this.dtpFreqCronExcludingFrom.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
      this.dtpFreqCronExcludingFrom.TabIndex = 10;
      this.dtpFreqCronExcludingFrom.ThemesEnabled = true;
      this.dtpFreqCronExcludingFrom.Value = new System.DateTime(2018, 3, 29, 8, 0, 0, 0);
      this.dtpFreqCronExcludingFrom.ValueChanged += new System.EventHandler(this.onChange_RefreshUI);
      // 
      // lblFreqCronEnd
      // 
      this.lblFreqCronEnd.AutoSize = true;
      this.lblFreqCronEnd.Location = new System.Drawing.Point(97, 77);
      this.lblFreqCronEnd.Name = "lblFreqCronEnd";
      this.lblFreqCronEnd.Size = new System.Drawing.Size(23, 13);
      this.lblFreqCronEnd.TabIndex = 12;
      this.lblFreqCronEnd.Text = "To:";
      // 
      // lblFreqCronStart
      // 
      this.lblFreqCronStart.AutoSize = true;
      this.lblFreqCronStart.Location = new System.Drawing.Point(97, 52);
      this.lblFreqCronStart.Name = "lblFreqCronStart";
      this.lblFreqCronStart.Size = new System.Drawing.Size(33, 13);
      this.lblFreqCronStart.TabIndex = 9;
      this.lblFreqCronStart.Text = "From:";
      // 
      // lblFreqCronHelp
      // 
      this.lblFreqCronHelp.AutoSize = true;
      this.lblFreqCronHelp.Location = new System.Drawing.Point(220, 17);
      this.lblFreqCronHelp.Name = "lblFreqCronHelp";
      this.lblFreqCronHelp.Size = new System.Drawing.Size(32, 13);
      this.lblFreqCronHelp.TabIndex = 4;
      this.lblFreqCronHelp.Text = "Help:";
      // 
      // llbFreqCronGen
      // 
      this.llbFreqCronGen.AutoSize = true;
      this.llbFreqCronGen.Location = new System.Drawing.Point(255, 38);
      this.llbFreqCronGen.Name = "llbFreqCronGen";
      this.llbFreqCronGen.Size = new System.Drawing.Size(77, 13);
      this.llbFreqCronGen.TabIndex = 3;
      this.llbFreqCronGen.TabStop = true;
      this.llbFreqCronGen.Text = "Cron generator";
      this.llbFreqCronGen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelClicked);
      // 
      // llbFreqCronHelp
      // 
      this.llbFreqCronHelp.AutoSize = true;
      this.llbFreqCronHelp.Location = new System.Drawing.Point(255, 17);
      this.llbFreqCronHelp.Name = "llbFreqCronHelp";
      this.llbFreqCronHelp.Size = new System.Drawing.Size(61, 13);
      this.llbFreqCronHelp.TabIndex = 2;
      this.llbFreqCronHelp.TabStop = true;
      this.llbFreqCronHelp.Text = "Cron format";
      this.llbFreqCronHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelClicked);
      // 
      // tbFreqCron
      // 
      this.tbFreqCron.BeforeTouchSize = new System.Drawing.Size(298, 20);
      this.tbFreqCron.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.tbFreqCron.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbFreqCron.Location = new System.Drawing.Point(65, 14);
      this.tbFreqCron.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.tbFreqCron.Name = "tbFreqCron";
      this.tbFreqCron.Size = new System.Drawing.Size(131, 20);
      this.tbFreqCron.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
      this.tbFreqCron.TabIndex = 1;
      this.tbFreqCron.Text = "0 * * * * ?";
      this.tbFreqCron.TextChanged += new System.EventHandler(this.tbFreqCron_TextChanged);
      // 
      // lblFreqCron
      // 
      this.lblFreqCron.AutoSize = true;
      this.lblFreqCron.Location = new System.Drawing.Point(11, 17);
      this.lblFreqCron.Name = "lblFreqCron";
      this.lblFreqCron.Size = new System.Drawing.Size(47, 13);
      this.lblFreqCron.TabIndex = 0;
      this.lblFreqCron.Text = "Crontab:";
      // 
      // plFreqMonthly
      // 
      this.plFreqMonthly.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.plFreqMonthly.Controls.Add(this.cblFreqMonthlyDays);
      this.plFreqMonthly.Controls.Add(this.lblFreqMonthlyDays);
      this.plFreqMonthly.Controls.Add(this.cblFreqMonthlyMonths);
      this.plFreqMonthly.Controls.Add(this.lblFreqMonthlyMonths);
      this.plFreqMonthly.Location = new System.Drawing.Point(110, 10);
      this.plFreqMonthly.Name = "plFreqMonthly";
      this.plFreqMonthly.Size = new System.Drawing.Size(338, 120);
      this.plFreqMonthly.TabIndex = 19;
      // 
      // cblFreqMonthlyDays
      // 
      this.cblFreqMonthlyDays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cblFreqMonthlyDays.BindingMembersBindingContext = null;
      this.cblFreqMonthlyDays.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
      this.cblFreqMonthlyDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
      this.cblFreqMonthlyDays.LayoutMethod = EWSoftware.ListControls.LayoutMethod.AcrossThenDown;
      this.cblFreqMonthlyDays.Location = new System.Drawing.Point(65, 65);
      this.cblFreqMonthlyDays.Name = "cblFreqMonthlyDays";
      this.cblFreqMonthlyDays.Size = new System.Drawing.Size(217, 47);
      this.cblFreqMonthlyDays.TabIndex = 5;
      this.cblFreqMonthlyDays.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.cblFreqMonthlyDays.ItemCheckStateChanged += new System.EventHandler<EWSoftware.ListControls.ItemCheckStateEventArgs>(this.cblFreqMonthlyDays_ItemCheckStateChanged);
      // 
      // lblFreqMonthlyDays
      // 
      this.lblFreqMonthlyDays.AutoSize = true;
      this.lblFreqMonthlyDays.Location = new System.Drawing.Point(11, 68);
      this.lblFreqMonthlyDays.Name = "lblFreqMonthlyDays";
      this.lblFreqMonthlyDays.Size = new System.Drawing.Size(40, 13);
      this.lblFreqMonthlyDays.TabIndex = 4;
      this.lblFreqMonthlyDays.Text = "Day(s):";
      // 
      // cblFreqMonthlyMonths
      // 
      this.cblFreqMonthlyMonths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cblFreqMonthlyMonths.BindingMembersBindingContext = null;
      this.cblFreqMonthlyMonths.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
      this.cblFreqMonthlyMonths.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
      this.cblFreqMonthlyMonths.LayoutMethod = EWSoftware.ListControls.LayoutMethod.AcrossThenDown;
      this.cblFreqMonthlyMonths.Location = new System.Drawing.Point(65, 12);
      this.cblFreqMonthlyMonths.Name = "cblFreqMonthlyMonths";
      this.cblFreqMonthlyMonths.Size = new System.Drawing.Size(217, 47);
      this.cblFreqMonthlyMonths.TabIndex = 3;
      this.cblFreqMonthlyMonths.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.cblFreqMonthlyMonths.ItemCheckStateChanged += new System.EventHandler<EWSoftware.ListControls.ItemCheckStateEventArgs>(this.cblFreqMonthlyMonths_ItemCheckStateChanged);
      // 
      // lblFreqMonthlyMonths
      // 
      this.lblFreqMonthlyMonths.AutoSize = true;
      this.lblFreqMonthlyMonths.Location = new System.Drawing.Point(11, 17);
      this.lblFreqMonthlyMonths.Name = "lblFreqMonthlyMonths";
      this.lblFreqMonthlyMonths.Size = new System.Drawing.Size(51, 13);
      this.lblFreqMonthlyMonths.TabIndex = 0;
      this.lblFreqMonthlyMonths.Text = "Month(s):";
      // 
      // rbFreqCron
      // 
      this.rbFreqCron.AutoSize = true;
      this.rbFreqCron.BeforeTouchSize = new System.Drawing.Size(82, 16);
      this.rbFreqCron.ForeColor = System.Drawing.SystemColors.ControlText;
      this.rbFreqCron.Location = new System.Drawing.Point(17, 106);
      this.rbFreqCron.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.rbFreqCron.Name = "rbFreqCron";
      this.rbFreqCron.Size = new System.Drawing.Size(82, 16);
      this.rbFreqCron.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
      this.rbFreqCron.TabIndex = 20;
      this.rbFreqCron.TabStop = false;
      this.rbFreqCron.Text = "Expert (cron)";
      this.rbFreqCron.ThemesEnabled = true;
      this.rbFreqCron.CheckChanged += new System.EventHandler(this.rbFreqCron_CheckedChanged);
      // 
      // plFreqWeekly
      // 
      this.plFreqWeekly.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.plFreqWeekly.Controls.Add(this.rbFreqWeeklyOn);
      this.plFreqWeekly.Controls.Add(this.rbFreqWeeklyEvery);
      this.plFreqWeekly.Controls.Add(this.cbFreqWeeklySaturday);
      this.plFreqWeekly.Controls.Add(this.cbFreqWeeklyFriday);
      this.plFreqWeekly.Controls.Add(this.cbFreqWeeklyThursday);
      this.plFreqWeekly.Controls.Add(this.cbFreqWeeklyWednesday);
      this.plFreqWeekly.Controls.Add(this.cbFreqWeeklyTuesday);
      this.plFreqWeekly.Controls.Add(this.cbFreqWeeklyMonday);
      this.plFreqWeekly.Controls.Add(this.cbFreqWeeklySunday);
      this.plFreqWeekly.Controls.Add(this.lblFreqWeeklyWeeks);
      this.plFreqWeekly.Controls.Add(this.nbFreqWeekly);
      this.plFreqWeekly.Location = new System.Drawing.Point(110, 10);
      this.plFreqWeekly.Name = "plFreqWeekly";
      this.plFreqWeekly.Size = new System.Drawing.Size(338, 120);
      this.plFreqWeekly.TabIndex = 14;
      // 
      // rbFreqWeeklyOn
      // 
      this.rbFreqWeeklyOn.AutoSize = true;
      this.rbFreqWeeklyOn.BeforeTouchSize = new System.Drawing.Size(74, 16);
      this.rbFreqWeeklyOn.ForeColor = System.Drawing.SystemColors.ControlText;
      this.rbFreqWeeklyOn.Location = new System.Drawing.Point(11, 42);
      this.rbFreqWeeklyOn.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.rbFreqWeeklyOn.Name = "rbFreqWeeklyOn";
      this.rbFreqWeeklyOn.Size = new System.Drawing.Size(74, 16);
      this.rbFreqWeeklyOn.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
      this.rbFreqWeeklyOn.TabIndex = 20;
      this.rbFreqWeeklyOn.TabStop = false;
      this.rbFreqWeeklyOn.Text = "Recurs on:";
      this.rbFreqWeeklyOn.ThemesEnabled = true;
      this.rbFreqWeeklyOn.CheckChanged += new System.EventHandler(this.rbFreqWeeklyOn_CheckedChanged);
      // 
      // rbFreqWeeklyEvery
      // 
      this.rbFreqWeeklyEvery.AutoSize = true;
      this.rbFreqWeeklyEvery.BeforeTouchSize = new System.Drawing.Size(88, 16);
      this.rbFreqWeeklyEvery.Checked = true;
      this.rbFreqWeeklyEvery.ForeColor = System.Drawing.SystemColors.ControlText;
      this.rbFreqWeeklyEvery.Location = new System.Drawing.Point(11, 17);
      this.rbFreqWeeklyEvery.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.rbFreqWeeklyEvery.Name = "rbFreqWeeklyEvery";
      this.rbFreqWeeklyEvery.Size = new System.Drawing.Size(88, 16);
      this.rbFreqWeeklyEvery.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
      this.rbFreqWeeklyEvery.TabIndex = 19;
      this.rbFreqWeeklyEvery.Text = "Recurs every:";
      this.rbFreqWeeklyEvery.ThemesEnabled = true;
      this.rbFreqWeeklyEvery.CheckChanged += new System.EventHandler(this.rbFreqWeeklyEvery_CheckedChanged);
      // 
      // cbFreqWeeklySaturday
      // 
      this.cbFreqWeeklySaturday.AutoSize = true;
      this.cbFreqWeeklySaturday.BeforeTouchSize = new System.Drawing.Size(64, 16);
      this.cbFreqWeeklySaturday.Location = new System.Drawing.Point(163, 96);
      this.cbFreqWeeklySaturday.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.cbFreqWeeklySaturday.Name = "cbFreqWeeklySaturday";
      this.cbFreqWeeklySaturday.Size = new System.Drawing.Size(64, 16);
      this.cbFreqWeeklySaturday.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
      this.cbFreqWeeklySaturday.TabIndex = 18;
      this.cbFreqWeeklySaturday.Tag = "SAT";
      this.cbFreqWeeklySaturday.Text = "Saturday";
      this.cbFreqWeeklySaturday.ThemesEnabled = true;
      this.cbFreqWeeklySaturday.CheckedChanged += new System.EventHandler(this.cbFreqWeeklySaturday_CheckedChanged);
      // 
      // cbFreqWeeklyFriday
      // 
      this.cbFreqWeeklyFriday.AutoSize = true;
      this.cbFreqWeeklyFriday.BeforeTouchSize = new System.Drawing.Size(50, 16);
      this.cbFreqWeeklyFriday.Location = new System.Drawing.Point(90, 96);
      this.cbFreqWeeklyFriday.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.cbFreqWeeklyFriday.Name = "cbFreqWeeklyFriday";
      this.cbFreqWeeklyFriday.Size = new System.Drawing.Size(50, 16);
      this.cbFreqWeeklyFriday.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
      this.cbFreqWeeklyFriday.TabIndex = 17;
      this.cbFreqWeeklyFriday.Tag = "FRI";
      this.cbFreqWeeklyFriday.Text = "Friday";
      this.cbFreqWeeklyFriday.ThemesEnabled = true;
      this.cbFreqWeeklyFriday.CheckedChanged += new System.EventHandler(this.cbFreqWeeklyFriday_CheckedChanged);
      // 
      // cbFreqWeeklyThursday
      // 
      this.cbFreqWeeklyThursday.AutoSize = true;
      this.cbFreqWeeklyThursday.BeforeTouchSize = new System.Drawing.Size(66, 16);
      this.cbFreqWeeklyThursday.Location = new System.Drawing.Point(14, 96);
      this.cbFreqWeeklyThursday.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.cbFreqWeeklyThursday.Name = "cbFreqWeeklyThursday";
      this.cbFreqWeeklyThursday.Size = new System.Drawing.Size(66, 16);
      this.cbFreqWeeklyThursday.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
      this.cbFreqWeeklyThursday.TabIndex = 16;
      this.cbFreqWeeklyThursday.Tag = "THU";
      this.cbFreqWeeklyThursday.Text = "Thursday";
      this.cbFreqWeeklyThursday.ThemesEnabled = true;
      this.cbFreqWeeklyThursday.CheckedChanged += new System.EventHandler(this.cbFreqWeeklyThursday_CheckedChanged);
      // 
      // cbFreqWeeklyWednesday
      // 
      this.cbFreqWeeklyWednesday.AutoSize = true;
      this.cbFreqWeeklyWednesday.BeforeTouchSize = new System.Drawing.Size(79, 16);
      this.cbFreqWeeklyWednesday.Location = new System.Drawing.Point(236, 69);
      this.cbFreqWeeklyWednesday.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.cbFreqWeeklyWednesday.Name = "cbFreqWeeklyWednesday";
      this.cbFreqWeeklyWednesday.Size = new System.Drawing.Size(79, 16);
      this.cbFreqWeeklyWednesday.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
      this.cbFreqWeeklyWednesday.TabIndex = 15;
      this.cbFreqWeeklyWednesday.Tag = "WED";
      this.cbFreqWeeklyWednesday.Text = "Wednesday";
      this.cbFreqWeeklyWednesday.ThemesEnabled = true;
      this.cbFreqWeeklyWednesday.CheckedChanged += new System.EventHandler(this.cbFreqWeeklyWednesday_CheckedChanged);
      // 
      // cbFreqWeeklyTuesday
      // 
      this.cbFreqWeeklyTuesday.AutoSize = true;
      this.cbFreqWeeklyTuesday.BeforeTouchSize = new System.Drawing.Size(63, 16);
      this.cbFreqWeeklyTuesday.Location = new System.Drawing.Point(163, 69);
      this.cbFreqWeeklyTuesday.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.cbFreqWeeklyTuesday.Name = "cbFreqWeeklyTuesday";
      this.cbFreqWeeklyTuesday.Size = new System.Drawing.Size(63, 16);
      this.cbFreqWeeklyTuesday.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
      this.cbFreqWeeklyTuesday.TabIndex = 14;
      this.cbFreqWeeklyTuesday.Tag = "TUE";
      this.cbFreqWeeklyTuesday.Text = "Tuesday";
      this.cbFreqWeeklyTuesday.ThemesEnabled = true;
      this.cbFreqWeeklyTuesday.CheckedChanged += new System.EventHandler(this.cbFreqWeeklyTuesday_CheckedChanged);
      // 
      // cbFreqWeeklyMonday
      // 
      this.cbFreqWeeklyMonday.AutoSize = true;
      this.cbFreqWeeklyMonday.BeforeTouchSize = new System.Drawing.Size(60, 16);
      this.cbFreqWeeklyMonday.Location = new System.Drawing.Point(90, 69);
      this.cbFreqWeeklyMonday.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.cbFreqWeeklyMonday.Name = "cbFreqWeeklyMonday";
      this.cbFreqWeeklyMonday.Size = new System.Drawing.Size(60, 16);
      this.cbFreqWeeklyMonday.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
      this.cbFreqWeeklyMonday.TabIndex = 9;
      this.cbFreqWeeklyMonday.Tag = "MON";
      this.cbFreqWeeklyMonday.Text = "Monday";
      this.cbFreqWeeklyMonday.ThemesEnabled = true;
      this.cbFreqWeeklyMonday.CheckedChanged += new System.EventHandler(this.cbFreqWeeklyMonday_CheckedChanged);
      // 
      // cbFreqWeeklySunday
      // 
      this.cbFreqWeeklySunday.AutoSize = true;
      this.cbFreqWeeklySunday.BeforeTouchSize = new System.Drawing.Size(58, 16);
      this.cbFreqWeeklySunday.Location = new System.Drawing.Point(14, 69);
      this.cbFreqWeeklySunday.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.cbFreqWeeklySunday.Name = "cbFreqWeeklySunday";
      this.cbFreqWeeklySunday.Size = new System.Drawing.Size(58, 16);
      this.cbFreqWeeklySunday.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
      this.cbFreqWeeklySunday.TabIndex = 8;
      this.cbFreqWeeklySunday.Tag = "SUN";
      this.cbFreqWeeklySunday.Text = "Sunday";
      this.cbFreqWeeklySunday.ThemesEnabled = true;
      this.cbFreqWeeklySunday.CheckedChanged += new System.EventHandler(this.cbFreqWeeklySunday_CheckedChanged);
      // 
      // lblFreqWeeklyWeeks
      // 
      this.lblFreqWeeklyWeeks.AutoSize = true;
      this.lblFreqWeeklyWeeks.Location = new System.Drawing.Point(170, 19);
      this.lblFreqWeeklyWeeks.Name = "lblFreqWeeklyWeeks";
      this.lblFreqWeeklyWeeks.Size = new System.Drawing.Size(44, 13);
      this.lblFreqWeeklyWeeks.TabIndex = 7;
      this.lblFreqWeeklyWeeks.Text = "week(s)";
      // 
      // nbFreqWeekly
      // 
      this.nbFreqWeekly.Location = new System.Drawing.Point(119, 15);
      this.nbFreqWeekly.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.nbFreqWeekly.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nbFreqWeekly.Name = "nbFreqWeekly";
      this.nbFreqWeekly.Size = new System.Drawing.Size(45, 20);
      this.nbFreqWeekly.TabIndex = 6;
      this.nbFreqWeekly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.nbFreqWeekly.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nbFreqWeekly.ValueChanged += new System.EventHandler(this.onChange_RefreshUI);
      // 
      // plFreqDaily
      // 
      this.plFreqDaily.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.plFreqDaily.Controls.Add(this.lblFreqDailyDays);
      this.plFreqDaily.Controls.Add(this.nbFreqDaily);
      this.plFreqDaily.Controls.Add(this.lblFreqDailyEvery);
      this.plFreqDaily.Location = new System.Drawing.Point(110, 10);
      this.plFreqDaily.Name = "plFreqDaily";
      this.plFreqDaily.Size = new System.Drawing.Size(338, 120);
      this.plFreqDaily.TabIndex = 13;
      // 
      // lblFreqDailyDays
      // 
      this.lblFreqDailyDays.AutoSize = true;
      this.lblFreqDailyDays.Location = new System.Drawing.Point(151, 19);
      this.lblFreqDailyDays.Name = "lblFreqDailyDays";
      this.lblFreqDailyDays.Size = new System.Drawing.Size(35, 13);
      this.lblFreqDailyDays.TabIndex = 7;
      this.lblFreqDailyDays.Text = "day(s)";
      // 
      // nbFreqDaily
      // 
      this.nbFreqDaily.Location = new System.Drawing.Point(100, 15);
      this.nbFreqDaily.Maximum = new decimal(new int[] {
            144,
            0,
            0,
            0});
      this.nbFreqDaily.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nbFreqDaily.Name = "nbFreqDaily";
      this.nbFreqDaily.Size = new System.Drawing.Size(45, 20);
      this.nbFreqDaily.TabIndex = 6;
      this.nbFreqDaily.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nbFreqDaily.ValueChanged += new System.EventHandler(this.onChange_RefreshUI);
      // 
      // lblFreqDailyEvery
      // 
      this.lblFreqDailyEvery.AutoSize = true;
      this.lblFreqDailyEvery.Location = new System.Drawing.Point(11, 17);
      this.lblFreqDailyEvery.Name = "lblFreqDailyEvery";
      this.lblFreqDailyEvery.Size = new System.Drawing.Size(73, 13);
      this.lblFreqDailyEvery.TabIndex = 0;
      this.lblFreqDailyEvery.Text = "Recurs every:";
      // 
      // rbFreqMonthly
      // 
      this.rbFreqMonthly.AutoSize = true;
      this.rbFreqMonthly.BeforeTouchSize = new System.Drawing.Size(59, 16);
      this.rbFreqMonthly.ForeColor = System.Drawing.SystemColors.ControlText;
      this.rbFreqMonthly.Location = new System.Drawing.Point(17, 79);
      this.rbFreqMonthly.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.rbFreqMonthly.Name = "rbFreqMonthly";
      this.rbFreqMonthly.Size = new System.Drawing.Size(59, 16);
      this.rbFreqMonthly.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
      this.rbFreqMonthly.TabIndex = 11;
      this.rbFreqMonthly.TabStop = false;
      this.rbFreqMonthly.Text = "Monthly";
      this.rbFreqMonthly.ThemesEnabled = true;
      this.rbFreqMonthly.CheckChanged += new System.EventHandler(this.rbFreqMonthly_CheckedChanged);
      // 
      // rbFreqWeekly
      // 
      this.rbFreqWeekly.AutoSize = true;
      this.rbFreqWeekly.BeforeTouchSize = new System.Drawing.Size(58, 16);
      this.rbFreqWeekly.ForeColor = System.Drawing.SystemColors.ControlText;
      this.rbFreqWeekly.Location = new System.Drawing.Point(17, 52);
      this.rbFreqWeekly.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.rbFreqWeekly.Name = "rbFreqWeekly";
      this.rbFreqWeekly.Size = new System.Drawing.Size(58, 16);
      this.rbFreqWeekly.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
      this.rbFreqWeekly.TabIndex = 10;
      this.rbFreqWeekly.TabStop = false;
      this.rbFreqWeekly.Text = "Weekly";
      this.rbFreqWeekly.ThemesEnabled = true;
      this.rbFreqWeekly.CheckChanged += new System.EventHandler(this.rbFreqWeekly_CheckedChanged);
      // 
      // rbFreqDaily
      // 
      this.rbFreqDaily.AutoSize = true;
      this.rbFreqDaily.BeforeTouchSize = new System.Drawing.Size(45, 16);
      this.rbFreqDaily.Checked = true;
      this.rbFreqDaily.ForeColor = System.Drawing.SystemColors.ControlText;
      this.rbFreqDaily.Location = new System.Drawing.Point(17, 25);
      this.rbFreqDaily.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.rbFreqDaily.Name = "rbFreqDaily";
      this.rbFreqDaily.Size = new System.Drawing.Size(45, 16);
      this.rbFreqDaily.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
      this.rbFreqDaily.TabIndex = 9;
      this.rbFreqDaily.Text = "Daily";
      this.rbFreqDaily.ThemesEnabled = true;
      this.rbFreqDaily.CheckChanged += new System.EventHandler(this.rbFreqDaily_CheckedChanged);
      // 
      // gbDailyFreq
      // 
      this.gbDailyFreq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gbDailyFreq.Controls.Add(this.cbDailyFreqEveryExcluding);
      this.gbDailyFreq.Controls.Add(this.dtpDailyFreqEveryExcludingTo);
      this.gbDailyFreq.Controls.Add(this.dtpDailyFreqEveryExcludingFrom);
      this.gbDailyFreq.Controls.Add(this.lblDailyFreqEveryEndAt);
      this.gbDailyFreq.Controls.Add(this.cbDailyFreqEvery);
      this.gbDailyFreq.Controls.Add(this.nbDailyFreqEvery);
      this.gbDailyFreq.Controls.Add(this.lblDailyFreqEveryStartAt);
      this.gbDailyFreq.Controls.Add(this.dtpDailyFreqOnce);
      this.gbDailyFreq.Controls.Add(this.rbDailyFreqEvery);
      this.gbDailyFreq.Controls.Add(this.rbDailyFreqOnce);
      this.gbDailyFreq.Location = new System.Drawing.Point(16, 9);
      this.gbDailyFreq.Name = "gbDailyFreq";
      this.gbDailyFreq.Size = new System.Drawing.Size(454, 123);
      this.gbDailyFreq.TabIndex = 6;
      this.gbDailyFreq.TabStop = false;
      this.gbDailyFreq.Text = "Daily frequency";
      // 
      // cbDailyFreqEveryExcluding
      // 
      this.cbDailyFreqEveryExcluding.AutoSize = true;
      this.cbDailyFreqEveryExcluding.BeforeTouchSize = new System.Drawing.Size(71, 16);
      this.cbDailyFreqEveryExcluding.Location = new System.Drawing.Point(62, 87);
      this.cbDailyFreqEveryExcluding.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.cbDailyFreqEveryExcluding.Name = "cbDailyFreqEveryExcluding";
      this.cbDailyFreqEveryExcluding.Size = new System.Drawing.Size(71, 16);
      this.cbDailyFreqEveryExcluding.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
      this.cbDailyFreqEveryExcluding.TabIndex = 14;
      this.cbDailyFreqEveryExcluding.Text = "Excluding:";
      this.cbDailyFreqEveryExcluding.ThemesEnabled = true;
      this.cbDailyFreqEveryExcluding.CheckedChanged += new System.EventHandler(this.cbDailyFreqEveryExcluding_CheckedChanged);
      // 
      // dtpDailyFreqEveryExcludingTo
      // 
      this.dtpDailyFreqEveryExcludingTo.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
      this.dtpDailyFreqEveryExcludingTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.dtpDailyFreqEveryExcludingTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.dtpDailyFreqEveryExcludingTo.CalendarSize = new System.Drawing.Size(189, 176);
      this.dtpDailyFreqEveryExcludingTo.DropDownImage = null;
      this.dtpDailyFreqEveryExcludingTo.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpDailyFreqEveryExcludingTo.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpDailyFreqEveryExcludingTo.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
      this.dtpDailyFreqEveryExcludingTo.EnableNullDate = false;
      this.dtpDailyFreqEveryExcludingTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpDailyFreqEveryExcludingTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.dtpDailyFreqEveryExcludingTo.Location = new System.Drawing.Point(337, 88);
      this.dtpDailyFreqEveryExcludingTo.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpDailyFreqEveryExcludingTo.MinValue = new System.DateTime(((long)(0)));
      this.dtpDailyFreqEveryExcludingTo.Name = "dtpDailyFreqEveryExcludingTo";
      this.dtpDailyFreqEveryExcludingTo.ShowCheckBox = false;
      this.dtpDailyFreqEveryExcludingTo.ShowDropButton = false;
      this.dtpDailyFreqEveryExcludingTo.ShowUpDown = true;
      this.dtpDailyFreqEveryExcludingTo.Size = new System.Drawing.Size(82, 20);
      this.dtpDailyFreqEveryExcludingTo.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
      this.dtpDailyFreqEveryExcludingTo.TabIndex = 8;
      this.dtpDailyFreqEveryExcludingTo.ThemesEnabled = true;
      this.dtpDailyFreqEveryExcludingTo.Value = new System.DateTime(2018, 3, 29, 7, 0, 0, 0);
      this.dtpDailyFreqEveryExcludingTo.ValueChanged += new System.EventHandler(this.onChange_RefreshUI);
      // 
      // dtpDailyFreqEveryExcludingFrom
      // 
      this.dtpDailyFreqEveryExcludingFrom.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
      this.dtpDailyFreqEveryExcludingFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.dtpDailyFreqEveryExcludingFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.dtpDailyFreqEveryExcludingFrom.CalendarSize = new System.Drawing.Size(189, 176);
      this.dtpDailyFreqEveryExcludingFrom.DropDownImage = null;
      this.dtpDailyFreqEveryExcludingFrom.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpDailyFreqEveryExcludingFrom.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpDailyFreqEveryExcludingFrom.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
      this.dtpDailyFreqEveryExcludingFrom.EnableNullDate = false;
      this.dtpDailyFreqEveryExcludingFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpDailyFreqEveryExcludingFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.dtpDailyFreqEveryExcludingFrom.Location = new System.Drawing.Point(212, 87);
      this.dtpDailyFreqEveryExcludingFrom.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpDailyFreqEveryExcludingFrom.MinValue = new System.DateTime(((long)(0)));
      this.dtpDailyFreqEveryExcludingFrom.Name = "dtpDailyFreqEveryExcludingFrom";
      this.dtpDailyFreqEveryExcludingFrom.ShowCheckBox = false;
      this.dtpDailyFreqEveryExcludingFrom.ShowDropButton = false;
      this.dtpDailyFreqEveryExcludingFrom.ShowUpDown = true;
      this.dtpDailyFreqEveryExcludingFrom.Size = new System.Drawing.Size(82, 20);
      this.dtpDailyFreqEveryExcludingFrom.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
      this.dtpDailyFreqEveryExcludingFrom.TabIndex = 7;
      this.dtpDailyFreqEveryExcludingFrom.ThemesEnabled = true;
      this.dtpDailyFreqEveryExcludingFrom.Value = new System.DateTime(2018, 3, 29, 0, 0, 0, 0);
      this.dtpDailyFreqEveryExcludingFrom.ValueChanged += new System.EventHandler(this.onChange_RefreshUI);
      // 
      // lblDailyFreqEveryEndAt
      // 
      this.lblDailyFreqEveryEndAt.AutoSize = true;
      this.lblDailyFreqEveryEndAt.Location = new System.Drawing.Point(306, 90);
      this.lblDailyFreqEveryEndAt.Name = "lblDailyFreqEveryEndAt";
      this.lblDailyFreqEveryEndAt.Size = new System.Drawing.Size(23, 13);
      this.lblDailyFreqEveryEndAt.TabIndex = 8;
      this.lblDailyFreqEveryEndAt.Text = "To:";
      // 
      // cbDailyFreqEvery
      // 
      this.cbDailyFreqEvery.BackColor = System.Drawing.Color.White;
      this.cbDailyFreqEvery.BeforeTouchSize = new System.Drawing.Size(80, 21);
      this.cbDailyFreqEvery.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
      this.cbDailyFreqEvery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbDailyFreqEvery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbDailyFreqEvery.IgnoreThemeBackground = false;
      this.cbDailyFreqEvery.Items.AddRange(new object[] {
            "minute(s)",
            "hour(s)"});
      this.cbDailyFreqEvery.Location = new System.Drawing.Point(175, 53);
      this.cbDailyFreqEvery.Name = "cbDailyFreqEvery";
      this.cbDailyFreqEvery.Size = new System.Drawing.Size(80, 21);
      this.cbDailyFreqEvery.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
      this.cbDailyFreqEvery.TabIndex = 6;
      this.cbDailyFreqEvery.Text = "minute(s)";
      this.cbDailyFreqEvery.SelectedIndexChanged += new System.EventHandler(this.onChange_RefreshUI);
      // 
      // nbDailyFreqEvery
      // 
      this.nbDailyFreqEvery.Location = new System.Drawing.Point(124, 53);
      this.nbDailyFreqEvery.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
      this.nbDailyFreqEvery.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nbDailyFreqEvery.Name = "nbDailyFreqEvery";
      this.nbDailyFreqEvery.Size = new System.Drawing.Size(45, 20);
      this.nbDailyFreqEvery.TabIndex = 5;
      this.nbDailyFreqEvery.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.nbDailyFreqEvery.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nbDailyFreqEvery.ValueChanged += new System.EventHandler(this.onChange_RefreshUI);
      // 
      // lblDailyFreqEveryStartAt
      // 
      this.lblDailyFreqEveryStartAt.AutoSize = true;
      this.lblDailyFreqEveryStartAt.Location = new System.Drawing.Point(172, 90);
      this.lblDailyFreqEveryStartAt.Name = "lblDailyFreqEveryStartAt";
      this.lblDailyFreqEveryStartAt.Size = new System.Drawing.Size(33, 13);
      this.lblDailyFreqEveryStartAt.TabIndex = 5;
      this.lblDailyFreqEveryStartAt.Text = "From:";
      // 
      // dtpDailyFreqOnce
      // 
      this.dtpDailyFreqOnce.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
      this.dtpDailyFreqOnce.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.dtpDailyFreqOnce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.dtpDailyFreqOnce.CalendarSize = new System.Drawing.Size(189, 176);
      this.dtpDailyFreqOnce.DropDownImage = null;
      this.dtpDailyFreqOnce.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpDailyFreqOnce.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpDailyFreqOnce.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
      this.dtpDailyFreqOnce.EnableNullDate = false;
      this.dtpDailyFreqOnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpDailyFreqOnce.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.dtpDailyFreqOnce.Location = new System.Drawing.Point(124, 22);
      this.dtpDailyFreqOnce.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.dtpDailyFreqOnce.MinValue = new System.DateTime(((long)(0)));
      this.dtpDailyFreqOnce.Name = "dtpDailyFreqOnce";
      this.dtpDailyFreqOnce.ShowCheckBox = false;
      this.dtpDailyFreqOnce.ShowDropButton = false;
      this.dtpDailyFreqOnce.ShowUpDown = true;
      this.dtpDailyFreqOnce.Size = new System.Drawing.Size(131, 20);
      this.dtpDailyFreqOnce.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
      this.dtpDailyFreqOnce.TabIndex = 3;
      this.dtpDailyFreqOnce.ThemesEnabled = true;
      this.dtpDailyFreqOnce.Value = new System.DateTime(2018, 3, 29, 8, 0, 0, 0);
      this.dtpDailyFreqOnce.ValueChanged += new System.EventHandler(this.onChange_RefreshUI);
      // 
      // rbDailyFreqEvery
      // 
      this.rbDailyFreqEvery.AutoSize = true;
      this.rbDailyFreqEvery.BeforeTouchSize = new System.Drawing.Size(88, 16);
      this.rbDailyFreqEvery.ForeColor = System.Drawing.SystemColors.ControlText;
      this.rbDailyFreqEvery.Location = new System.Drawing.Point(17, 55);
      this.rbDailyFreqEvery.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.rbDailyFreqEvery.Name = "rbDailyFreqEvery";
      this.rbDailyFreqEvery.Size = new System.Drawing.Size(88, 16);
      this.rbDailyFreqEvery.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
      this.rbDailyFreqEvery.TabIndex = 4;
      this.rbDailyFreqEvery.TabStop = false;
      this.rbDailyFreqEvery.Text = "Occurs every:";
      this.rbDailyFreqEvery.ThemesEnabled = true;
      this.rbDailyFreqEvery.CheckChanged += new System.EventHandler(this.rbDailyFreqEvery_CheckedChanged);
      // 
      // rbDailyFreqOnce
      // 
      this.rbDailyFreqOnce.AutoSize = true;
      this.rbDailyFreqOnce.BeforeTouchSize = new System.Drawing.Size(98, 16);
      this.rbDailyFreqOnce.Checked = true;
      this.rbDailyFreqOnce.ForeColor = System.Drawing.SystemColors.ControlText;
      this.rbDailyFreqOnce.Location = new System.Drawing.Point(17, 24);
      this.rbDailyFreqOnce.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.rbDailyFreqOnce.Name = "rbDailyFreqOnce";
      this.rbDailyFreqOnce.Size = new System.Drawing.Size(98, 16);
      this.rbDailyFreqOnce.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
      this.rbDailyFreqOnce.TabIndex = 2;
      this.rbDailyFreqOnce.Text = "Occurs once at:";
      this.rbDailyFreqOnce.ThemesEnabled = true;
      this.rbDailyFreqOnce.CheckChanged += new System.EventHandler(this.rbDailyFreqOnce_CheckedChanged);
      // 
      // tbBackup
      // 
      this.tbBackup.Controls.Add(this.btnBackupDelete);
      this.tbBackup.Controls.Add(this.btnBackupAdd);
      this.tbBackup.Controls.Add(this.cbBackupTotalMaxSizeUnit);
      this.tbBackup.Controls.Add(this.nbBackupTotalMaxSize);
      this.tbBackup.Controls.Add(this.cbBackupNotificationsEnabled);
      this.tbBackup.Controls.Add(this.lblBackupTotalMaxSize);
      this.tbBackup.Controls.Add(this.glBackup);
      this.tbBackup.Controls.Add(this.cbBackupEnable);
      this.tbBackup.Image = null;
      this.tbBackup.ImageSize = new System.Drawing.Size(16, 16);
      this.tbBackup.Location = new System.Drawing.Point(3, 27);
      this.tbBackup.Name = "tbBackup";
      this.tbBackup.ShowCloseButton = false;
      this.tbBackup.Size = new System.Drawing.Size(485, 397);
      this.tbBackup.TabIndex = 2;
      this.tbBackup.Text = "Backup";
      this.tbBackup.ThemesEnabled = true;
      // 
      // btnBackupDelete
      // 
      this.btnBackupDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnBackupDelete.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
      this.btnBackupDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.btnBackupDelete.BeforeTouchSize = new System.Drawing.Size(69, 28);
      this.btnBackupDelete.ForeColor = System.Drawing.Color.White;
      this.btnBackupDelete.IsBackStageButton = false;
      this.btnBackupDelete.Location = new System.Drawing.Point(323, 283);
      this.btnBackupDelete.MetroColor = System.Drawing.Color.DarkOliveGreen;
      this.btnBackupDelete.Name = "btnBackupDelete";
      this.btnBackupDelete.Size = new System.Drawing.Size(69, 28);
      this.btnBackupDelete.TabIndex = 8;
      this.btnBackupDelete.Text = "Delete";
      this.btnBackupDelete.UseVisualStyle = true;
      this.btnBackupDelete.UseVisualStyleBackColor = true;
      // 
      // btnBackupAdd
      // 
      this.btnBackupAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnBackupAdd.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
      this.btnBackupAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.btnBackupAdd.BeforeTouchSize = new System.Drawing.Size(69, 28);
      this.btnBackupAdd.ForeColor = System.Drawing.Color.White;
      this.btnBackupAdd.IsBackStageButton = false;
      this.btnBackupAdd.Location = new System.Drawing.Point(403, 283);
      this.btnBackupAdd.MetroColor = System.Drawing.Color.DarkOliveGreen;
      this.btnBackupAdd.Name = "btnBackupAdd";
      this.btnBackupAdd.Size = new System.Drawing.Size(69, 28);
      this.btnBackupAdd.TabIndex = 7;
      this.btnBackupAdd.Text = "Add";
      this.btnBackupAdd.UseVisualStyle = true;
      this.btnBackupAdd.UseVisualStyleBackColor = true;
      // 
      // cbBackupTotalMaxSizeUnit
      // 
      this.cbBackupTotalMaxSizeUnit.AllowNewText = false;
      this.cbBackupTotalMaxSizeUnit.BackColor = System.Drawing.Color.White;
      this.cbBackupTotalMaxSizeUnit.BeforeTouchSize = new System.Drawing.Size(61, 21);
      this.cbBackupTotalMaxSizeUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbBackupTotalMaxSizeUnit.Location = new System.Drawing.Point(196, 290);
      this.cbBackupTotalMaxSizeUnit.Name = "cbBackupTotalMaxSizeUnit";
      this.cbBackupTotalMaxSizeUnit.Size = new System.Drawing.Size(61, 21);
      this.cbBackupTotalMaxSizeUnit.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
      this.cbBackupTotalMaxSizeUnit.TabIndex = 6;
      // 
      // nbBackupTotalMaxSize
      // 
      this.nbBackupTotalMaxSize.BeforeTouchSize = new System.Drawing.Size(81, 20);
      this.nbBackupTotalMaxSize.Location = new System.Drawing.Point(109, 290);
      this.nbBackupTotalMaxSize.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
      this.nbBackupTotalMaxSize.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.nbBackupTotalMaxSize.Name = "nbBackupTotalMaxSize";
      this.nbBackupTotalMaxSize.Size = new System.Drawing.Size(81, 20);
      this.nbBackupTotalMaxSize.TabIndex = 5;
      this.nbBackupTotalMaxSize.ThemesEnabled = true;
      this.nbBackupTotalMaxSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nbBackupTotalMaxSize.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
      // 
      // cbBackupNotificationsEnabled
      // 
      this.cbBackupNotificationsEnabled.BeforeTouchSize = new System.Drawing.Size(217, 21);
      this.cbBackupNotificationsEnabled.Location = new System.Drawing.Point(16, 316);
      this.cbBackupNotificationsEnabled.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.cbBackupNotificationsEnabled.Name = "cbBackupNotificationsEnabled";
      this.cbBackupNotificationsEnabled.Size = new System.Drawing.Size(217, 21);
      this.cbBackupNotificationsEnabled.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
      this.cbBackupNotificationsEnabled.TabIndex = 3;
      this.cbBackupNotificationsEnabled.Text = "Enable desktop notifications";
      this.cbBackupNotificationsEnabled.ThemesEnabled = true;
      // 
      // lblBackupTotalMaxSize
      // 
      this.lblBackupTotalMaxSize.AutoSize = true;
      this.lblBackupTotalMaxSize.Location = new System.Drawing.Point(15, 293);
      this.lblBackupTotalMaxSize.Name = "lblBackupTotalMaxSize";
      this.lblBackupTotalMaxSize.Size = new System.Drawing.Size(83, 13);
      this.lblBackupTotalMaxSize.TabIndex = 2;
      this.lblBackupTotalMaxSize.Text = "Total Max. Size:";
      // 
      // glBackup
      // 
      this.glBackup.BackColor = System.Drawing.Color.White;
      this.glBackup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.glBackup.ItemHeight = 17;
      this.glBackup.Location = new System.Drawing.Point(14, 41);
      this.glBackup.Name = "glBackup";
      this.glBackup.Properties.BackgroundColor = System.Drawing.SystemColors.Window;
      this.glBackup.SelectedIndex = -1;
      this.glBackup.Size = new System.Drawing.Size(458, 234);
      this.glBackup.TabIndex = 1;
      this.glBackup.TopIndex = 0;
      // 
      // cbBackupEnable
      // 
      this.cbBackupEnable.BeforeTouchSize = new System.Drawing.Size(150, 21);
      this.cbBackupEnable.Checked = true;
      this.cbBackupEnable.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbBackupEnable.Location = new System.Drawing.Point(14, 14);
      this.cbBackupEnable.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.cbBackupEnable.Name = "cbBackupEnable";
      this.cbBackupEnable.Size = new System.Drawing.Size(150, 21);
      this.cbBackupEnable.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
      this.cbBackupEnable.TabIndex = 0;
      this.cbBackupEnable.Text = "Enable backups";
      this.cbBackupEnable.ThemesEnabled = true;
      this.cbBackupEnable.CheckedChanged += new System.EventHandler(this.cbBackupEnable_CheckedChanged);
      // 
      // tbAdvanced
      // 
      this.tbAdvanced.Controls.Add(this.cbPruningStrategy);
      this.tbAdvanced.Controls.Add(this.lblPruningStrategy);
      this.tbAdvanced.Controls.Add(this.label3);
      this.tbAdvanced.Controls.Add(this.tbSnapExclWriters);
      this.tbAdvanced.Controls.Add(this.tbSnapInclWriters);
      this.tbAdvanced.Controls.Add(this.lblSnapExclWriters);
      this.tbAdvanced.Controls.Add(this.lblSnapInclWriters);
      this.tbAdvanced.Controls.Add(this.lblAdvWarning);
      this.tbAdvanced.Controls.Add(this.nbSnapFailRetryCount);
      this.tbAdvanced.Controls.Add(this.cbSnapFailRestartVSS);
      this.tbAdvanced.Controls.Add(this.lblSnapFailRetryCount);
      this.tbAdvanced.Controls.Add(this.cbSnapType);
      this.tbAdvanced.Controls.Add(this.lblSnapType);
      this.tbAdvanced.Controls.Add(this.cbSnapContext);
      this.tbAdvanced.Controls.Add(this.lblSnapContext);
      this.tbAdvanced.Image = null;
      this.tbAdvanced.ImageSize = new System.Drawing.Size(16, 16);
      this.tbAdvanced.Location = new System.Drawing.Point(3, 27);
      this.tbAdvanced.Name = "tbAdvanced";
      this.tbAdvanced.ShowCloseButton = true;
      this.tbAdvanced.Size = new System.Drawing.Size(485, 397);
      this.tbAdvanced.TabIndex = 4;
      this.tbAdvanced.Text = "Advanced";
      this.tbAdvanced.ThemesEnabled = true;
      // 
      // cbPruningStrategy
      // 
      this.cbPruningStrategy.AllowNewText = false;
      this.cbPruningStrategy.BackColor = System.Drawing.Color.White;
      this.cbPruningStrategy.BeforeTouchSize = new System.Drawing.Size(204, 21);
      this.cbPruningStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbPruningStrategy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbPruningStrategy.Location = new System.Drawing.Point(151, 181);
      this.cbPruningStrategy.Name = "cbPruningStrategy";
      this.cbPruningStrategy.Size = new System.Drawing.Size(204, 21);
      this.cbPruningStrategy.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
      this.cbPruningStrategy.TabIndex = 24;
      // 
      // lblPruningStrategy
      // 
      this.lblPruningStrategy.AutoSize = true;
      this.lblPruningStrategy.Location = new System.Drawing.Point(7, 185);
      this.lblPruningStrategy.Name = "lblPruningStrategy";
      this.lblPruningStrategy.Size = new System.Drawing.Size(86, 13);
      this.lblPruningStrategy.TabIndex = 23;
      this.lblPruningStrategy.Text = "Pruning strategy:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(7, 340);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(99, 13);
      this.label3.TabIndex = 22;
      this.label3.Text = "* Comma separated";
      // 
      // tbSnapExclWriters
      // 
      this.tbSnapExclWriters.BeforeTouchSize = new System.Drawing.Size(298, 20);
      this.tbSnapExclWriters.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.tbSnapExclWriters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbSnapExclWriters.Location = new System.Drawing.Point(151, 99);
      this.tbSnapExclWriters.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.tbSnapExclWriters.Name = "tbSnapExclWriters";
      this.tbSnapExclWriters.Size = new System.Drawing.Size(298, 20);
      this.tbSnapExclWriters.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
      this.tbSnapExclWriters.TabIndex = 21;
      // 
      // tbSnapInclWriters
      // 
      this.tbSnapInclWriters.BeforeTouchSize = new System.Drawing.Size(298, 20);
      this.tbSnapInclWriters.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.tbSnapInclWriters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbSnapInclWriters.Location = new System.Drawing.Point(151, 72);
      this.tbSnapInclWriters.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.tbSnapInclWriters.Name = "tbSnapInclWriters";
      this.tbSnapInclWriters.Size = new System.Drawing.Size(298, 20);
      this.tbSnapInclWriters.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
      this.tbSnapInclWriters.TabIndex = 20;
      // 
      // lblSnapExclWriters
      // 
      this.lblSnapExclWriters.AutoSize = true;
      this.lblSnapExclWriters.Location = new System.Drawing.Point(7, 103);
      this.lblSnapExclWriters.Name = "lblSnapExclWriters";
      this.lblSnapExclWriters.Size = new System.Drawing.Size(85, 13);
      this.lblSnapExclWriters.TabIndex = 19;
      this.lblSnapExclWriters.Text = "Exclude writers*:";
      // 
      // lblSnapInclWriters
      // 
      this.lblSnapInclWriters.AutoSize = true;
      this.lblSnapInclWriters.Location = new System.Drawing.Point(7, 75);
      this.lblSnapInclWriters.Name = "lblSnapInclWriters";
      this.lblSnapInclWriters.Size = new System.Drawing.Size(82, 13);
      this.lblSnapInclWriters.TabIndex = 18;
      this.lblSnapInclWriters.Text = "Include writers*:";
      // 
      // lblAdvWarning
      // 
      this.lblAdvWarning.AutoSize = true;
      this.lblAdvWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAdvWarning.Location = new System.Drawing.Point(7, 362);
      this.lblAdvWarning.MaximumSize = new System.Drawing.Size(478, 0);
      this.lblAdvWarning.Name = "lblAdvWarning";
      this.lblAdvWarning.Size = new System.Drawing.Size(442, 26);
      this.lblAdvWarning.TabIndex = 17;
      this.lblAdvWarning.Text = "WARNING: Do not change settings on this page, unless you understand the consequen" +
    "ces.";
      // 
      // nbSnapFailRetryCount
      // 
      this.nbSnapFailRetryCount.Location = new System.Drawing.Point(151, 127);
      this.nbSnapFailRetryCount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
      this.nbSnapFailRetryCount.Name = "nbSnapFailRetryCount";
      this.nbSnapFailRetryCount.Size = new System.Drawing.Size(57, 20);
      this.nbSnapFailRetryCount.TabIndex = 16;
      this.nbSnapFailRetryCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.nbSnapFailRetryCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // cbSnapFailRestartVSS
      // 
      this.cbSnapFailRestartVSS.AutoSize = true;
      this.cbSnapFailRestartVSS.BeforeTouchSize = new System.Drawing.Size(185, 16);
      this.cbSnapFailRestartVSS.Checked = true;
      this.cbSnapFailRestartVSS.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbSnapFailRestartVSS.Location = new System.Drawing.Point(7, 157);
      this.cbSnapFailRestartVSS.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
      this.cbSnapFailRestartVSS.Name = "cbSnapFailRestartVSS";
      this.cbSnapFailRestartVSS.Size = new System.Drawing.Size(185, 16);
      this.cbSnapFailRestartVSS.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
      this.cbSnapFailRestartVSS.TabIndex = 15;
      this.cbSnapFailRestartVSS.Text = "On failure: Restart VSS (Service) ?";
      this.cbSnapFailRestartVSS.ThemesEnabled = true;
      // 
      // lblSnapFailRetryCount
      // 
      this.lblSnapFailRetryCount.AutoSize = true;
      this.lblSnapFailRetryCount.Location = new System.Drawing.Point(7, 131);
      this.lblSnapFailRetryCount.Name = "lblSnapFailRetryCount";
      this.lblSnapFailRetryCount.Size = new System.Drawing.Size(122, 13);
      this.lblSnapFailRetryCount.TabIndex = 9;
      this.lblSnapFailRetryCount.Text = "On failure: Retry count ?";
      // 
      // cbSnapType
      // 
      this.cbSnapType.AllowNewText = false;
      this.cbSnapType.BackColor = System.Drawing.Color.White;
      this.cbSnapType.BeforeTouchSize = new System.Drawing.Size(204, 21);
      this.cbSnapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbSnapType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbSnapType.Location = new System.Drawing.Point(151, 43);
      this.cbSnapType.Name = "cbSnapType";
      this.cbSnapType.Size = new System.Drawing.Size(204, 21);
      this.cbSnapType.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
      this.cbSnapType.TabIndex = 8;
      // 
      // lblSnapType
      // 
      this.lblSnapType.AutoSize = true;
      this.lblSnapType.Location = new System.Drawing.Point(7, 47);
      this.lblSnapType.Name = "lblSnapType";
      this.lblSnapType.Size = new System.Drawing.Size(78, 13);
      this.lblSnapType.TabIndex = 7;
      this.lblSnapType.Text = "Snapshot type:";
      // 
      // cbSnapContext
      // 
      this.cbSnapContext.AllowNewText = false;
      this.cbSnapContext.BackColor = System.Drawing.Color.White;
      this.cbSnapContext.BeforeTouchSize = new System.Drawing.Size(204, 21);
      this.cbSnapContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbSnapContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbSnapContext.Location = new System.Drawing.Point(151, 15);
      this.cbSnapContext.Name = "cbSnapContext";
      this.cbSnapContext.Size = new System.Drawing.Size(204, 21);
      this.cbSnapContext.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
      this.cbSnapContext.TabIndex = 6;
      // 
      // lblSnapContext
      // 
      this.lblSnapContext.AutoSize = true;
      this.lblSnapContext.Location = new System.Drawing.Point(7, 19);
      this.lblSnapContext.Name = "lblSnapContext";
      this.lblSnapContext.Size = new System.Drawing.Size(93, 13);
      this.lblSnapContext.TabIndex = 5;
      this.lblSnapContext.Text = "Snapshot context:";
      // 
      // lblMaxCountVal
      // 
      this.lblMaxCountVal.AutoSize = true;
      this.lblMaxCountVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMaxCountVal.Location = new System.Drawing.Point(78, 468);
      this.lblMaxCountVal.MaximumSize = new System.Drawing.Size(391, 72);
      this.lblMaxCountVal.Name = "lblMaxCountVal";
      this.lblMaxCountVal.Size = new System.Drawing.Size(15, 16);
      this.lblMaxCountVal.TabIndex = 14;
      this.lblMaxCountVal.Text = "0";
      // 
      // lblMaxCount
      // 
      this.lblMaxCount.AutoSize = true;
      this.lblMaxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMaxCount.Location = new System.Drawing.Point(7, 467);
      this.lblMaxCount.Name = "lblMaxCount";
      this.lblMaxCount.Size = new System.Drawing.Size(71, 16);
      this.lblMaxCount.TabIndex = 13;
      this.lblMaxCount.Text = "Max count:";
      // 
      // skinManager
      // 
      this.skinManager.Controls = null;
      this.skinManager.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Metro;
      // 
      // EditSnapshotRuleForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(482, 580);
      this.Controls.Add(this.lblMaxCountVal);
      this.Controls.Add(this.lblMaxCount);
      this.Controls.Add(this.tabControlAdv1);
      this.Controls.Add(this.lblGenCron);
      this.Controls.Add(this.tbGenCron);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnCreate);
      this.Controls.Add(this.lblHumanSched);
      this.Controls.Add(this.lblGenSched);
      this.Controls.Add(this.cbEnabled);
      this.Controls.Add(this.tbName);
      this.Controls.Add(this.lblName);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximumSize = new System.Drawing.Size(1000, 1000);
      this.MinimumSize = new System.Drawing.Size(494, 540);
      this.Name = "EditSnapshotRuleForm";
      this.ShowIcon = false;
      this.Text = "Edit Snapshot";
      ((System.ComponentModel.ISupportInitialize)(this.tbName)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbEnabled)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbGenCron)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
      this.tabControlAdv1.ResumeLayout(false);
      this.tpSnapshot.ResumeLayout(false);
      this.tpSnapshot.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cblDriveLetters)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbLifetime)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nbLifetime)).EndInit();
      this.tpSchedule.ResumeLayout(false);
      this.gbPeriod.ResumeLayout(false);
      this.gbPeriod.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtpPeriodEnd)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbPeriodEndDate)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbPeriodEndNever)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtpPeriodStart)).EndInit();
      this.gbFreq.ResumeLayout(false);
      this.plFreqCron.ResumeLayout(false);
      this.plFreqCron.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cbFreqCronExcluding)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtpFreqCronExcludingTo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtpFreqCronExcludingFrom)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbFreqCron)).EndInit();
      this.plFreqMonthly.ResumeLayout(false);
      this.plFreqMonthly.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cblFreqMonthlyDays)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cblFreqMonthlyMonths)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbFreqCron)).EndInit();
      this.plFreqWeekly.ResumeLayout(false);
      this.plFreqWeekly.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.rbFreqWeeklyOn)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbFreqWeeklyEvery)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbFreqWeeklySaturday)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbFreqWeeklyFriday)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbFreqWeeklyThursday)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbFreqWeeklyWednesday)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbFreqWeeklyTuesday)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbFreqWeeklyMonday)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbFreqWeeklySunday)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nbFreqWeekly)).EndInit();
      this.plFreqDaily.ResumeLayout(false);
      this.plFreqDaily.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nbFreqDaily)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbFreqMonthly)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbFreqWeekly)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbFreqDaily)).EndInit();
      this.gbDailyFreq.ResumeLayout(false);
      this.gbDailyFreq.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cbDailyFreqEveryExcluding)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtpDailyFreqEveryExcludingTo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtpDailyFreqEveryExcludingFrom)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbDailyFreqEvery)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nbDailyFreqEvery)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtpDailyFreqOnce)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbDailyFreqEvery)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbDailyFreqOnce)).EndInit();
      this.tbBackup.ResumeLayout(false);
      this.tbBackup.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cbBackupTotalMaxSizeUnit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nbBackupTotalMaxSize)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbBackupNotificationsEnabled)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.glBackup)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbBackupEnable)).EndInit();
      this.tbAdvanced.ResumeLayout(false);
      this.tbAdvanced.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cbPruningStrategy)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbSnapExclWriters)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbSnapInclWriters)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nbSnapFailRetryCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbSnapFailRestartVSS)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbSnapType)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbSnapContext)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label lblName;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt tbName;
    private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbEnabled;
    private Syncfusion.Windows.Forms.ButtonAdv btnCreate;
    private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
    private System.Windows.Forms.Label lblGenSched;
    private System.Windows.Forms.Label lblHumanSched;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt tbGenCron;
    private System.Windows.Forms.Label lblGenCron;
    private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
    private Syncfusion.Windows.Forms.Tools.TabPageAdv tpSchedule;
    private System.Windows.Forms.GroupBox gbPeriod;
    private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtpPeriodEnd;
    private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbPeriodEndDate;
    private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbPeriodEndNever;
    private System.Windows.Forms.Label lblPeriodEnd;
    private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtpPeriodStart;
    private System.Windows.Forms.Label lblPeriodStart;
    private System.Windows.Forms.GroupBox gbFreq;
    private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbFreqCron;
    private System.Windows.Forms.Panel plFreqWeekly;
    private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbFreqWeeklyOn;
    private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbFreqWeeklyEvery;
    private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbFreqWeeklySaturday;
    private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbFreqWeeklyFriday;
    private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbFreqWeeklyThursday;
    private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbFreqWeeklyWednesday;
    private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbFreqWeeklyTuesday;
    private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbFreqWeeklyMonday;
    private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbFreqWeeklySunday;
    private System.Windows.Forms.Label lblFreqWeeklyWeeks;
    private System.Windows.Forms.NumericUpDown nbFreqWeekly;
    private System.Windows.Forms.Panel plFreqMonthly;
    private EWSoftware.ListControls.CheckBoxList cblFreqMonthlyDays;
    private System.Windows.Forms.Label lblFreqMonthlyDays;
    private EWSoftware.ListControls.CheckBoxList cblFreqMonthlyMonths;
    private System.Windows.Forms.Label lblFreqMonthlyMonths;
    private System.Windows.Forms.Panel plFreqDaily;
    private System.Windows.Forms.Label lblFreqDailyDays;
    private System.Windows.Forms.NumericUpDown nbFreqDaily;
    private System.Windows.Forms.Label lblFreqDailyEvery;
    private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbFreqMonthly;
    private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbFreqWeekly;
    private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbFreqDaily;
    private System.Windows.Forms.Panel plFreqCron;
    private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbFreqCronExcluding;
    private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtpFreqCronExcludingTo;
    private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtpFreqCronExcludingFrom;
    private System.Windows.Forms.Label lblFreqCronEnd;
    private System.Windows.Forms.Label lblFreqCronStart;
    private System.Windows.Forms.Label lblFreqCronHelp;
    private System.Windows.Forms.LinkLabel llbFreqCronGen;
    private System.Windows.Forms.LinkLabel llbFreqCronHelp;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt tbFreqCron;
    private System.Windows.Forms.Label lblFreqCron;
    private System.Windows.Forms.GroupBox gbDailyFreq;
    private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtpDailyFreqEveryExcludingTo;
    private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtpDailyFreqEveryExcludingFrom;
    private System.Windows.Forms.Label lblDailyFreqEveryEndAt;
    private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbDailyFreqEvery;
    private System.Windows.Forms.NumericUpDown nbDailyFreqEvery;
    private System.Windows.Forms.Label lblDailyFreqEveryStartAt;
    private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtpDailyFreqOnce;
    private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbDailyFreqEvery;
    private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbDailyFreqOnce;
    private Syncfusion.Windows.Forms.Tools.TabPageAdv tbBackup;
    private Syncfusion.Windows.Forms.Tools.TabPageAdv tpSnapshot;
    private Syncfusion.Windows.Forms.Tools.NumericUpDownExt nbLifetime;
    private System.Windows.Forms.Label lblDriveLetters;
    private System.Windows.Forms.Label lblLifetimeHelp;
    private System.Windows.Forms.Label lblLifetime;
    private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbLifetime;
    private System.Windows.Forms.Label lblMaxCountVal;
    private System.Windows.Forms.Label lblMaxCount;
    private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbBackupEnable;
    private Syncfusion.Windows.Forms.Grid.GridListControl glBackup;
    private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbBackupTotalMaxSizeUnit;
    private Syncfusion.Windows.Forms.Tools.NumericUpDownExt nbBackupTotalMaxSize;
    private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbBackupNotificationsEnabled;
    private System.Windows.Forms.Label lblBackupTotalMaxSize;
    private Syncfusion.Windows.Forms.ButtonAdv btnBackupDelete;
    private Syncfusion.Windows.Forms.ButtonAdv btnBackupAdd;
    private EWSoftware.ListControls.CheckBoxList cblDriveLetters;
    private Syncfusion.Windows.Forms.SkinManager skinManager;
    private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbDailyFreqEveryExcluding;
    private Syncfusion.Windows.Forms.Tools.TabPageAdv tbAdvanced;
    private System.Windows.Forms.NumericUpDown nbSnapFailRetryCount;
    private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbSnapFailRestartVSS;
    private System.Windows.Forms.Label lblSnapFailRetryCount;
    private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbSnapType;
    private System.Windows.Forms.Label lblSnapType;
    private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbSnapContext;
    private System.Windows.Forms.Label lblSnapContext;
    private System.Windows.Forms.Label lblAdvWarning;
    private System.Windows.Forms.Label lblSnapExclWriters;
    private System.Windows.Forms.Label lblSnapInclWriters;
    private System.Windows.Forms.Label label3;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt tbSnapExclWriters;
    private Syncfusion.Windows.Forms.Tools.TextBoxExt tbSnapInclWriters;
    private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbPruningStrategy;
    private System.Windows.Forms.Label lblPruningStrategy;
    private System.Windows.Forms.Button btnSystemProtection;
    private System.Windows.Forms.Label lblSnapLimitCount;
    private System.Windows.Forms.Label lblSnapLimit;
    private System.Windows.Forms.Button btnSnapLimitChange;
  }
}