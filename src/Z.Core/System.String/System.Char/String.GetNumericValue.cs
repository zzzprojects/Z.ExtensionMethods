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