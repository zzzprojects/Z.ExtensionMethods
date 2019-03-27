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
    ///     An ICollection&lt;T&gt; extension method that queries if the collection is not (null or is empty).
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if the collection is not (null or empty), false if not.</returns>
    public static bool IsNotNullOrEmpty<T>(this ICollection<T> @this)
    {
        return @this != null && @this.Count != 0;
    }
}