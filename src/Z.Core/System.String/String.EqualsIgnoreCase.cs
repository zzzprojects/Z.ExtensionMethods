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
    /// A string extension method that checks if '@this' is equal to another string regardless of it's case.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="comparedString">The compared string.</param>
    /// <returns>
    /// true if it contains all values, otherwise false.
    /// </returns>
    public static bool EqualsIgnoreCase(this string @this, string comparedString)
    {
        return @this.Equals(comparedString, StringComparison.OrdinalIgnoreCase);
    }
}