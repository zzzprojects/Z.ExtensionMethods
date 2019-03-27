// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that extracts the UInt16 from the string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted UInt16.</returns>
    public static ushort ExtractUInt16(this string @this)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < @this.Length; i++)
        {
            if (Char.IsDigit(@this[i]))
            {
                sb.Append(@this[i]);
            }
        }

        return Convert.ToUInt16(sb.ToString());
    }
}