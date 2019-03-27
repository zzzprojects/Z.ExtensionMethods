// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
#if !NETSTANDARD
using System.Web;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     Converts a URL-encoded array of bytes into a decoded array of bytes.
    /// </summary>
    /// <param name="bytes">The array of bytes to decode.</param>
    /// <returns>A decoded array of bytes.</returns>
    public static Byte[] UrlDecodeToBytes(this Byte[] bytes)
    {
        return HttpUtility.UrlDecodeToBytes(bytes);
    }

    /// <summary>
    ///     Converts a URL-encoded array of bytes into a decoded array of bytes, starting at the specified position in
    ///     the array and continuing for the specified number of bytes.
    /// </summary>
    /// <param name="bytes">The array of bytes to decode.</param>
    /// <param name="offset">The position in the byte array at which to begin decoding.</param>
    /// <param name="count">The number of bytes to decode.</param>
    /// <returns>A decoded array of bytes.</returns>
    public static Byte[] UrlDecodeToBytes(this Byte[] bytes, Int32 offset, Int32 count)
    {
        return HttpUtility.UrlDecodeToBytes(bytes, offset, count);
    }
#endif
}