using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;
using System.Web;

public static partial class Extensions
    {
        /// <summary>
        ///     Encodes a byte array into its equivalent string representation using base 64 digits, which is usable for
        ///     transmission on the URL.
        /// </summary>
        /// <param name="input">The byte array to encode.</param>
        /// <returns>
        ///     The string containing the encoded token if the byte array length is greater than one; otherwise, an empty
        ///     string (&quot;&quot;).
        /// </returns>
        public static String UrlTokenEncode(this Byte[] input)
        {
            return HttpServerUtility.UrlTokenEncode(input);
        }
    }


}