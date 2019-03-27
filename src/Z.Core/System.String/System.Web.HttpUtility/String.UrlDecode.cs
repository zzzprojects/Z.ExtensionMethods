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