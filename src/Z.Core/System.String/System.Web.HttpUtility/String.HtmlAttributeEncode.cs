// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.IO;
using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     Minimally converts a string to an HTML-encoded string.
    /// </summary>
    /// <param name="s">The string to encode.</param>
    /// <returns>An encoded string.</returns>
    public static String HtmlAttributeEncode(this String s)
    {
        return HttpUtility.HtmlAttributeEncode(s);
    }

    /// <summary>
    ///     Minimally converts a string into an HTML-encoded string and sends the encoded string to a  output stream.
    /// </summary>
    /// <param name="s">The string to encode.</param>
    /// <param name="output">A  output stream.</param>
    public static void HtmlAttributeEncode(this String s, TextWriter output)
    {
        HttpUtility.HtmlAttributeEncode(s, output);
    }
}