using DescribeTranspiler.CLI;
using System.Security.Cryptography;
using System.Text;

namespace DescribeTranspiler.Cli
{
    //https://stackoverflow.com/questions/12804231/c-sharp-equivalent-to-hash-hmac-in-php
    //https://puvox.software/blog/two-way-encryption-decryption-between-php-and-c-sharp/
    //https://stackoverflow.com/questions/45567962/convert-encrypt-and-decrypt-c-sharp-function-to-php-function

    internal class CryptoUtil_Implementation1 : CryptoUtil
    {
        public override byte[] defaultIV
        {
            get
            {
                return new byte[16] {
                0x88, 0x91, 0x21, 0x25, 0xe9, 0x02, 0x6b, 0xfe,
                0x6c, 0x34, 0xa9, 0xd3, 0xfb, 0x8f, 0xab, 0x99 };
            }
        }



        public override string HashHMAC(string key, string message)
        {
            var hash = new HMACSHA256(StringEncode(key));
            var hmac = hash.ComputeHash(StringEncode(message));
            return HashEncode(hmac);
        }
        private byte[] HashHMAC(byte[] key, byte[] message)
        {
            var hash = new HMACSHA256(key);
            return hash.ComputeHash(message);
        }
        private byte[] StringEncode(string text)
        {
            var encoding = new System.Text.ASCIIEncoding();
            return encoding.GetBytes(text);
        }
        private string HashEncode(byte[] hash)
        {
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }
        string GetHashSha256(string input)
        {
            //https://stackoverflow.com/questions/12416249/hashing-a-string-with-sha256
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(input));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        public override string EncryptString(string plaintext, byte[] key, byte[] iv)
        {
            //Instantiate a new Aes object to perform string symmetric encryption
            Aes encryptor = Aes.Create();
            encryptor.Mode = CipherMode.CBC;

            // Set key and IV
            byte[] aesKey = new byte[32];
            Array.Copy(key, 0, aesKey, 0, 32);
            encryptor.Key = aesKey;
            encryptor.IV = iv;

            // Instantiate a new MemoryStream object to contain the encrypted bytes
            MemoryStream memoryStream = new MemoryStream();

            // Instantiate a new encryptor from our Aes object
            ICryptoTransform aesEncryptor = encryptor.CreateEncryptor();

            // Instantiate a new CryptoStream object to process the data and write it to the 
            // memory stream
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);

            // Convert the plainText string into a byte array
            byte[] plainBytes = Encoding.ASCII.GetBytes(plaintext);

            // Encrypt the input plaintext string
            cryptoStream.Write(plainBytes, 0, plainBytes.Length);

            // Complete the encryption process
            cryptoStream.FlushFinalBlock();

            // Convert the encrypted data from a MemoryStream to a byte array
            byte[] cipherBytes = memoryStream.ToArray();

            // Close both the MemoryStream and the CryptoStream
            memoryStream.Close();
            cryptoStream.Close();

            // Convert the encrypted byte array to a base64 encoded string
            string cipherText = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length);

            // Return the encrypted data as a string
            return cipherText;
        }
        public override string EncryptString(string plaintext, string password)
        {
            byte[] plainText = Encoding.Unicode.GetBytes(plaintext); // this is UTF-16 LE
            string cipherText;
            using (Aes encryptor = Aes.Create())
            {
                var pdb = new Rfc2898DeriveBytes(password, Encoding.ASCII.GetBytes("worldinlists"));
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(plainText, 0, plainText.Length);
                        cs.Close();
                    }
                    var cryptoArray = ms.ToArray();
                    cipherText = Convert.ToBase64String(cryptoArray);
                }
            }

            return cipherText;
            //byte[] plainTextBytes = Encoding.Unicode.GetBytes(plainText); // this is UTF-16 LE
            //string cipherText;
            //using (Aes encryptor = Aes.Create())
            //{
            //    var pdb = new Rfc2898DeriveBytes(password, Encoding.ASCII.GetBytes("worldinlists"));
            //    encryptor.Key = pdb.GetBytes(32);
            //    encryptor.IV = defaultIV;
            //    using (MemoryStream ms = new MemoryStream())
            //    {
            //        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
            //        {
            //            cs.Write(plainTextBytes, 0, plainTextBytes.Length);
            //            cs.Close();
            //        }
            //        cipherText = Convert.ToBase64String(ms.ToArray());
            //    }
            //}
            //return cipherText;

            //byte[] key = StringToByteArrayFastest(password);
            //return EncryptString(plainText, key, defaultIV);
        }

        public override string DecryptString(string cipherText, byte[] key, byte[] iv)
        {
            // Instantiate a new Aes object to perform string symmetric encryption
            Aes encryptor = Aes.Create();
            encryptor.Mode = CipherMode.CBC;

            // Set key and IV
            byte[] aesKey = new byte[32];
            Array.Copy(key, 0, aesKey, 0, 32);
            encryptor.Key = aesKey;
            encryptor.IV = iv;

            // Instantiate a new MemoryStream object to contain the encrypted bytes
            MemoryStream memoryStream = new MemoryStream();

            // Instantiate a new encryptor from our Aes object
            ICryptoTransform aesDecryptor = encryptor.CreateDecryptor();

            // Instantiate a new CryptoStream object to process the data and write it to the 
            // memory stream
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);

            // Will contain decrypted plaintext
            string plainText = String.Empty;

            try
            {
                // Convert the ciphertext string into a byte array
                byte[] cipherBytes = Convert.FromBase64String(cipherText);

                // Decrypt the input ciphertext string
                cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);

                // Complete the decryption process
                cryptoStream.FlushFinalBlock();

                // Convert the decrypted data from a MemoryStream to a byte array
                byte[] plainBytes = memoryStream.ToArray();

                // Convert the decrypted byte array to string
                plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length);
            }
            finally
            {
                // Close both the MemoryStream and the CryptoStream
                memoryStream.Close();
                cryptoStream.Close();
            }

            // Return the decrypted data as a string
            return plainText;
        }
        public override string DecryptString(string cipherText, string password)
        {
            byte[] key = StringToByteArrayFastest(password);
            return DecryptString(cipherText, key, defaultIV);
        }

        private byte[] StringToByteArrayFastest(string hex)
        {
            if (hex.Length % 2 == 1)
                throw new Exception("The binary key cannot have an odd number of digits");

            byte[] arr = new byte[hex.Length >> 1];

            for (int i = 0; i < hex.Length >> 1; ++i)
            {
                arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            }

            return arr;
        }
        private int GetHexVal(char hex)
        {
            int val = (int)hex;
            //For uppercase A-F letters:
            //return val - (val < 58 ? 48 : 55);
            //For lowercase a-f letters:
            //return val - (val < 58 ? 48 : 87);
            //Or the two combined, but a bit slower:
            return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
        }
    }
}
