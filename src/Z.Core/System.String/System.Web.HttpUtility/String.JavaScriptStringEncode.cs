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