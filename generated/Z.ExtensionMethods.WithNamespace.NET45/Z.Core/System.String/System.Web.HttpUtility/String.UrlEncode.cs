using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;
using System.Text;
using System.Web;

public static partial class Extensions
    {
        /// <summary>
        ///     Encodes a URL string.
        /// </summary>
        /// <param name="str">The text to encode.</param>
        /// <returns>An encoded string.</returns>
        public static String UrlEncode(this String str)
        {
            return HttpUtility.UrlEncode(str);
        }

        /// <summary>
        ///     Encodes a URL string using the specified encoding object.
        /// </summary>
        /// <param name="str">The text to encode.</param>
        /// <param name="e">The  object that specifies the encoding scheme.</param>
        /// <returns>An encoded string.</returns>
        public static String UrlEncode(this String str, Encoding e)
        {
            return HttpUtility.UrlEncode(str, e);
        }
    }


}