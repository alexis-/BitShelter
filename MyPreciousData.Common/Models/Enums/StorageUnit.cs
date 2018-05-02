using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData.Models.Enums
{
  public enum StorageUnit : long
  {
    B = 1,
    KB = 1024,
    MB = 1048576,
    GB = 1073741824,
    TB = 1099511627776
  }

  public enum SmallStorageUnit : long
  {
    KB = 1024,
    MB = 1048576,
    GB = 1073741824,
    TB = 1099511627776
  }

  public enum MediumStorageUnit : long
  {
    MB = 1048576,
    GB = 1073741824,
    TB = 1099511627776
  }

  public enum LargeStorageUnit : long
  {
    GB = 1073741824,
    TB = 1099511627776
  }
}
