using MyPreciousData.Models;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace MyPreciousData.Encryption
{
  public static partial class EncryptionHelper
  {
    private static int GetAESKeySize(EncryptionAlgorithm encryptionType)
    {
      switch (encryptionType)
      {
        case EncryptionAlgorithm.AES128_CBC:
          return 128;

        case EncryptionAlgorithm.AES256_CBC:
          return 256;

        default:
          throw new ArgumentException(String.Format("No key size for EncryptionAlgorithm {0}", encryptionType), "encryptionType");
      }
    }

    private static CipherMode GetAESCipher(EncryptionAlgorithm encryptionType)
    {
      switch (encryptionType)
      {
        case EncryptionAlgorithm.AES128_CBC:
        case EncryptionAlgorithm.AES256_CBC:
          return CipherMode.CBC;

        default:
          throw new ArgumentException(String.Format("No CipherMode for EncryptionAlgorithm {0}", encryptionType), "encryptionType");
      }
    }

    // https://msdn.microsoft.com/en-us/library/system.security.cryptography.aes(v=vs.110).aspx
    // https://stackoverflow.com/questions/29701401/encrypt-string-with-bouncy-castle-aes-cbc-pkcs7?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa
    // https://www.codeproject.com/Questions/994035/AES-Only-accepting-bit-key-when-key-size-is-set-to
    // https://crypto.stackexchange.com/questions/31632/what-is-the-difference-between-key-size-and-block-size-for-aes
    public static void EncryptStreamAES(Action<Stream> streamWriter, Stream outStream, EncryptionAlgorithm algorithm, string key)
    {
      using (AesManaged aes = new AesManaged())
      {
        aes.Mode = GetAESCipher(algorithm);
        aes.Padding = PaddingMode.PKCS7;
        aes.KeySize = GetAESKeySize(algorithm);
        aes.BlockSize = 128;

        // We use the random generated iv created by AesManaged
        byte[] iv = aes.IV;

        // Correct key length if necessary
        int keySizeBytes = aes.KeySize / 8;
        byte[] keyBytes = Encoding.ASCII.GetBytes(key.Substring(0, keySizeBytes).PadLeft(keySizeBytes));

        outStream.Write(iv, 0, iv.Length);

        using (CryptoStream cs = new CryptoStream(outStream, aes.CreateEncryptor(keyBytes, iv), CryptoStreamMode.Write))
        {
          streamWriter(cs);
        }
      }
    }
  }
}
