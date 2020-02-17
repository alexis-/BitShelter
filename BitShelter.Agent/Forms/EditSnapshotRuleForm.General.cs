#region License & Metadata

// The MIT License (MIT)
// 
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the 
// Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// 
// 
// Created On:   2018/04/13 19:45
// Modified On:  2018/05/28 16:00
// Modified By:  Alexis

#endregion




using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Alphaleonis.Win32.Vss;
using BitShelter.Models;
using BitShelter.Models.Enums;
using BitShelter.Utils;
using BitShelter.VSS;

namespace BitShelter.Agent.Forms
{
  partial class EditSnapshotRuleForm
  {
    #region Methods

    public void InitBaseGeneral()
    {
      lblSnapLimitCount.Text = VSS.VssUtils.GetSnapshotLimit().ToString();

      cbLifetime.DataSource    = Enum.GetValues(typeof(Timespan));
      cbLifetime.SelectedIndex = cbLifetime.Items.IndexOf(Timespan.Week);

      ListVSSVolumes();
    }

    public void InitEditGeneral(SnapshotRule rule)
    {
      nbLifetime.Value         = rule.LifeTimeValue;
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
      Task.Run(() =>
      {
        var p = Process.Start("SystemPropertiesProtection.exe");

        p.WaitForExit();

        SendOrPostCallback callback = new SendOrPostCallback(args => { ListVSSVolumes(); });

        SyncContext.Send(callback, null);
      });
    }


    //
    // Misc

    private void ListVSSVolumes()
    {
      using (VssClient vss = new VssClient(new VssHost()))
      {
        vss.Initialize(VssSnapshotContext.ClientAccessible, VssBackupType.Incremental);

        cblDriveLetters.Items.AddRange(
          Volumes.ListVolumes()
                 .Where(v => IsVolumeSupported(vss, v.DeviceID))
                 .ToArray()
        );
      }
    }

    private bool IsVolumeSupported(VssClient vss, string volumeName)
    {
      try
      {
        return vss.IsVolumeSupported(volumeName);
      }
      catch (Exception)
      {
        return false;
      }
    }

    private void FillGeneral(SnapshotRule rule)
    {
      rule.LifeTimeValue = (int)nbLifetime.Value;
      rule.LifeTimeUnit  = (Timespan)cbLifetime.SelectedValue;
      rule.Volumes       = new List<string>(cblDriveLetters.CheckedItems.Select(v => ((Volume)v).DeviceID));
    }


    //
    // Validation

    public void ValidateGeneral()
    {
      Valid = ValidateGeneric(() => cblDriveLetters.CheckedIndices.Count > 0, lblDriveLetters) && Valid;
    }

    #endregion
  }
}
