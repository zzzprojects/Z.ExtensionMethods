// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     Encodes the path portion of a URL string for reliable HTTP transmission from the Web server to a client.
    /// </summary>
    /// <param name="str">The text to encode.</param>
    /// <returns>The encoded text.</returns>
    public static String UrlPathEncode(this String str)
    {
        return HttpUtility.UrlPathEncode(str);
    }
}