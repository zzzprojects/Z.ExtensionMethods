// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Globalization;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of a specified Unicode character to its uppercase equivalent using specified culture-
    ///     specific formatting information.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <param name="culture">An object that supplies culture-specific casing rules.</param>
    /// <returns>
    ///     The uppercase equivalent of , modified according to , or the unchanged value of  if  is already uppercase,
    ///     has no uppercase equivalent, or is not alphabetic.
    /// </returns>
    public static Char ToUpper(this Char c, CultureInfo culture)
    {
        return Char.ToUpper(c, culture);
    }

    /// <summary>
    ///     Converts the value of a Unicode character to its uppercase equivalent.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <returns>
    ///     The uppercase equivalent of , or the unchanged value of  if  is already uppercase, has no uppercase
    ///     equivalent, or is not alphabetic.
    /// </returns>
    public static Char ToUpper(this Char c)
    {
        return Char.ToUpper(c);
    }
}