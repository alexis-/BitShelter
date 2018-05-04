using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.VSS
{
  public static class VssUtils
  {
    public static string MaxShadowCountKeyPath = "System\\CurrentControlSet\\Services\\VSS\\Settings";
    public static string MaxShadowCountKeyName = "MaxShadowCopies";

    public static int GetSnapshotLimit()
    {
      using (RegistryKey reg = EnsureSubKeyExists(Registry.LocalMachine, MaxShadowCountKeyPath))
      {
        if (reg == null)
          return 64;

        return (int)reg.GetValue(MaxShadowCountKeyName, 64);
      }
    }

    public static bool SetSnapshotLimit(int count)
    {
      count = Math.Min(512, Math.Max(64, count));

      //
      //Create a value with the name MaxShadowCopies and type DWORD. The default data for this value is 64.The minimum is 1.The maximum is 512.

      using (RegistryKey reg = EnsureSubKeyExists(Registry.LocalMachine, MaxShadowCountKeyPath, true))
      {
        if (reg == null)
          return false;

        reg.SetValue(MaxShadowCountKeyName, count, RegistryValueKind.DWord);
      }

      return true;
    }

    private static RegistryKey EnsureSubKeyExists(RegistryKey reg, string path, bool forWrite = false)
    {
      RegistryKey subKey = reg.OpenSubKey(MaxShadowCountKeyPath, forWrite);

      if (subKey != null)
        return subKey;

      return reg.CreateSubKey(path, forWrite);
    }
  }
}
