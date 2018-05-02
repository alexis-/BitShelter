using MyPreciousData.Models;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyPreciousData.Encryption
{
  public static partial class EncryptionHelper
  {
    // TODO: https://www.veracrypt.fr/en/Personal%20Iterations%20Multiplier%20%28PIM%29.html
    private const int IterationCount = 204800;

    // https://github.com/bcgit/bc-csharp/blob/b19e68a517e56ef08cd2e50df4dcb8a96ddbe507/crypto/src/security/PbeUtilities.cs
    // https://github.com/bcgit/bc-csharp/blob/b19e68a517e56ef08cd2e50df4dcb8a96ddbe507/crypto/src/crypto/engines/TwofishEngine.cs
    // "private Pkcs12Test[] pkcs12Tests" @ https://github.com/bcgit/bc-csharp/blob/b19e68a517e56ef08cd2e50df4dcb8a96ddbe507/crypto/test/src/test/PBETest.cs
    private static Dictionary<EncryptionAlgorithm, PBEAlgorithmDesc> PBEAlgorithmMap =
      new Dictionary<EncryptionAlgorithm, PBEAlgorithmDesc>()
      {
        {
          EncryptionAlgorithm.SHA1_TripleDes_CBC,
          new PBEAlgorithmDesc("PBEwithSHA-1and3-keyDESEDE-CBC", "DESede", () => new Sha1Digest(), 192, 64)
        },
        {
          EncryptionAlgorithm.SHA1_Twofish_CBC,
          new PBEAlgorithmDesc("PBEwithSHA-1andTWOFISH-CBC", "Twofish", () => new Sha1Digest(), 256, 128)
        },
        {
          EncryptionAlgorithm.SHA256_AES128_CBC,
          new PBEAlgorithmDesc("PBEwithSHA-256and128bitAES-CBC-BC", "Twofish", () => new Sha256Digest(), 256, 128)
        },
        {
          EncryptionAlgorithm.SHA256_AES256_CBC,
          new PBEAlgorithmDesc("PBEwithSHA-256and256bitAES-CBC-BC", "Twofish", () => new Sha256Digest(), 256, 128)
        },
      };

    // "private class Pkcs12Test" @ https://github.com/bcgit/bc-csharp/blob/b19e68a517e56ef08cd2e50df4dcb8a96ddbe507/crypto/test/src/test/PBETest.cs
    // https://github.com/bcgit/bc-csharp/blob/b19e68a517e56ef08cd2e50df4dcb8a96ddbe507/crypto/src/crypto/generators/Pkcs12ParametersGenerator.cs
    // https://github.com/bcgit/bc-csharp/blob/master/crypto/src/crypto/BufferedStreamCipher.cs
    // https://github.com/bcgit/bc-csharp/blob/master/crypto/src/crypto/io/CipherStream.cs
    // https://forum.facepunch.com/f/nerds/payx/How-can-I-encrypt-a-txt-file/1/#posticazt
    public static void EncryptStreamPBE(
      Action<Stream> streamWriter,
      Stream outStream,
      EncryptionAlgorithm algorithm,
      string key)
    {
      var pbeAlg = PBEAlgorithmMap[algorithm];
      var digest = pbeAlg.Digest;
      byte[] salt = DigestUtilities.DoFinal(digest);

      PbeParametersGenerator pGen = new Pkcs12ParametersGenerator(digest);

      pGen.Init(
          PbeParametersGenerator.Pkcs12PasswordToBytes(key.ToArray()),
          salt,
          IterationCount);

      ParametersWithIV parameters = (ParametersWithIV)
                    pGen.GenerateDerivedParameters(pbeAlg.BaseAlgorithm, pbeAlg.KeySize, pbeAlg.IVSize);
      KeyParameter encKey = (KeyParameter)parameters.Parameters;

      IBufferedCipher c = CipherUtilities.GetCipher(pbeAlg.BaseAlgorithm + "/CBC/PKCS7Padding");

      c.Init(true, parameters);

      using (CipherStream encStream = new CipherStream(outStream, null, c))
      {
        streamWriter(encStream);
      }
    }

    protected class PBEAlgorithmDesc
    {
      public PBEAlgorithmDesc(string alg, string baseAlg, Func<IDigest> digGen, int keySize, int ivSize)
      {
        Algorithm = alg;
        BaseAlgorithm = baseAlg;
        DigestGenerator = digGen;
        KeySize = keySize;
        IVSize = ivSize;
      }

      public string Algorithm { get; set; }
      public string BaseAlgorithm { get; set; }
      protected Func<IDigest> DigestGenerator { get; set; }
      public IDigest Digest => DigestGenerator();
      public int KeySize { get; set; }
      public int IVSize { get; set; }
    }
  }
}
