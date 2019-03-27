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
    ///     Converts the value of a Unicode character to its uppercase equivalent using the casing rules of the invariant
    ///     culture.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <returns>
    ///     The uppercase equivalent of the  parameter, or the unchanged value of , if  is already uppercase or not
    ///     alphabetic.
    /// </returns>
    public static Char ToUpperInvariant(this Char c)
    {
        return Char.ToUpperInvariant(c);
    }
}