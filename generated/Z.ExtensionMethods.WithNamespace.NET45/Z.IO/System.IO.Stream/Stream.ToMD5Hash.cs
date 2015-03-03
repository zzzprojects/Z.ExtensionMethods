using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.IOExtensions
{

using System.IO;
using System.Security.Cryptography;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A Stream extension method that converts the @this to a md 5 hash.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a string.</returns>
    public static string ToMD5Hash(this Stream @this)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] hashBytes = md5.ComputeHash(@this);
            var sb = new StringBuilder();
            foreach (byte bytes in hashBytes)
            {
                sb.Append(bytes.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}

}