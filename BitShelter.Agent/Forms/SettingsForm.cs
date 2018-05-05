using BitShelter.Agent;
using BitShelter.Agent.Forms;
using BitShelter.Agent.WCF;
using BitShelter.Models;
using BitShelter.WCF;
using Serilog;
using Syncfusion.Windows.Forms;
using System;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitShelter
{
  //[CallbackBehavior(UseSynchronizationContext = false)]
  public partial class SettingsForm : MetroForm, ISnapshotServiceCallback
  {
    protected const int RetryDelay = 5; // * 1000
    protected const string RetryText = "Connection to the service failed.\nRetrying in {0}...";

    protected static SettingsForm _instance = null;

    protected SynchronizationContext SyncContext { get; set; }
    protected int RetryCount { get; private set; }
    protected SnapshotClient SnapshotClient { get; private set; }


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

      SyncContext = SynchronizationContext.Current;

      SetupSnapshotDataGrid();
      ConnectSnapshotClient();
    }

    private void SetupSnapshotDataGrid()
    {
      dgSnapshotRules.AutoGenerateColumns = false;
      dgSnapshotRules.CellContentClick += DgSnapshotRules_CellContentClick;

      SetupSnapshotDataGridColumns();
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
      //snap.InnerDuplexChannel.Faulted
      try
      {
        dgSnapshotRules.DataSource = SnapshotClient.GetRules();

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
        SnapshotClient.AddOrUpdateRule(rule);

        dgSnapshotRules.DataSource = SnapshotClient.GetRules();

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
        SnapshotClient.DeleteRule(rule, deleteSnapshots);

        dgSnapshotRules.DataSource = SnapshotClient.GetRules();

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
              AddOrUpdateSnapshotRule(rule);
            break;

          case "Delete":
            var res = MessageBox.Show("Do you also want to delete existing Snapshots ?", "Confirm", MessageBoxButtons.YesNoCancel);

            if (res != DialogResult.Cancel)
              DeleteSnapshotRule(rule, res == DialogResult.Yes);

            break;
        }
      }
    }

    private void btnAddSchedule_Click(object sender, EventArgs e)
    {
      SnapshotRule rule = EditSnapshotRuleForm.DisplayInstance();

      if (rule != null)
        AddOrUpdateSnapshotRule(rule);
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

    private void SetupSnapshotClient()
    {
      if (SnapshotClient != null)
      {
        try
        {
          SnapshotClient.InnerChannel.Opened -= InnerChannel_Opened;
          SnapshotClient.InnerChannel.Faulted -= SnapshotClient_Faulted;
          SnapshotClient.Abort();
          SnapshotClient = null;
        }
        catch (Exception)
        {
        }
      }

      SnapshotClient = new SnapshotClient(new InstanceContext(this));
      
      SnapshotClient.InnerChannel.Opened += InnerChannel_Opened;
      SnapshotClient.InnerChannel.Faulted += SnapshotClient_Faulted;
    }

    private void InnerChannel_Opened(object sender, EventArgs e)
    {
      SendOrPostCallback updateUI = new SendOrPostCallback(arg =>
      {
        StopConnectionRetry();

        RefreshDataGrid();
      });

      SyncContext.Send(updateUI, null);
    }

    private void SnapshotClient_Faulted(object sender, EventArgs e)
    {
      if (!retryConnTimer.Enabled)
      {
        RetryCount = 0;

        SendOrPostCallback updateUI = new SendOrPostCallback(arg =>
        {
          StartConnectionRetry();
        });

        SyncContext.Send(updateUI, null);
      }
    }

    private void ConnectSnapshotClient()
    {
      SetupSnapshotClient();

      try
      {
        SnapshotClient.Open();
      }
      catch (Exception)
      {
      }
    }



    //
    // Connection retry

    private void StartConnectionRetry()
    {
      plSvcConnection.Visible = true;
      plSvcConnection.Enabled = true;
      plSvcConnection.BringToFront();

      //wb.Url = null;
      DisplayNewTrivia();

      retryConnTimer.Tag = RetryDelay;
      retryConnTimer.Start();
    }

    private void StopConnectionRetry()
    {
      plSvcConnection.Visible = false;
      plSvcConnection.Enabled = false;

      retryConnTimer.Stop();
    }

    private void DisplayNewTrivia()
    {
      if (wb.Url != null && wb.Url.ToString() != "about:blank")
        return;

      int idx = new Random().Next(AgentConst.Trivia.Length);

      wb.DocumentText = String.Format(@"
<html><body>
<table width=""100%""><tr><td><h3>Did you know ?</h3></td><td><p style=""float:right; font-size: 10px;"">(will refresh every 60sec, unless you browse)</p></td></tr></table>
<span>{0}</span>
<br/><br/>
<span><b>Source</b>: <a href=""https://en.wikipedia.org/wiki/List_of_common_misconceptions"">https://en.wikipedia.org/wiki/List_of_common_misconceptions</a></span>
</body></html>
", AgentConst.Trivia[idx]);
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

        ConnectSnapshotClient();

        //if (RefreshDataGrid())
        //{
        //  HideConnectionPanel();
        //  return;
        //}
      }
    }
  }
}
