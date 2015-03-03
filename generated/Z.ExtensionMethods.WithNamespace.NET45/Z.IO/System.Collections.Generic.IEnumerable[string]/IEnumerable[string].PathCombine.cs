using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.IOExtensions
{

using System.Collections.Generic;
using System.IO;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     An IEnumerable&lt;string&gt; extension method that combine all value to return a path.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The path.</returns>
    public static string PathCombine(this IEnumerable<string> @this)
    {
        return Path.Combine(@this.ToArray());
    }
}

}