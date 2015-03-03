using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that decrypt a string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="key">The key.</param>
        /// <returns>The decrypted string.</returns>
        public static string DecryptRSA(this string @this, string key)
        {
            var cspp = new CspParameters {KeyContainerName = key};
            var rsa = new RSACryptoServiceProvider(cspp) {PersistKeyInCsp = true};
            string[] decryptArray = @this.Split(new[] {"-"}, StringSplitOptions.None);
            byte[] decryptByteArray = Array.ConvertAll(decryptArray, (s => Convert.ToByte(byte.Parse(s, NumberStyles.HexNumber))));
            byte[] bytes = rsa.Decrypt(decryptByteArray, true);

            return Encoding.UTF8.GetString(bytes);
        }
    }


}