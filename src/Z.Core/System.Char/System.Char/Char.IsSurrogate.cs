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
    ///     Indicates whether the specified character has a surrogate code unit.
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>true if  is either a high surrogate or a low surrogate; otherwise, false.</returns>
    public static Boolean IsSurrogate(this Char c)
    {
        return Char.IsSurrogate(c);
    }
}