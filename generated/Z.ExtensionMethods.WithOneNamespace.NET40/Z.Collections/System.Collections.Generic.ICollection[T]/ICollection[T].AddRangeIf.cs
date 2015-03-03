namespace Z.ExtensionMethods
{

using System;
using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that adds a collection of objects to the end of this collection only
    ///     for value who satisfies the predicate.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="predicate">The predicate.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    public static void AddRangeIf<T>(this ICollection<T> @this, Func<T, bool> predicate, params T[] values)
    {
        foreach (T value in values)
        {
            if (predicate(value))
            {
                @this.Add(value);
            }
        }
    }
}

}