// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that query if '@this' contains all values.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool ContainsAll<T>(this ICollection<T> @this, params T[] values)
    {
        foreach (T value in values)
        {
            if (!@this.Contains(value))
            {
                return false;
            }
        }

        return true;
    }
}