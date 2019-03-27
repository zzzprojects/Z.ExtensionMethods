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
    ///     Converts the specified Unicode character to its equivalent string representation.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <returns>The string representation of the value of .</returns>
    public static String ToString(this Char c)
    {
        return Char.ToString(c);
    }
}