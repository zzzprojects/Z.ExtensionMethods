using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that converts the @this to a directory information.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a DirectoryInfo.</returns>
    public static DirectoryInfo ToDirectoryInfo(this string @this)
    {
        return new DirectoryInfo(@this);
    }
}

}