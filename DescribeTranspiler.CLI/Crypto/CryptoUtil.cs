using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DescribeTranspiler.CLI
{
    internal abstract class CryptoUtil
    {
        public abstract byte[] defaultIV 
        {
            get;
        }

        public abstract string HashHMAC(string key, string message);

        //public abstract string EncryptString(string plaintext, byte[] key, byte[] iv);
        public abstract string EncryptString(string plaintext, string password);

        //public abstract string DecryptString(string cipherText, byte[] key, byte[] iv);
        public abstract string DecryptString(string cipherText, string password);
    }
}
