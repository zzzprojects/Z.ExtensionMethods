using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CollectionsExtensions
{

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

}