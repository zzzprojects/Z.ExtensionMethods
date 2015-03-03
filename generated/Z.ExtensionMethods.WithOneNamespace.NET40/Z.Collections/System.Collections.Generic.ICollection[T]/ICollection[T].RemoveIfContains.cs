namespace Z.ExtensionMethods
{

using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that removes if contains.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="value">The value.</param>
    public static void RemoveIfContains<T>(this ICollection<T> @this, T value)
    {
        if (@this.Contains(value))
        {
            @this.Remove(value);
        }
    }
}

}