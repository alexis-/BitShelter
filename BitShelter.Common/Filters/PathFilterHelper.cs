using BitShelter.Filters;
using BitShelter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.IO
{
  public static class PathFilterHelper
  {
    public delegate void traverseFSFileAdded(FileInfo path);

    public static Task<IEnumerable<FileInfo>> TraverseDirectoryWithFilterAsync(
      string rootDirPath,
      BackupRule backupRule,
      traverseFSFileAdded callback)
    {
      return TraverseDirectoryWithFilterAsync(
        rootDirPath,
        backupRule.FilterIncludes,
        backupRule.FilterExcludes,
        callback
      );
    }

    public static IEnumerable<FileInfo> TraverseDirectoryWithFilter(string rootDirPath, BackupRule backupRule)
    {
      return TraverseDirectoryWithFilter(
        rootDirPath,
        backupRule.FilterIncludes,
        backupRule.FilterExcludes
      );
    }

    public static async Task<IEnumerable<FileInfo>> TraverseDirectoryWithFilterAsync(
      string rootDirPath,
      HashSet<PathFilter> filterIncludes,
      HashSet<PathFilter> filterExcludes,
      traverseFSFileAdded callback)
    {
      return await Task.Run(
        () => TraverseDirectoryWithFilter(
          rootDirPath,
          filterIncludes,
          filterExcludes,
          callback)
      );
    }

    public static IEnumerable<FileInfo> TraverseDirectoryWithFilter(
      string rootDirPath,
      HashSet<PathFilter> filterIncludes,
      HashSet<PathFilter> filterExcludes,
      traverseFSFileAdded callback = null)
    {
      HashSet<FileInfo> files = new HashSet<FileInfo>();
      DirectoryInfo rootDir = new DirectoryInfo(rootDirPath);

      TraverseDirectoryWithFilter(rootDir, filterIncludes, filterExcludes, callback, files);

      return files;
    }

    private static void TraverseDirectoryWithFilter(
      DirectoryInfo rootDir,
      HashSet<PathFilter> filterIncludes,
      HashSet<PathFilter> filterExcludes,
      traverseFSFileAdded callback,
      HashSet<FileInfo> files)
    {
      foreach (FileInfo file in rootDir.EnumerateFiles()
        .Where(f => f.ShouldInclude(filterIncludes, filterExcludes)))
      {
        callback?.Invoke(file);
        files.Add(file);
      }

      foreach (DirectoryInfo childDir in rootDir.EnumerateDirectories()
        .Where(d => d.ShouldInclude(filterIncludes, filterExcludes)))
        TraverseDirectoryWithFilter(childDir, filterIncludes, filterExcludes, callback, files);
    }
  }
}
