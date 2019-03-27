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
    ///     Converts the value of a UTF-16 encoded character or surrogate pair at a specified position in a string into a
    ///     Unicode code point.
    /// </summary>
    /// <param name="s">A string that contains a character or surrogate pair.</param>
    /// <param name="index">The index position of the character or surrogate pair in .</param>
    /// <returns>
    ///     The 21-bit Unicode code point represented by the character or surrogate pair at the position in the parameter
    ///     specified by the  parameter.
    /// </returns>
    public static Int32 ConvertToUtf32(this String s, Int32 index)
    {
        return Char.ConvertToUtf32(s, index);
    }
}