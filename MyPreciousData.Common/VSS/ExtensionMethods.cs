﻿using Alphaleonis.Win32.Vss;
using MyPreciousData.Utils;
using System;

namespace MyPreciousData.VSS
{
  // https://github.com/alphaleonis/AlphaVSS
  internal static class ExtensionMethods
  {
    public static string GetExpandedPath(this VssWMFileDescriptor fileDesc)
    {
      return AppendBackslash(Environment.ExpandEnvironmentVariables(fileDesc.Path));
    }

    public static string GetAffectedVolume(this VssWMFileDescriptor fileDesc, IUIHost host)
    {
      string expandedPath = AppendBackslash(Environment.ExpandEnvironmentVariables(fileDesc.Path));

      try
      {
        return Volumes.GetUniqueVolumeNameForPath(host, expandedPath, true);
      }
      catch
      {
        return expandedPath;
      }
    }

    public static string GetFullPath(this IVssWMComponent component, IUIHost host)
    {
      string fullPath = AppendBackslash(component.LogicalPath) + component.ComponentName;
      if (!fullPath.StartsWith("\\"))
        fullPath = "\\" + fullPath;
      return fullPath;
    }

    public static string AppendBackslash(this string str)
    {
      if (str == null)
        return "\\";
      else if (str.EndsWith("\\"))
        return str;
      else
        return str + "\\";
    }
  }
}
