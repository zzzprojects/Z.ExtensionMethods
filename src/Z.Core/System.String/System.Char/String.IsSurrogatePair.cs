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