// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     Encodes a string.
    /// </summary>
    /// <param name="value">A string to encode.</param>
    /// <returns>An encoded string.</returns>
    public static String JavaScriptStringEncode(this String value)
    {
        return HttpUtility.JavaScriptStringEncode(value);
    }

    /// <summary>
    ///     Encodes a string.
    /// </summary>
    /// <param name="value">A string to encode.</param>
    /// <param name="addDoubleQuotes">
    ///     A value that indicates whether double quotation marks will be included around the
    ///     encoded string.
    /// </param>
    /// <returns>An encoded string.</returns>
    public static String JavaScriptStringEncode(this String value, Boolean addDoubleQuotes)
    {
        return HttpUtility.JavaScriptStringEncode(value, addDoubleQuotes);
    }
}