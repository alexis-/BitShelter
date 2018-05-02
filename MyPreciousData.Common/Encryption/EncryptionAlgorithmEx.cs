using MyPreciousData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData.Encryption
{
  public static class EncryptionAlgorithmEx
  {
    public static string GetDisplayName(this EncryptionAlgorithm algorithm)
    {
      switch (algorithm)
      {
        case EncryptionAlgorithm.None:
          return "None";

        case EncryptionAlgorithm.AES128_CBC:
          return "AES128-CBC";

        case EncryptionAlgorithm.AES256_CBC:
          return "AES256-CBC";

        case EncryptionAlgorithm.AES128_CFB:
          return "AES128-CFB";

        case EncryptionAlgorithm.AES256_CFB:
          return "AES256-CFB";

        case EncryptionAlgorithm.Blowfish_CFB:
          return "Blowfish-CFB";

        case EncryptionAlgorithm.Camellia128_CFB:
          return "Camellia128-CFB";

        case EncryptionAlgorithm.Camellia256_CFB:
          return "Camellia256-CFB";

        case EncryptionAlgorithm.Cast5_CFB:
          return "Cast5-CFB";

        case EncryptionAlgorithm.TripleDes_CFB:
          return "3DES-CFB";

        case EncryptionAlgorithm.Twofish_CFB:
          return "Twofish-CFB";

        case EncryptionAlgorithm.SHA1_Twofish_CBC:
          return "SHA1 + Twofish-CBC";

        case EncryptionAlgorithm.SHA1_TripleDes_CBC:
          return "SHA1 + 3DES-CBC";

        case EncryptionAlgorithm.SHA256_AES128_CBC:
          return "SHA256 + AES128-CBC";

        case EncryptionAlgorithm.SHA256_AES256_CBC:
          return "SHA256 + AES256-CBC";

        default:
          throw new ArgumentException(String.Format("Unsupported EncryptionAlgorithm {0}", algorithm), "algorithm");
      }
    }
  }
}
