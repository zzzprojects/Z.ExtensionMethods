using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;
using System.Web;

public static partial class Extensions
    {
        /// <summary>
        ///     Converts an array of bytes into a URL-encoded array of bytes.
        /// </summary>
        /// <param name="bytes">The array of bytes to encode.</param>
        /// <returns>An encoded array of bytes.</returns>
        public static Byte[] UrlEncodeToBytes(this Byte[] bytes)
        {
            return HttpUtility.UrlEncodeToBytes(bytes);
        }

        /// <summary>
        ///     Converts an array of bytes into a URL-encoded array of bytes, starting at the specified position in the array
        ///     and continuing for the specified number of bytes.
        /// </summary>
        /// <param name="bytes">The array of bytes to encode.</param>
        /// <param name="offset">The position in the byte array at which to begin encoding.</param>
        /// <param name="count">The number of bytes to encode.</param>
        /// <returns>An encoded array of bytes.</returns>
        public static Byte[] UrlEncodeToBytes(this Byte[] bytes, Int32 offset, Int32 count)
        {
            return HttpUtility.UrlEncodeToBytes(bytes, offset, count);
        }
    }


}