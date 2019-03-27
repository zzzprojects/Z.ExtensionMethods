// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Globalization;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of a specified Unicode character to its lowercase equivalent using specified culture-
    ///     specific formatting information.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <param name="culture">An object that supplies culture-specific casing rules.</param>
    /// <returns>
    ///     The lowercase equivalent of , modified according to , or the unchanged value of , if  is already lowercase or
    ///     not alphabetic.
    /// </returns>
    public static Char ToLower(this Char c, CultureInfo culture)
    {
        return Char.ToLower(c, culture);
    }

    /// <summary>
    ///     Converts the value of a Unicode character to its lowercase equivalent.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <returns>
    ///     The lowercase equivalent of , or the unchanged value of , if  is already lowercase or not alphabetic.
    /// </returns>
    public static Char ToLower(this Char c)
    {
        return Char.ToLower(c);
    }
}