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
        ///     Converts a string that has been encoded for transmission in a URL into a decoded string.
        /// </summary>
        /// <param name="str">The string to decode.</param>
        /// <returns>A decoded string.</returns>
        public static String UrlDecode(this String str)
        {
            return HttpUtility.UrlDecode(str);
        }

        /// <summary>
        ///     Converts a URL-encoded string into a decoded string, using the specified encoding object.
        /// </summary>
        /// <param name="str">The string to decode.</param>
        /// <param name="e">The  that specifies the decoding scheme.</param>
        /// <returns>A decoded string.</returns>
        public static String UrlDecode(this String str, Encoding e)
        {
            return HttpUtility.UrlDecode(str, e);
        }
    }


}