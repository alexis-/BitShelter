using Alphaleonis.Win32.Vss;
using BitShelter.Models;
using BitShelter.Models.Enums;
using BitShelter.Utils;
using BitShelter.VSS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BitShelter.Agent.Forms
{
  partial class EditSnapshotRuleForm
  {
    public void InitBaseGeneral()
    {
      lblSnapLimitCount.Text = VSS.VssUtils.GetSnapshotLimit().ToString();

      cbLifetime.DataSource = Enum.GetValues(typeof(Timespan));
      cbLifetime.SelectedIndex = cbLifetime.Items.IndexOf(Timespan.Week);

      using (VssClient vss = new VssClient(new VssHost()))
      {
        vss.Initialize(VssSnapshotContext.ClientAccessible, VssBackupType.Incremental);

        cblDriveLetters.Items.AddRange(
          Volumes.ListVolumes()
          .Where(v => vss.IsVolumeSupported(v.DeviceID))
          .ToArray()
        );
      }
    }

    public void InitEditGeneral(SnapshotRule rule)
    {
      nbLifetime.Value = rule.LifeTimeValue;
      cbLifetime.SelectedIndex = cbLifetime.Items.IndexOf(rule.LifeTimeUnit);

      for (int i = 0; i < cblDriveLetters.Items.Count; i++)
        if (rule.Volumes.Contains(((Volume)cblDriveLetters.Items[i]).DeviceID))
          cblDriveLetters.SetItemChecked(i, true);
    }

    private void cblDriveLetters_ItemCheckStateChanged(object sender, EWSoftware.ListControls.ItemCheckStateEventArgs e)
    {
      RefreshUI();
    }

    private void btnSnapLimitChange_Click(object sender, EventArgs e)
    {
      new SnapshotLimitForm().ShowDialog();

      lblSnapLimitCount.Text = VSS.VssUtils.GetSnapshotLimit().ToString();
    }

    private void btnSystemProtection_Click(object sender, EventArgs e)
    {
      Process.Start("SystemPropertiesProtection.exe");
    }



    //
    // Misc

    private void FillGeneral(SnapshotRule rule)
    {
      rule.LifeTimeValue = (int)nbLifetime.Value;
      rule.LifeTimeUnit = (Timespan)cbLifetime.SelectedValue;
      rule.Volumes = new List<string>(cblDriveLetters.CheckedItems.Select(v => ((Volume)v).DeviceID));
    }



    //
    // Validation

    public void ValidateGeneral()
    {
      Valid = ValidateGeneric(() => cblDriveLetters.CheckedIndices.Count > 0, lblDriveLetters) && Valid;
    }
  }
}
