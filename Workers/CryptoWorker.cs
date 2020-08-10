using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace VaporStoreClubNamespace
{
    public class CryptoWorker
    {
        private RSAParameters privateKey;
        private RSAParameters publicKey;

        
        //Пункт 2
        public CryptoWorker(string toEncrypt)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            privateKey = RSA.ExportParameters(true);
            publicKey = RSA.ExportParameters(false);
            privateKey.ToString();

            UnicodeEncoding byteConverter = new UnicodeEncoding();

            byte[] encBytes = RSAEncrypt(byteConverter.GetBytes(toEncrypt), publicKey, false);

            string encrypt = byteConverter.GetString(encBytes);
            Debug.WriteLine("Encrypt str: " + encrypt);
            Debug.WriteLine("Encrypt bytes: " + string.Join(", ", encBytes));

            byte[] decBytes = RSADecrypt(encBytes, privateKey, false);

            Debug.WriteLine("Decrypt str: " + byteConverter.GetString(decBytes));
            Debug.WriteLine("Decrypt bytes: " + string.Join(", ", byteConverter.GetBytes(encrypt)));
            var s = RSA.ToXmlString(true);
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string> ("key",s)
            };

            //ServerWorker.PostRequest(new UriBuilder("http://34.69.5.208/get_run_mi_key/root?code_word=key").Uri, queries);
            ServerWorker.DataBaseWriting(s);
            RSA = new RSACryptoServiceProvider();
            RSA.FromXmlString(s);
        }

        static public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(RSAKeyInfo);
            return RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
        }

        static public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(RSAKeyInfo);
            return RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
        }

    }
}
