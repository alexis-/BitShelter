using BitShelter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.Filters
{
  public static class FileSystemInfoEx
  {
    public static bool ShouldInclude(
      this FileSystemInfo fsInfo,
      HashSet<PathFilter> filterIncludes,
      HashSet<PathFilter> filterExcludes)
    {
      string path = fsInfo.FullName;

      return filterIncludes.Any(f => f.Apply(path)) && !filterExcludes.Any(f => f.Apply(path));
    }
  }
}
