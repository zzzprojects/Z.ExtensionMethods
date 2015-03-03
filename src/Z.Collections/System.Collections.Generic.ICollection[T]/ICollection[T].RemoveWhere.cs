using System;
using System.Collections.Generic;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that removes value that satisfy the predicate.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="predicate">The predicate.</param>
    public static void RemoveWhere<T>(this ICollection<T> @this, Func<T, bool> predicate)
    {
        List<T> list = @this.Where(predicate).ToList();
        foreach (T item in list)
        {
            @this.Remove(item);
        }
    }
}