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
    ///     Indicates whether two adjacent  objects at a specified position in a string form a surrogate pair.
    /// </summary>
    /// <param name="s">A string.</param>
    /// <param name="index">The starting position of the pair of characters to evaluate within .</param>
    /// <returns>
    ///     true if the  parameter includes adjacent characters at positions  and  + 1, and the numeric value of the
    ///     character at position  ranges from U+D800 through U+DBFF, and the numeric value of the character at position
    ///     +1 ranges from U+DC00 through U+DFFF; otherwise, false.
    /// </returns>
    public static Boolean IsSurrogatePair(this String s, Int32 index)
    {
        return Char.IsSurrogatePair(s, index);
    }
}