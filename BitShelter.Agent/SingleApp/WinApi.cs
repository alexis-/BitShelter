using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.Agent.SingleApp
{
  /// <summary>
  /// A wrapper for various WinAPI functions.
  /// </summary>
  /// <remarks>
  /// This class is just a wrapper for your various WinApi functions.
  /// In this sample only the bare essentials are included.
  /// In my own WinApi class, I have all the WinApi functions that any
  /// of my applications would ever need.
  /// 
  /// From http://www.codeproject.com/KB/cs/SingleInstanceAppMutex.aspx
  /// </remarks>
  static public class WinApi
  {
    [DllImport("user32")]
    public static extern int RegisterWindowMessage(string message);

    internal static int RegisterWindowMessage(string format, params object[] args)
    {
      string message = String.Format(format, args);
      return RegisterWindowMessage(message);
    }

    internal const int HWND_BROADCAST = 0xffff;
    internal const int SW_SHOWNORMAL = 1;

    [DllImport("user32")]
    public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);

    [DllImportAttribute("user32.dll")]
    public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    [DllImportAttribute("user32.dll")]
    public static extern bool SetForegroundWindow(IntPtr hWnd);

    internal static void ShowToFront(IntPtr window)
    {
      ShowWindow(window, SW_SHOWNORMAL);
      SetForegroundWindow(window);
    }
  }
}
