namespace BitShelter.Agent.Forms
{
  partial class SnapshotLimitForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnapshotLimitForm));
      this.lblLimit = new System.Windows.Forms.Label();
      this.nbLimit = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
      this.lblLimitDesc = new System.Windows.Forms.Label();
      this.lblMicrosoftRef = new System.Windows.Forms.LinkLabel();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.nbLimit)).BeginInit();
      this.SuspendLayout();
      // 
      // lblLimit
      // 
      this.lblLimit.AutoSize = true;
      this.lblLimit.Location = new System.Drawing.Point(18, 13);
      this.lblLimit.Name = "lblLimit";
      this.lblLimit.Size = new System.Drawing.Size(74, 13);
      this.lblLimit.TabIndex = 0;
      this.lblLimit.Text = "Maximum limit:";
      // 
      // nbLimit
      // 
      this.nbLimit.BeforeTouchSize = new System.Drawing.Size(64, 20);
      this.nbLimit.Location = new System.Drawing.Point(113, 9);
      this.nbLimit.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
      this.nbLimit.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.nbLimit.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            0});
      this.nbLimit.Name = "nbLimit";
      this.nbLimit.Size = new System.Drawing.Size(64, 20);
      this.nbLimit.TabIndex = 4;
      this.nbLimit.ThemesEnabled = true;
      this.nbLimit.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
      this.nbLimit.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
      // 
      // lblLimitDesc
      // 
      this.lblLimitDesc.Location = new System.Drawing.Point(12, 46);
      this.lblLimitDesc.Name = "lblLimitDesc";
      this.lblLimitDesc.Size = new System.Drawing.Size(418, 44);
      this.lblLimitDesc.TabIndex = 5;
      this.lblLimitDesc.Tag = "";
      this.lblLimitDesc.Text = resources.GetString("lblLimitDesc.Text");
      // 
      // lblMicrosoftRef
      // 
      this.lblMicrosoftRef.AutoSize = true;
      this.lblMicrosoftRef.Location = new System.Drawing.Point(15, 94);
      this.lblMicrosoftRef.Name = "lblMicrosoftRef";
      this.lblMicrosoftRef.Size = new System.Drawing.Size(377, 13);
      this.lblMicrosoftRef.TabIndex = 6;
      this.lblMicrosoftRef.TabStop = true;
      this.lblMicrosoftRef.Tag = "";
      this.lblMicrosoftRef.Text = "https://msdn.microsoft.com/en-us/library/bb891959.aspx?#maxshadowcopies";
      this.lblMicrosoftRef.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMicrosoftRef_LinkClicked);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(353, 123);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(80, 27);
      this.button1.TabIndex = 7;
      this.button1.Text = "Apply";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // SnapshotLimitForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(442, 157);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.lblMicrosoftRef);
      this.Controls.Add(this.lblLimitDesc);
      this.Controls.Add(this.nbLimit);
      this.Controls.Add(this.lblLimit);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "SnapshotLimitForm";
      this.ShowIcon = false;
      this.ShowMaximizeBox = false;
      this.Text = "Max. Snapshot Limit";
      ((System.ComponentModel.ISupportInitialize)(this.nbLimit)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblLimit;
    private Syncfusion.Windows.Forms.Tools.NumericUpDownExt nbLimit;
    private System.Windows.Forms.Label lblLimitDesc;
    private System.Windows.Forms.LinkLabel lblMicrosoftRef;
    private System.Windows.Forms.Button button1;
  }
}