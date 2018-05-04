using BitShelter.Agent.Forms;
using BitShelter.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitShelter.Agent
{
  /// <summary>
  /// Framework for running application as a tray app.
  /// </summary>
  /// <remarks>
  /// Tray app code adapted from "Creating Applications with NotifyIcon in Windows Forms", Jessica Fosler,
  /// http://windowsclient.net/articles/notifyiconapplications.aspx
  /// </remarks>
  public class CustomApplicationContext : ApplicationContext
  {
    // Icon generously provided by flaticon https://www.flaticon.com/free-icon/google-drive-logo_60958
    private const string IconFileName = "BitShelter.ico";
    private const string ExitConfirmMessage = "Exiting the agent won't stop the service. Use the Windows Service manager to stop BitShelter.";
    private const string ExitConfirmTitle = "Confirm";


    private IContainer components;
    private NotifyIcon trayIcon;
    private ContextMenuStrip trayContextMenuStrip;

    public ToolStripMenuItem RunAtStartupMenuItem { get; private set; }

    /// <summary>
    /// This class should be created and passed into Application.Run( ... )
    /// </summary>
    public CustomApplicationContext()
    {
      InitializeComponent();
    }

    private void InitializeComponent()
    {
      components = new Container();

      trayIcon = new NotifyIcon(components);
      trayContextMenuStrip = new ContextMenuStrip(components);
      trayContextMenuStrip.SuspendLayout();

      // 
      // trayIcon
      trayIcon.BalloonTipText = "Double click to access settings.";
      trayIcon.BalloonTipTitle = BitShelter.Const.AppName;
      trayIcon.ContextMenuStrip = trayContextMenuStrip;
      trayIcon.Icon = new Icon(Path.Combine(Application.StartupPath, IconFileName));
      trayIcon.Text = BitShelter.Const.AppName;
      trayIcon.Visible = true;

      trayIcon.DoubleClick += settingsItem_Click;
      trayIcon.MouseUp += trayIcon_MouseUp;

      RunAtStartupMenuItem = new ToolStripMenuItem("Run at startup", null, runAtStartupItem_Click);

      // 
      // trayContextMenuStrip
      trayContextMenuStrip.Items.Add(new ToolStripMenuItem("Settings", null, settingsItem_Click));
      trayContextMenuStrip.Items.Add(RunAtStartupMenuItem);
      trayContextMenuStrip.Items.Add(new ToolStripSeparator());
      trayContextMenuStrip.Items.Add(new ToolStripMenuItem("Exit", null, exitItem_Click));
      trayContextMenuStrip.Name = "trayContextMenuStrip";

      RunAtStartupMenuItem.Checked = InstallUtils.TaskExists(Const.AppName);

      // 
      // CAC
      trayContextMenuStrip.ResumeLayout(false);
    }

    /// <summary>
    /// When the application context is disposed, dispose things like the notify icon.
    /// </summary>
    /// <param name="disposing"></param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null) { components.Dispose(); }
    }

    private void settingsItem_Click(object sender, EventArgs e)
    {
      SettingsForm.DisplayInstance();
    }

    private void runAtStartupItem_Click(object sender, EventArgs e)
    {
      bool autoRun = InstallUtils.TaskExists(Const.AppName);

      if (autoRun == false)
        InstallUtils.CreateStartupTask(Const.AppName, Application.ExecutablePath);

      else
        InstallUtils.DeleteStartupTask(Const.AppName);

      RunAtStartupMenuItem.Checked = !autoRun;
    }

    private void exitItem_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show(ExitConfirmMessage, ExitConfirmTitle, MessageBoxButtons.OKCancel) == DialogResult.OK)
        ExitThread();
    }

    private void trayIcon_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
        mi.Invoke(trayIcon, null);
      }
    }

    /// <summary>
    /// If we are presently showing a form, clean it up.
    /// </summary>
    protected override void ExitThreadCore()
    {
      // before we exit, let forms clean themselves up.
      EditSnapshotRuleForm.CloseInstance();
      SettingsForm.CloseInstance();

      // should remove lingering tray icon
      trayIcon.Visible = false;

      base.ExitThreadCore();
    }
  }
}
