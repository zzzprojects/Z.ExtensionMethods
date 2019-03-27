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
    ///     A string extension method that query if this object contains the given value.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="value">The value.</param>
    /// <returns>true if the value is in the string, false if not.</returns>
    public static bool Contains(this string @this, string value)
    {
        return @this.IndexOf(value) != -1;
    }

    /// <summary>
    ///     A string extension method that query if this object contains the given value.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="value">The value.</param>
    /// <param name="comparisonType">Type of the comparison.</param>
    /// <returns>true if the value is in the string, false if not.</returns>
    public static bool Contains(this string @this, string value, StringComparison comparisonType)
    {
        return @this.IndexOf(value, comparisonType) != -1;
    }
}