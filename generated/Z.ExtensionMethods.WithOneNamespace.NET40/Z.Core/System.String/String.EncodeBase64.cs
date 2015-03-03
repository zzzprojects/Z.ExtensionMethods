namespace Z.ExtensionMethods
{

using System;
using System.Text;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that encode the string to Base64.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The encoded string to Base64.</returns>
        public static string EncodeBase64(this string @this)
        {
            return Convert.ToBase64String(Activator.CreateInstance<ASCIIEncoding>().GetBytes(@this));
        }
    }


}