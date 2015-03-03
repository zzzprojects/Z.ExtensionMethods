using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;
using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     A FileInfo extension method that gets directory name.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The directory name.</returns>
    public static String GetDirectoryName(this FileInfo @this)
    {
        return @this.Directory.Name;
    }
}

}