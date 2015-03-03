using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.Collections.Generic;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     An IEnumerable&lt;T&gt; extension method that queries if a not is empty.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The collection to act on.</param>
    /// <returns>true if a not is t>, false if not.</returns>
    public static bool IsNotEmpty<T>(this IEnumerable<T> @this)
    {
        return @this.Any();
    }
}

}