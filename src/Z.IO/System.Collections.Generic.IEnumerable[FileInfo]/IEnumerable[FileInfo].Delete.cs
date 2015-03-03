using System.Collections.Generic;
using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     An IEnumerable&lt;FileInfo&gt; extension method that deletes the given @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void Delete(this IEnumerable<FileInfo> @this)
    {
        foreach (FileInfo t in @this)
        {
            t.Delete();
        }
    }
}