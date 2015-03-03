namespace Z.ExtensionMethods
{

using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that queries if the collection is null or is empty.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if null or empty&lt; t&gt;, false if not.</returns>
    public static bool IsNullOrEmpty<T>(this ICollection<T> @this)
    {
        return @this == null || @this.Count == 0;
    }
}

}