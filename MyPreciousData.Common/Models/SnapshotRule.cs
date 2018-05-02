using System;
using System.Collections.Generic;

namespace MyPreciousData.Models
{
  public partial class SnapshotRule
  {
    public long Id { get; set; }
    public string Name { get; set; }
    public bool Enabled { get; set; }
    public bool PendingDelete { get; set; }


    //
    // Overrides

    public override bool Equals(object obj)
    {
      if (obj == null || !(obj is SnapshotRule))
        return false;

      return Name.Equals(((SnapshotRule)obj).Name);
    }

    public override int GetHashCode()
    {
      return Name.GetHashCode();
    }

    public override string ToString()
    {
      return Name;
    }
  }
}
