using System;
using System.Text;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that decode a Base64 String.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The Base64 String decoded.</returns>
        public static string DecodeBase64(this string @this)
        {
            return Encoding.ASCII.GetString(Convert.FromBase64String(@this));
        }
    }
