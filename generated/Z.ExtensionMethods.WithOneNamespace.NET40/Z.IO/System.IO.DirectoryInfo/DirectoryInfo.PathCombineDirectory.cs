namespace Z.ExtensionMethods
{

using System.Collections.Generic;
using System.IO;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     Combines multiples string into a path.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="paths">A variable-length parameters list containing paths.</param>
    /// <returns>
    ///     The combined paths as a DirectoryInfo. If one of the specified paths is a zero-length string, this method
    ///     returns the other path.
    /// </returns>
    public static DirectoryInfo PathCombineDirectory(this DirectoryInfo @this, params string[] paths)
    {
        List<string> list = paths.ToList();
        list.Insert(0, @this.FullName);
        return new DirectoryInfo(Path.Combine(list.ToArray()));
    }
}

}