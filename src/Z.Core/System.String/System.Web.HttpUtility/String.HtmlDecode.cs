// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.IO;
using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a string that has been HTML-encoded for HTTP transmission into a decoded string.
    /// </summary>
    /// <param name="s">The string to decode.</param>
    /// <returns>A decoded string.</returns>
    public static String HtmlDecode(this String s)
    {
        return HttpUtility.HtmlDecode(s);
    }

    /// <summary>
    ///     Converts a string that has been HTML-encoded into a decoded string, and sends the decoded string to a  output
    ///     stream.
    /// </summary>
    /// <param name="s">The string to decode.</param>
    /// <param name="output">A  stream of output.</param>
    public static void HtmlDecode(this String s, TextWriter output)
    {
        HttpUtility.HtmlDecode(s, output);
    }
}