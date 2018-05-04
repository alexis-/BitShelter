using Alphaleonis.Win32.Vss;
using BitShelter.Agent.Controls;
using BitShelter.Models;
using BitShelter.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.Agent.Forms
{
  partial class EditSnapshotRuleForm
  {
    public void InitBaseAdvanced()
    {
      cbSnapContext.FillWithEnum(VssSnapshotContextInternal.ClientAccessible);
      cbSnapType.FillWithEnum(VssBackupTypeInternal.Incremental);
      cbPruningStrategy.FillWithEnum(PruningStrategy.Global);

      cbSnapFailRestartVSS.Enabled = cbPruningStrategy.Enabled = false; // FIXME
    }

    public void InitEditAdvanced(SnapshotRule rule)
    {
      cbSnapContext.SelectedIndex = cbSnapContext.Items.IndexOf(rule.VssContext);
      cbSnapType.SelectedIndex = cbSnapType.Items.IndexOf(rule.VssBackupType);
      tbSnapInclWriters.Text = String.Join(",", rule.VssIncludeWriters);
      tbSnapExclWriters.Text = String.Join(",", rule.VssExcludeWriters);
      nbSnapFailRetryCount.Value = rule.MaxRetryCount;
      cbSnapFailRestartVSS.Checked = rule.RetryRestartVSSService;
      //cbPruningStrategy.SelectedIndex = cbPruningStrategy.Items.IndexOf(rule.PruningStrategy);
    }



    //
    // Misc

    private void FillAdvanced(SnapshotRule rule)
    {
      rule.VssContext = (VssSnapshotContextInternal)cbSnapContext.SelectedValue;
      rule.VssBackupType = (VssBackupTypeInternal)cbSnapType.SelectedValue;
      rule.VssIncludeWriters = new List<string>(tbSnapInclWriters.Text.Split(','));
      rule.VssExcludeWriters = new List<string>(tbSnapExclWriters.Text.Split(','));
      rule.MaxRetryCount = (int)nbSnapFailRetryCount.Value;
      rule.RetryRestartVSSService = cbSnapFailRestartVSS.Checked;
      //rule.PruningStrategy = (PruningStrategy)cbPruningStrategy.SelectedItem;
    }



    //
    // Validation

    public void ValidateAdvanced()
    {
      //Valid = ValidateGeneric(() => )
    }
  }
}
