// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that removes if.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="value">The value.</param>
    /// <param name="predicate">The predicate.</param>
    public static void RemoveIf<T>(this ICollection<T> @this, T value, Func<T, bool> predicate)
    {
        if (predicate(value))
        {
            @this.Remove(value);
        }
    }
}