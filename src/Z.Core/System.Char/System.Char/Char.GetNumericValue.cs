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
    ///     Converts the specified numeric Unicode character to a double-precision floating point number.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <returns>The numeric value of  if that character represents a number; otherwise, -1.0.</returns>
    public static Double GetNumericValue(this Char c)
    {
        return Char.GetNumericValue(c);
    }
}