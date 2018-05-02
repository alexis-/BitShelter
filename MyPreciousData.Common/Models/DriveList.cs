using MyPreciousData.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData.Models
{
  public class DriveList : List<string>
  {
    public DriveList()
    {
    }

    public DriveList(int capacity) : base(capacity)
    {
    }

    public DriveList(IEnumerable<string> collection) : base(collection)
    {
    }

    public override string ToString()
    {
      return String.Join(",",
        Volumes.GetVolumesForDevicesID(this)
        .Select(v => v.ToShortString())
      );
    }
  }
}
