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
    ///     Converts the specified Unicode code point into a UTF-16 encoded string.
    /// </summary>
    /// <param name="utf32">A 21-bit Unicode code point.</param>
    /// <returns>
    ///     A string consisting of one  object or a surrogate pair of  objects equivalent to the code point specified by
    ///     the  parameter.
    /// </returns>
    public static String ConvertFromUtf32(this Int32 utf32)
    {
        return Char.ConvertFromUtf32(utf32);
    }
}