namespace Z.ExtensionMethods
{

using System;
using System.Web;

public static partial class Extensions
    {
        /// <summary>
        ///     Encodes a string.
        /// </summary>
        /// <param name="value">A string to encode.</param>
        /// <returns>An encoded string.</returns>
        public static String JavaScriptStringEncode(this String value)
        {
            return HttpUtility.JavaScriptStringEncode(value);
        }

        /// <summary>
        ///     Encodes a string.
        /// </summary>
        /// <param name="value">A string to encode.</param>
        /// <param name="addDoubleQuotes">
        ///     A value that indicates whether double quotation marks will be included around the
        ///     encoded string.
        /// </param>
        /// <returns>An encoded string.</returns>
        public static String JavaScriptStringEncode(this String value, Boolean addDoubleQuotes)
        {
            return HttpUtility.JavaScriptStringEncode(value, addDoubleQuotes);
        }
    }


}