using BitShelter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.Encryption
{
  public static class EncryptionProtocolEx
  {
    public static IEnumerable<EncryptionAlgorithm> GetAvailableAlgorithms(this EncryptionProtocol proto)
    {
      switch (proto)
      {
        case EncryptionProtocol.None:
          return new List<EncryptionAlgorithm>()
          {
            EncryptionAlgorithm.None
          };

        case EncryptionProtocol.AES:
          return new List<EncryptionAlgorithm>()
          {
            EncryptionAlgorithm.AES128_CBC,
            //EncryptionAlgorithm.AES128_CFB,
            EncryptionAlgorithm.AES256_CBC,
            //EncryptionAlgorithm.AES256_CFB,
          };

        case EncryptionProtocol.PBE:
          return new List<EncryptionAlgorithm>()
          {
            EncryptionAlgorithm.SHA1_TripleDes_CBC,
            EncryptionAlgorithm.SHA1_Twofish_CBC,
            EncryptionAlgorithm.SHA256_AES128_CBC,
            EncryptionAlgorithm.SHA256_AES256_CBC,
          };

        case EncryptionProtocol.PGP:
          return new List<EncryptionAlgorithm>()
          {
            EncryptionAlgorithm.AES128_CFB,
            EncryptionAlgorithm.AES256_CFB,
            EncryptionAlgorithm.Blowfish_CFB,
            EncryptionAlgorithm.Camellia128_CFB,
            EncryptionAlgorithm.Camellia256_CFB,
            EncryptionAlgorithm.Cast5_CFB,
            EncryptionAlgorithm.TripleDes_CFB,
            EncryptionAlgorithm.Twofish_CFB,
          };

        default:
          throw new ArgumentException(String.Format("Unsupported EncryptionAlgorithm {0}", proto), "proto");
      }
    }
  }
}
