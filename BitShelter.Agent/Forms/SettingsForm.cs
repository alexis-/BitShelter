using BitShelter.Agent.Forms;
using BitShelter.Agent.WCF;
using BitShelter.Models;
using BitShelter.WCF;
using Serilog;
using Syncfusion.Windows.Forms;
using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace BitShelter
{
  //[CallbackBehavior(UseSynchronizationContext = false)]
  public partial class SettingsForm : MetroForm, ISnapshotServiceCallback
  {
    private const int RetryDelay = 5; // * 1000
    private const string RetryText = "Connection to the service failed.\nRetrying in {0}...";

    protected static SettingsForm _instance = null;

    public int RetryCount { get; private set; }

    public static SettingsForm DisplayInstance()
    {
      _instance = _instance ?? new SettingsForm();

      _instance.Show();
      _instance.Focus();
      return _instance;
    }

    public static void CloseInstance()
    {
      if (_instance != null)
        _instance.Close();
    }


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

      _instance = null;

      base.Dispose(disposing);
    }

    protected SettingsForm()
    {
      InitializeComponent();

      SetupSnapshotDataGrid();
    }

    private void SetupSnapshotDataGrid()
    {
      dgSnapshotRules.AutoGenerateColumns = false;
      dgSnapshotRules.CellContentClick += DgSnapshotRules_CellContentClick;

      SetupSnapshotDataGridColumns();

      if (!RefreshDataGrid())
        DisplayConnectionPanel();
    }

    private void SetupSnapshotDataGridColumns()
    {
      dgSnapshotRules.Columns.Add(CreateCheckboxColumn("Enabled", "E?", DataGridViewAutoSizeColumnMode.None, 30));
      dgSnapshotRules.Columns.Add(CreateTextColumn("Name", "Name", DataGridViewAutoSizeColumnMode.AllCells));
      dgSnapshotRules.Columns.Add(CreateTextColumn("VolumesAsString", "Volumes", DataGridViewAutoSizeColumnMode.AllCells));
      dgSnapshotRules.Columns.Add(CreateTextColumn("ScheduleDescription", "Schedule", DataGridViewAutoSizeColumnMode.Fill));
      dgSnapshotRules.Columns.Add(CreateButtonColumn("Edit", "Edit", DataGridViewAutoSizeColumnMode.None, 44));
      dgSnapshotRules.Columns.Add(CreateButtonColumn("Delete", "Delete", DataGridViewAutoSizeColumnMode.None, 56));
    }

    private bool RefreshDataGrid()
    {
      try
      {
        using (SnapshotClient snap = new SnapshotClient(new InstanceContext(this)))
        {
          dgSnapshotRules.DataSource = snap.GetRules();
        }

        return true;
      }
      catch (Exception ex)
      {
        Log.Error(ex, "Error while refreshing Agent SnapshotRules Grid.");

        return false;
      }
    }

    private bool AddOrUpdateSnapshotRule(SnapshotRule rule)
    {
      try
      {
        using (SnapshotClient snap = new SnapshotClient(new InstanceContext(this)))
        {
          snap.AddOrUpdateRule(rule);

          dgSnapshotRules.DataSource = snap.GetRules();
        }

        return true;
      }
      catch (Exception ex)
      {
        Log.Error(ex, "Error while requesting Addition/Edition of SnapshotRule {Id}.", rule?.Id);

        return false;
      }
    }

    private bool DeleteSnapshotRule(SnapshotRule rule, bool deleteSnapshots)
    {
      try
      {
        using (SnapshotClient snap = new SnapshotClient(new InstanceContext(this)))
        {
          snap.DeleteRule(rule, deleteSnapshots);

          dgSnapshotRules.DataSource = snap.GetRules();
        }

        return true;
      }
      catch (Exception ex)
      {
        Log.Error(ex, "Error while requesting Deletion of SnapshotRule {Id}.", rule?.Id);

        return false;
      }
    }

    private DataGridViewButtonColumn CreateButtonColumn(string mappingName, string headerName, DataGridViewAutoSizeColumnMode autoSizeMode, int? width = null)
    {
      var ret = CreateColumnGeneric<DataGridViewButtonColumn>(mappingName, headerName, autoSizeMode, width);

      ret.Text = headerName;
      ret.UseColumnTextForButtonValue = true;

      return ret;
    }

    private DataGridViewCheckBoxColumn CreateCheckboxColumn(string mappingName, string headerName, DataGridViewAutoSizeColumnMode autoSizeMode, int? width = null)
    {
      return CreateColumnGeneric<DataGridViewCheckBoxColumn>(mappingName, headerName, autoSizeMode, width);
    }

    private DataGridViewTextBoxColumn CreateTextColumn(string mappingName, string headerName, DataGridViewAutoSizeColumnMode autoSizeMode, int? width = null)
    {
      return CreateColumnGeneric<DataGridViewTextBoxColumn>(mappingName, headerName, autoSizeMode, width);
    }

    private T CreateColumnGeneric<T>(string mappingName, string headerName, DataGridViewAutoSizeColumnMode autoSizeMode, int? width)
      where T : DataGridViewColumn, new()
    {
      T ret = new T();

      ret.Name = mappingName;
      ret.DataPropertyName = mappingName;
      ret.HeaderText = headerName;
      ret.AutoSizeMode = autoSizeMode;

      if (width != null)
        ret.Width = width.Value;

      return ret;
    }

    private void DgSnapshotRules_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      var senderGrid = (DataGridView)sender;

      if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
          e.RowIndex >= 0)
      {
        SnapshotRule rule = senderGrid.Rows[e.RowIndex].DataBoundItem as SnapshotRule;

        switch (senderGrid.Columns[e.ColumnIndex].Name)
        {
          case "Edit":
            rule = EditSnapshotRuleForm.DisplayInstance(rule);

            if (rule != null)
              if (!AddOrUpdateSnapshotRule(rule))
                DisplayConnectionPanel();
            break;

          case "Delete":
            var res = MessageBox.Show("Do you also want to delete existing Snapshots ?", "Confirm", MessageBoxButtons.YesNoCancel);

            if (res != DialogResult.Cancel)
              if (!DeleteSnapshotRule(rule, res == DialogResult.Yes))
                DisplayConnectionPanel();

            break;
        }
      }
    }

    private void btnAddSchedule_Click(object sender, EventArgs e)
    {
      SnapshotRule rule = EditSnapshotRuleForm.DisplayInstance();

      if (rule != null)
        if (!AddOrUpdateSnapshotRule(rule))
          DisplayConnectionPanel();
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      if (keyData == Keys.Escape)
      {
        Close();
        return true;
      }

      return base.ProcessCmdKey(ref msg, keyData);
    }

    public void Dummy() { }

    private void DisplayConnectionPanel()
    {
      plSvcConnection.Visible = true;
      plSvcConnection.Enabled = true;
      plSvcConnection.BringToFront();

      RetryCount = 0;

      //wb.Url = null;
      DisplayNewTrivia();

      retryConnTimer.Tag = RetryDelay;
      retryConnTimer.Start();
    }

    private void HideConnectionPanel()
    {
      plSvcConnection.Visible = false;
      plSvcConnection.Enabled = false;

      retryConnTimer.Stop();
    }

    private void DisplayNewTrivia()
    {
      if (wb.Url != null && wb.Url.ToString() != "about:blank")
        return;

      int idx = new Random().Next(BitShelter.Agent.AgentConst.Trivia.Length);

      wb.DocumentText = String.Format(@"
<html><body>
<table width=""100%""><tr><td><h3>Did you know ?</h3></td><td><p style=""float:right; font-size: 10px;"">(will refresh every 60sec, unless you browse)</p></td></tr></table>
<span>{0}</span>
<br/><br/>
<span><b>Source</b>: <a href=""https://en.wikipedia.org/wiki/List_of_common_misconceptions"">https://en.wikipedia.org/wiki/List_of_common_misconceptions</a></span>
</body></html>
", BitShelter.Agent.AgentConst.Trivia[idx]);
    }

    private void retryConnTimer_Tick(object sender, EventArgs e)
    {
      int retryCountdown = (int)retryConnTimer.Tag;
      retryConnTimer.Tag = retryCountdown = (retryCountdown <= 1) ? RetryDelay : retryCountdown - 1;

      lblConnWait.Text = String.Format(RetryText, retryCountdown);

      if (retryCountdown == RetryDelay)
      {
        RetryCount++;

        if (RetryCount % 12 == 0)
          DisplayNewTrivia();

        if (RefreshDataGrid())
        {
          HideConnectionPanel();
          return;
        }
      }
    }
  }
}
