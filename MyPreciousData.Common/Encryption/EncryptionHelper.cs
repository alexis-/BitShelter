using MyPreciousData.Models;
using System;
using System.Collections.Generic;

namespace MyPreciousData.Encryption
{
  public static partial class EncryptionHelper
  {
    public static IEnumerable<EncryptionProtocol> AvailableProtocols =>
      new List<EncryptionProtocol>()
      {
        EncryptionProtocol.None,
        EncryptionProtocol.AES,
        EncryptionProtocol.PBE,
        EncryptionProtocol.PGP,
      };
  }
}
