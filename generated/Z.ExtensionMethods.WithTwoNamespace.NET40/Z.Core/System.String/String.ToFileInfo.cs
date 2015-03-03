using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that converts the @this to a file information.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a FileInfo.</returns>
    public static FileInfo ToFileInfo(this string @this)
    {
        return new FileInfo(@this);
    }
}

}