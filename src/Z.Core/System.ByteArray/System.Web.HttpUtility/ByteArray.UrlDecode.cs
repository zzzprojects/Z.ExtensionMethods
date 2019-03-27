// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Text;
#if !NETSTANDARD
using System.Web;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     Converts a URL-encoded byte array into a decoded string using the specified decoding object.
    /// </summary>
    /// <param name="bytes">The array of bytes to decode.</param>
    /// <param name="e">The  that specifies the decoding scheme.</param>
    /// <returns>A decoded string.</returns>
    public static String UrlDecode(this Byte[] bytes, Encoding e)
    {
        return HttpUtility.UrlDecode(bytes, e);
    }

    /// <summary>
    ///     Converts a URL-encoded byte array into a decoded string using the specified encoding object, starting at the
    ///     specified position in the array, and continuing for the specified number of bytes.
    /// </summary>
    /// <param name="bytes">The array of bytes to decode.</param>
    /// <param name="offset">The position in the byte to begin decoding.</param>
    /// <param name="count">The number of bytes to decode.</param>
    /// <param name="e">The  object that specifies the decoding scheme.</param>
    /// <returns>A decoded string.</returns>
    public static String UrlDecode(this Byte[] bytes, Int32 offset, Int32 count, Encoding e)
    {
        return HttpUtility.UrlDecode(bytes, offset, count, e);
    }
#endif
}