// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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