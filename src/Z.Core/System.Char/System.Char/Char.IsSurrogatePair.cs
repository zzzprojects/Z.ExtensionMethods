// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    ///     Indicates whether the two specified  objects form a surrogate pair.
    /// </summary>
    /// <param name="highSurrogate">The character to evaluate as the high surrogate of a surrogate pair.</param>
    /// <param name="lowSurrogate">The character to evaluate as the low surrogate of a surrogate pair.</param>
    /// <returns>
    ///     true if the numeric value of the  parameter ranges from U+D800 through U+DBFF, and the numeric value of the
    ///     parameter ranges from U+DC00 through U+DFFF; otherwise, false.
    /// </returns>
    public static Boolean IsSurrogatePair(this Char highSurrogate, Char lowSurrogate)
    {
        return Char.IsSurrogatePair(highSurrogate, lowSurrogate);
    }
}