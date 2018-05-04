using BitShelter.VSS;
using Syncfusion.Windows.Forms;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BitShelter.Agent.Forms
{
  public partial class SnapshotLimitForm : MetroForm
  {
    public SnapshotLimitForm()
    {
      InitializeComponent();

      lblMicrosoftRef.Links.Add(0, 0, "https://msdn.microsoft.com/en-us/library/bb891959.aspx?#maxshadowcopies");

      nbLimit.Value = VssUtils.GetSnapshotLimit();
    }

    private void lblMicrosoftRef_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(e.Link.LinkData as string);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      VssUtils.SetSnapshotLimit((int)nbLimit.Value);
      Close();
    }
  }
}
