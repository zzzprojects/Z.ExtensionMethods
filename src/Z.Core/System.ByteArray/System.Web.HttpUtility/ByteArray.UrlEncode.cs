// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a byte array into an encoded URL string.
    /// </summary>
    /// <param name="bytes">The array of bytes to encode.</param>
    /// <returns>An encoded string.</returns>
    public static String UrlEncode(this Byte[] bytes)
    {
        return HttpUtility.UrlEncode(bytes);
    }

    /// <summary>
    ///     Converts a byte array into a URL-encoded string, starting at the specified position in the array and
    ///     continuing for the specified number of bytes.
    /// </summary>
    /// <param name="bytes">The array of bytes to encode.</param>
    /// <param name="offset">The position in the byte array at which to begin encoding.</param>
    /// <param name="count">The number of bytes to encode.</param>
    /// <returns>An encoded string.</returns>
    public static String UrlEncode(this Byte[] bytes, Int32 offset, Int32 count)
    {
        return HttpUtility.UrlEncode(bytes, offset, count);
    }
}