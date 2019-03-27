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
    ///     Converts the value of a UTF-16 encoded surrogate pair into a Unicode code point.
    /// </summary>
    /// <param name="highSurrogate">A high surrogate code unit (that is, a code unit ranging from U+D800 through U+DBFF).</param>
    /// <param name="lowSurrogate">A low surrogate code unit (that is, a code unit ranging from U+DC00 through U+DFFF).</param>
    /// <returns>The 21-bit Unicode code point represented by the  and  parameters.</returns>
    public static Int32 ConvertToUtf32(this Char highSurrogate, Char lowSurrogate)
    {
        return Char.ConvertToUtf32(highSurrogate, lowSurrogate);
    }
}