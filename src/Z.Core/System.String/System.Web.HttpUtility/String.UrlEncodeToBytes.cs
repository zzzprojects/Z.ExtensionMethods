// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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