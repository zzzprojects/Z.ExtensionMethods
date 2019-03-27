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
    ///     A string extension method that query if '@this' contains all values.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>true if it contains all values, otherwise false.</returns>
    public static bool ContainsAll(this string @this, params string[] values)
    {
        foreach (string value in values)
        {
            if (@this.IndexOf(value) == -1)
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    ///     A string extension method that query if this object contains the given @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="comparisonType">Type of the comparison.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>true if it contains all values, otherwise false.</returns>
    public static bool ContainsAll(this string @this, StringComparison comparisonType, params string[] values)
    {
        foreach (string value in values)
        {
            if (@this.IndexOf(value, comparisonType) == -1)
            {
                return false;
            }
        }
        return true;
    }
}