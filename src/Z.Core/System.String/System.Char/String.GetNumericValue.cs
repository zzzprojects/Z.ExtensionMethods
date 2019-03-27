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
    ///     Converts the numeric Unicode character at the specified position in a specified string to a double-precision
    ///     floating point number.
    /// </summary>
    /// <param name="s">A .</param>
    /// <param name="index">The character position in .</param>
    /// <returns>
    ///     The numeric value of the character at position  in  if that character represents a number; otherwise, -1.
    /// </returns>
    public static Double GetNumericValue(this String s, Int32 index)
    {
        return Char.GetNumericValue(s, index);
    }
}