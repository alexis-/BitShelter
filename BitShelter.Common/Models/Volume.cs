using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.Models
{
  public class Volume
  {
    public string Name { get; set; }
    public string Label { get; set; }
    public string DeviceID { get; set; }
    public string MountLetter { get; set; }

    public override string ToString()
    {
      string label = Label == null
        ? "Unnamed"
        : Label;
      string mountLetter = MountLetter == null
        ? "()"
        : String.Format("({0})", MountLetter);

      return String.Format("{0} {1} -- {2}", label, mountLetter, DeviceID);
    }

    public string ToShortString()
    {
      string label = Label == null
        ? "Unnamed"
        : Label;
      string mountLetter = MountLetter == null
        ? "()"
        : String.Format("({0})", MountLetter);

      return String.Format("{0} {1}", label, mountLetter);
    }
  }
}
