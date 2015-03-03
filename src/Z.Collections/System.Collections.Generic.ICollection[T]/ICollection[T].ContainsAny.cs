using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that query if '@this' contains any value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool ContainsAny<T>(this ICollection<T> @this, params T[] values)
    {
        foreach (T value in values)
        {
            if (@this.Contains(value))
            {
                return true;
            }
        }

        return false;
    }
}