using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that add value if the ICollection doesn't contains it already.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="value">The value.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool AddIfNotContains<T>(this ICollection<T> @this, T value)
    {
        if (!@this.Contains(value))
        {
            @this.Add(value);
            return true;
        }

        return false;
    }
}

}