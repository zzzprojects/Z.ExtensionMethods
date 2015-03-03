using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CollectionsExtensions
{

using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that removes the range if contains.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    public static void RemoveRangeIfContains<T>(this ICollection<T> @this, params T[] values)
    {
        foreach (T value in values)
        {
            if (@this.Contains(value))
            {
                @this.Remove(value);
            }
        }
    }
}

}