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
    ///     Converts a string into a URL-encoded array of bytes.
    /// </summary>
    /// <param name="str">The string to encode.</param>
    /// <returns>An encoded array of bytes.</returns>
    public static Byte[] UrlEncodeToBytes(this String str)
    {
        return HttpUtility.UrlEncodeToBytes(str);
    }

    /// <summary>
    ///     Converts a string into a URL-encoded array of bytes using the specified encoding object.
    /// </summary>
    /// <param name="str">The string to encode.</param>
    /// <param name="e">The  that specifies the encoding scheme.</param>
    /// <returns>An encoded array of bytes.</returns>
    public static Byte[] UrlEncodeToBytes(this String str, Encoding e)
    {
        return HttpUtility.UrlEncodeToBytes(str, e);
    }
}