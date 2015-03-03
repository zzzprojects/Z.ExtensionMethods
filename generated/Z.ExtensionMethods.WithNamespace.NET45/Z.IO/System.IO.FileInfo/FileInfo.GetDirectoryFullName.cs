using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.IOExtensions
{

using System;
using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     A FileInfo extension method that gets directory full name.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The directory full name.</returns>
    public static String GetDirectoryFullName(this FileInfo @this)
    {
        return @this.Directory.FullName;
    }
}

}