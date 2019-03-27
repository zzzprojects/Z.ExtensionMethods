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
    ///     Indicates whether the specified  object is a low surrogate.
    /// </summary>
    /// <param name="c">The character to evaluate.</param>
    /// <returns>
    ///     true if the numeric value of the  parameter ranges from U+DC00 through U+DFFF; otherwise, false.
    /// </returns>
    public static Boolean IsLowSurrogate(this Char c)
    {
        return Char.IsLowSurrogate(c);
    }
}