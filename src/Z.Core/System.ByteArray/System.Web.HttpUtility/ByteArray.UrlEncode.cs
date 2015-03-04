// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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