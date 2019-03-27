// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Linq;
using System.Text.RegularExpressions;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that extracts all Decimal from the string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>All extracted Decimal.</returns>
    public static decimal[] ExtractManyDecimal(this string @this)
    {
        return Regex.Matches(@this, @"[-]?\d+(\.\d+)?")
            .Cast<Match>()
            .Select(x => Convert.ToDecimal(x.Value))
            .ToArray();
    }
}