using DotNet.Globbing;
using MyPreciousData.Models;
using System;
using System.Text.RegularExpressions;

namespace MyPreciousData.Filters
{
  public static class PathFilterEx
  {
    public static Glob GetSafeGlob(this PathFilter pathFilter)
    {
      return pathFilter.Glob ?? (pathFilter.Glob = Glob.Parse(pathFilter.Pattern));
    }
    public static Regex GetSafeRegexp(this PathFilter pathFilter)
    {
      return pathFilter.Regex ?? (pathFilter.Regex = new Regex(pathFilter.Pattern));
    }

    public static bool Apply(this PathFilter pathFilter, string path)
    {
      switch (pathFilter.FilterPatternType)
      {
        case FilterPatternType.Glob:
          return pathFilter.GetSafeGlob().IsMatch(path);

        case FilterPatternType.Regexp:
          return pathFilter.GetSafeRegexp().IsMatch(path);

        default:
          throw new ArgumentException(String.Format("FilterPatternType {0} not supported", (int)pathFilter.FilterPatternType), "pathFilter.FilterPatternType");
      }
    }
  }
}
