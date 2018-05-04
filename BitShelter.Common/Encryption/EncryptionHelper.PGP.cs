using BitShelter.Models;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Security;
using System;
using System.IO;

namespace BitShelter.Encryption
{
  public static partial class EncryptionHelper
  {
    private static SymmetricKeyAlgorithmTag GetPGPCipher(EncryptionAlgorithm algorithm)
    {
      switch (algorithm)
      {
        case EncryptionAlgorithm.AES128_CFB:
          return SymmetricKeyAlgorithmTag.Aes128;

        case EncryptionAlgorithm.AES256_CFB:
          return SymmetricKeyAlgorithmTag.Aes256;

        case EncryptionAlgorithm.Blowfish_CFB:
          return SymmetricKeyAlgorithmTag.Blowfish;

        case EncryptionAlgorithm.Camellia128_CFB:
          return SymmetricKeyAlgorithmTag.Camellia128;

        case EncryptionAlgorithm.Camellia256_CFB:
          return SymmetricKeyAlgorithmTag.Camellia256;

        case EncryptionAlgorithm.Cast5_CFB:
          return SymmetricKeyAlgorithmTag.Cast5;

        case EncryptionAlgorithm.TripleDes_CFB:
          return SymmetricKeyAlgorithmTag.TripleDes;

        case EncryptionAlgorithm.Twofish_CFB:
          return SymmetricKeyAlgorithmTag.Twofish;

        default:
          throw new ArgumentException(String.Format("Unsupported EncryptionAlgorithm {0}", algorithm), "algorithm");
      }
    }

    /// <summary>
    /// Return the public encryption key with ID "keyId".
    /// </summary>
    /// <param name="publicKeyRingStream">The key ring, in bytes</param>
    /// <param name="keyId">Sought key's ID</param>
    /// <param name="throwException">Whether to throw an exception if key does not exist, or is not an encryption key</param>
    /// <returns>Key, or null if exception throwing is disabled and key either can't be found, or can't encrypt.</returns>
    private static PgpPublicKey GetPublicEncryptionKey(Stream publicKeyRingStream, long keyId, bool throwException = true)
    {

      var keyRing = new PgpPublicKeyRingBundle(PgpUtilities.GetDecoderStream(publicKeyRingStream));
      var key = keyRing.GetPublicKey(keyId);

      if (key == null)
      {
        if (throwException)
          throw new ArgumentException(String.Format("Key {0:X} does not exist in key ring", keyId), "keyId");

        return null;
      }

      if (key.IsEncryptionKey == false)
      {
        if (throwException)
          throw new ArgumentException(String.Format("Key {0:X} is not an Encryption Key", keyId), "keyId");

        return null;
      }

      return key;
    }

    // https://github.com/bcgit/bc-csharp/blob/master/crypto/test/src/openpgp/examples/KeyBasedFileProcessor.cs
    // https://github.com/bcgit/bc-java/blob/master/pg/src/main/java/org/bouncycastle/openpgp/PGPEncryptedDataGenerator.java
    public static void EncryptStreamPGP(
      Action<Stream> streamWriter,
      Stream outStream,
      EncryptionAlgorithm algorithm,
      Stream publicKeyRing,
      long keyId)
    {
      PgpPublicKey pubEncKey = GetPublicEncryptionKey(publicKeyRing, keyId);
      PgpEncryptedDataGenerator encGenerator = new PgpEncryptedDataGenerator(GetPGPCipher(algorithm), true, new SecureRandom());

      encGenerator.AddMethod(pubEncKey);

      // Buffer size is automatically computed -- Is that optimal ?
      using (Stream encStream = encGenerator.Open(outStream, null))
      {
        streamWriter(encStream);
      }
    }
  }
}
