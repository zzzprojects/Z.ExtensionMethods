// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Text;
using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a URL-encoded string into a decoded array of bytes.
    /// </summary>
    /// <param name="str">The string to decode.</param>
    /// <returns>A decoded array of bytes.</returns>
    public static Byte[] UrlDecodeToBytes(this String str)
    {
        return HttpUtility.UrlDecodeToBytes(str);
    }

    /// <summary>
    ///     Converts a URL-encoded string into a decoded array of bytes using the specified decoding object.
    /// </summary>
    /// <param name="str">The string to decode.</param>
    /// <param name="e">The  object that specifies the decoding scheme.</param>
    /// <returns>A decoded array of bytes.</returns>
    public static Byte[] UrlDecodeToBytes(this String str, Encoding e)
    {
        return HttpUtility.UrlDecodeToBytes(str, e);
    }
}