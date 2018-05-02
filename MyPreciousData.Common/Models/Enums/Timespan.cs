using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData.Models.Enums
{
  public enum Timespan
  {
    Minute = 60,
    Hour = 3600,
    Day = 86400,
    Week = 604800,
    Month = 2628000, // Averaged at (Year / 12)
    Year = 31536000 // Day * 365
  }
}
