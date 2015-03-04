// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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