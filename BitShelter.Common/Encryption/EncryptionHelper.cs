using BitShelter.Models;
using System;
using System.Collections.Generic;

namespace BitShelter.Encryption
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
