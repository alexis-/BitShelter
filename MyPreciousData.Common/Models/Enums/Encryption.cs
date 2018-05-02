using System.Collections.Generic;

namespace MyPreciousData.Models
{
  // https://crypto.stackexchange.com/questions/34276/what-is-the-difference-between-pbe-and-symmetric-key-encryption
  // https://security.stackexchange.com/questions/37581/why-does-pgp-use-symmetric-encryption-and-rsa
  // https://security.stackexchange.com/questions/56167/why-is-gpg-file-encryption-so-much-slower-than-other-aes-implementations
  public enum EncryptionProtocol
  {
    None,
    AES,
    PBE,
    PGP,
  }


  // https://stackoverflow.com/questions/1220751/how-to-choose-an-aes-encryption-mode-cbc-ecb-ctr-ocb-cfb
  // https://stackoverflow.com/questions/37645113/openpgp-encryption-using-bouncycastle-lightweight-api
  // algorithms[] @ https://github.com/bcgit/bc-csharp/blob/b19e68a517e56ef08cd2e50df4dcb8a96ddbe507/crypto/src/security/PbeUtilities.cs
  // "private class PBEMethod" @ https://github.com/rackerlabs/atlas-lb/blob/master/common/ca/bouncycastle/src/main/java/org/bouncycastle/openpgp/PGPEncryptedDataGenerator.java
  public enum EncryptionAlgorithm
  {
    None,
    AES128_CBC,
    AES256_CBC,
    AES128_CFB,
    AES256_CFB,
    Blowfish_CFB,
    Camellia128_CFB,
    Camellia256_CFB,
    Cast5_CFB,
    TripleDes_CFB,
    Twofish_CFB,
    SHA1_Twofish_CBC,
    SHA1_TripleDes_CBC,
    SHA256_AES128_CBC,
    SHA256_AES256_CBC,
    Unknown,
  }
}
