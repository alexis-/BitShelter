using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BitShelter.Agent.SingleApp
{
  /// <summary>
  /// Enforces a single instance.
  /// </summary>
  /// <remarks>
  /// This is where the magic happens.
  /// Start() tries to create a mutex.
  /// If it detects that another instance is already using the mutex, then it returns FALSE.
  /// Otherwise it returns TRUE.
  /// (Notice that a GUID is used for the mutex name, which is a little better than using the application name.)
  /// If another instance is detected, then you can use ShowFirstInstance() to show it
  /// (which will work as long as you override WndProc as shown above).
  /// ShowFirstInstance() broadcasts a message to all windows.
  /// The message is WM_SHOWFIRSTINSTANCE.
  /// (Notice that a GUID is used for WM_SHOWFIRSTINSTANCE.
  /// That allows you to reuse this code in multiple applications without getting
  /// strange results when you run them all at the same time.)
  /// 
  /// From http://www.codeproject.com/KB/cs/SingleInstanceAppMutex.aspx
  /// </remarks>
  static public class SingleInstance
  {
    public static readonly int WM_SHOWFIRSTINSTANCE =
        WinApi.RegisterWindowMessage("WM_SHOWFIRSTINSTANCE|{0}", ProgramInfo.AssemblyGuid);
    private static Mutex mutex;

    static public bool Start()
    {
      bool onlyInstance = false;
      string mutexName = String.Format("Local\\{0}", ProgramInfo.AssemblyGuid);

      // if you want your app to be limited to a single instance
      // across ALL SESSIONS (multiple users & terminal services), then use the following line instead:
      // string mutexName = String.Format("Global\\{0}", ProgramInfo.AssemblyGuid);

      mutex = new Mutex(true, mutexName, out onlyInstance);
      return onlyInstance;
    }

    static public void ShowFirstInstance()
    {
      WinApi.PostMessage(
          (IntPtr)WinApi.HWND_BROADCAST,
          WM_SHOWFIRSTINSTANCE,
          IntPtr.Zero,
          IntPtr.Zero);
    }

    static public void Stop()
    {
      mutex.ReleaseMutex();
    }
  }
}
