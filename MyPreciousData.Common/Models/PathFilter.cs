using DotNet.Globbing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyPreciousData.Models
{
  public class PathFilter
  {
    public FilterPatternType FilterPatternType { get; set; }
    public string Pattern { get; set; }

    [JsonIgnore]
    public Glob Glob { get; set; }
    [JsonIgnore]
    public Regex Regex { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null || !(obj is PathFilter))
        return false;

      return Pattern.Equals(((PathFilter)obj).Pattern);
    }

    public override int GetHashCode()
    {
      return Pattern.GetHashCode();
    }
  }
}
