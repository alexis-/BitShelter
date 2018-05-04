using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BitShelter.Models
{
  // https://crypto.stackexchange.com/questions/34276/what-is-the-difference-between-pbe-and-symmetric-key-encryption
  // https://security.stackexchange.com/questions/37581/why-does-pgp-use-symmetric-encryption-and-rsa
  // https://security.stackexchange.com/questions/56167/why-is-gpg-file-encryption-so-much-slower-than-other-aes-implementations
  [DataContract]
  public enum EncryptionProtocol
  {
    [EnumMember]
    None,
    [EnumMember]
    AES,
    [EnumMember]
    PBE,
    [EnumMember]
    PGP,
  }


  // https://stackoverflow.com/questions/1220751/how-to-choose-an-aes-encryption-mode-cbc-ecb-ctr-ocb-cfb
  // https://stackoverflow.com/questions/37645113/openpgp-encryption-using-bouncycastle-lightweight-api
  // algorithms[] @ https://github.com/bcgit/bc-csharp/blob/b19e68a517e56ef08cd2e50df4dcb8a96ddbe507/crypto/src/security/PbeUtilities.cs
  // "private class PBEMethod" @ https://github.com/rackerlabs/atlas-lb/blob/master/common/ca/bouncycastle/src/main/java/org/bouncycastle/openpgp/PGPEncryptedDataGenerator.java
  [DataContract]
  public enum EncryptionAlgorithm
  {
    [EnumMember]
    None,
    [EnumMember]
    AES128_CBC,
    [EnumMember]
    AES256_CBC,
    [EnumMember]
    AES128_CFB,
    [EnumMember]
    AES256_CFB,
    [EnumMember]
    Blowfish_CFB,
    [EnumMember]
    Camellia128_CFB,
    [EnumMember]
    Camellia256_CFB,
    [EnumMember]
    Cast5_CFB,
    [EnumMember]
    TripleDes_CFB,
    [EnumMember]
    Twofish_CFB,
    [EnumMember]
    SHA1_Twofish_CBC,
    [EnumMember]
    SHA1_TripleDes_CBC,
    [EnumMember]
    SHA256_AES128_CBC,
    [EnumMember]
    SHA256_AES256_CBC,
    [EnumMember]
    Unknown,
  }
}
