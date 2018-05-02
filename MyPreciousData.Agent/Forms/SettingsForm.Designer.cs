namespace MyPreciousData
{
    partial class SettingsForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
      this.btnSave = new Syncfusion.Windows.Forms.ButtonAdv();
      this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
      this.skinManager = new Syncfusion.Windows.Forms.SkinManager(this.components);
      this.btnAddSchedule = new Syncfusion.Windows.Forms.ButtonAdv();
      this.dgSnapshotRules = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgSnapshotRules)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSave.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
      this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.btnSave.BeforeTouchSize = new System.Drawing.Size(120, 35);
      this.btnSave.ForeColor = System.Drawing.Color.White;
      this.btnSave.IsBackStageButton = false;
      this.btnSave.Location = new System.Drawing.Point(531, 408);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(120, 35);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "&Save && Close";
      this.btnSave.UseVisualStyle = true;
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
      this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.btnCancel.BeforeTouchSize = new System.Drawing.Size(120, 35);
      this.btnCancel.ForeColor = System.Drawing.Color.White;
      this.btnCancel.IsBackStageButton = false;
      this.btnCancel.Location = new System.Drawing.Point(399, 408);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 35);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyle = true;
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // skinManager
      // 
      this.skinManager.Controls = null;
      this.skinManager.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Metro;
      // 
      // btnAddSchedule
      // 
      this.btnAddSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAddSchedule.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
      this.btnAddSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
      this.btnAddSchedule.BeforeTouchSize = new System.Drawing.Size(144, 28);
      this.btnAddSchedule.ForeColor = System.Drawing.Color.White;
      this.btnAddSchedule.IsBackStageButton = false;
      this.btnAddSchedule.Location = new System.Drawing.Point(507, 2);
      this.btnAddSchedule.MetroColor = System.Drawing.Color.DarkOliveGreen;
      this.btnAddSchedule.Name = "btnAddSchedule";
      this.btnAddSchedule.Size = new System.Drawing.Size(144, 28);
      this.btnAddSchedule.TabIndex = 5;
      this.btnAddSchedule.Text = "Add Schedule";
      this.btnAddSchedule.UseVisualStyle = true;
      this.btnAddSchedule.UseVisualStyleBackColor = true;
      this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
      // 
      // dgSnapshotRules
      // 
      this.dgSnapshotRules.AllowUserToAddRows = false;
      this.dgSnapshotRules.AllowUserToOrderColumns = true;
      this.dgSnapshotRules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgSnapshotRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgSnapshotRules.Location = new System.Drawing.Point(4, 36);
      this.dgSnapshotRules.MultiSelect = false;
      this.dgSnapshotRules.Name = "dgSnapshotRules";
      this.dgSnapshotRules.ReadOnly = true;
      this.dgSnapshotRules.Size = new System.Drawing.Size(647, 366);
      this.dgSnapshotRules.TabIndex = 6;
      // 
      // SettingsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderThickness = 2;
      this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.ClientSize = new System.Drawing.Size(656, 450);
      this.Controls.Add(this.dgSnapshotRules);
      this.Controls.Add(this.btnAddSchedule);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "SettingsForm";
      this.Text = "MyPreciousData -  Settings";
      ((System.ComponentModel.ISupportInitialize)(this.dgSnapshotRules)).EndInit();
      this.ResumeLayout(false);

        }

    #endregion
    private Syncfusion.Windows.Forms.ButtonAdv btnSave;
    private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
    private Syncfusion.Windows.Forms.SkinManager skinManager;
    private Syncfusion.Windows.Forms.ButtonAdv btnAddSchedule;
    private System.Windows.Forms.DataGridView dgSnapshotRules;
  }
}