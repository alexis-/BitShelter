using MyPreciousData.Agent.Controls;
using MyPreciousData.Models;
using MyPreciousData.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData.Agent.Forms
{
  partial class EditSnapshotRuleForm
  {
    private void InitBaseBackup()
    {
      cbBackupEnable.Checked = false;

      glBackup.DataSource = new List<BackupRule>();

      cbBackupTotalMaxSizeUnit.FillWithEnum(MediumStorageUnit.GB);
    }

    private void InitEditBackup(SnapshotRule sched)
    {
      cbBackupEnable.Checked = sched.BackupEnabled;

      glBackup.DataSource = sched.BackupRules.ToArray();

      nbBackupTotalMaxSize.Value = sched.BackupTotalMaxSize;
      cbBackupTotalMaxSizeUnit.SelectedIndex = cbBackupTotalMaxSizeUnit.Items.IndexOf(sched.BackupTotalMaxSizeUnit);

      cbBackupNotificationsEnabled.Checked = sched.BackupNotify;
    }

    private void cbBackupEnable_CheckedChanged(object sender, EventArgs e)
    {
      ChangeBackupEnabled(cbBackupEnable.Checked);
    }

    private void ChangeBackupEnabled(bool enabled)
    {
      glBackup.Enabled = enabled;
      cbBackupTotalMaxSizeUnit.Enabled = enabled;
      nbBackupTotalMaxSize.Enabled = enabled;
      cbBackupNotificationsEnabled.Enabled = enabled;
      btnBackupAdd.Enabled = enabled;
      btnBackupDelete.Enabled = enabled;
    }



    //
    // Misc

    private void FillBackup(SnapshotRule rule)
    {
      rule.BackupEnabled = cbBackupEnable.Checked;
      rule.BackupTotalMaxSize = (int)nbBackupTotalMaxSize.Value;
      rule.BackupTotalMaxSizeUnit = (MediumStorageUnit)cbBackupTotalMaxSizeUnit.SelectedValue;
      rule.BackupNotify = cbBackupNotificationsEnabled.Checked;
    }
  }
}
