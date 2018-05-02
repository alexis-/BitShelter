using Alphaleonis.Win32.Vss;
using MyPreciousData.Models;
using MyPreciousData.Models.Enums;
using MyPreciousData.Utils;
using MyPreciousData.VSS;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPreciousData.Agent.Forms
{
  partial class EditSnapshotRuleForm
  {
    public void InitBaseGeneral()
    {
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



    //
    // Misc

    private void FillGeneral(SnapshotRule rule)
    {
      rule.LifeTimeValue = (int)nbLifetime.Value;
      rule.LifeTimeUnit = (Timespan)cbLifetime.SelectedValue;
      rule.Volumes = new DriveList(cblDriveLetters.CheckedItems.Select(v => ((Volume)v).DeviceID));
    }



    //
    // Validation

    public void ValidateGeneral()
    {
      Valid = ValidateGeneric(() => cblDriveLetters.CheckedIndices.Count > 0, lblDriveLetters) && Valid;
    }
  }
}
