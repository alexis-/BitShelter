using Alphaleonis.Win32.Vss;
using MyPreciousData.Agent.Controls;
using MyPreciousData.Agent.Forms;
using MyPreciousData.Data;
using MyPreciousData.Models;
using MyPreciousData.Utils;
using MyPreciousData.VSS;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyPreciousData
{
  public partial class SettingsForm : MetroForm
  {
    protected static SettingsForm _instance = null;
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
      dgSnapshotRules.DataSource = RuleMgr.Instance.Rules;
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
              RuleMgr.Instance.AddOrUpdateRule(rule);
            break;

          case "Delete":
            rule.PendingDelete = true;

            break;
        }
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      //ConfigMgr.Instance.SaveAppConfig();
      ConfigMgr.Instance.SaveRules(RuleMgr.Instance.Rules);

      Close();
    }

    private void btnAddSchedule_Click(object sender, EventArgs e)
    {
      SnapshotRule rule = EditSnapshotRuleForm.DisplayInstance();

      if (rule != null)
        RuleMgr.Instance.AddOrUpdateRule(rule);
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
  }
}
