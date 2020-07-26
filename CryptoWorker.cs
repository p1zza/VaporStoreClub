using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VaporStoreClubNamespace
{
    public class CryptoWorker
    {
        private RijndaelManaged myRijndael = new RijndaelManaged();
        private int iterations;
        private byte[] salt;

        public CryptoWorker(string strPassword, string specString, string saltString)
        {
            myRijndael.BlockSize = 128;
            myRijndael.KeySize = 128;
            myRijndael.IV = HexStringToByteArray(specString);
            myRijndael.Padding = PaddingMode.PKCS7;
            myRijndael.Mode = CipherMode.CBC;
            iterations = 1000;
            salt = Encoding.UTF8.GetBytes(saltString);
            myRijndael.Key = GenerateKey(strPassword);
        }

        public string Encrypt(string strPlainText)
        {
            byte[] strText = new UTF8Encoding().GetBytes(strPlainText);
            ICryptoTransform transform = myRijndael.CreateEncryptor();
            byte[] cipherText = transform.TransformFinalBlock(strText, 0, strText.Length);
            return Convert.ToBase64String(cipherText);
        }

        public string Decrypt(string encryptedText)
        {
            dynamic encryptedBytes = Convert.FromBase64String(encryptedText);
            ICryptoTransform transform = myRijndael.CreateDecryptor();
            byte[] cipherText = transform.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
            return Encoding.UTF8.GetString(cipherText);
        }

        public static byte[] HexStringToByteArray(string strHex)
        {
            byte[] r = new byte[strHex.Length / 2];
            for (int i = 0; i <= strHex.Length - 1; i += 2)
                r[i / 2] = Convert.ToByte(Convert.ToInt32(strHex.Substring(i, 2), 16));
            return r;
        }

        private byte[] GenerateKey(string strPassword)
        {
            using (Rfc2898DeriveBytes rfc2898 = new Rfc2898DeriveBytes(Encoding.UTF8.GetBytes(strPassword), salt, iterations))
            {
                return rfc2898.GetBytes(128 / 8);
            }
        }

        private static string RandomString(int length)
        {
            const string chars = "abcdef0123456789";
            Random random = new Random();
            string result = string.Empty;

            while (result.Length < length)
                result += chars[random.Next(chars.Length)];

            return result;
        }
    }
}
