using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.IOExtensions
{

using System;
using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the file name of the specified @this string without the extension.
    /// </summary>
    /// <param name="this">The @this of the file.</param>
    /// <returns>
    ///     The string returned by <see cref="M:System.IO.Path.GetFileName(System.String)" />, minus the last period (.)
    ///     and all characters following it.
    /// </returns>
    /// ###
    /// <exception cref="T:System.ArgumentException">
    ///     <paramref name="this" /> contains one or more of the invalid
    ///     characters defined in
    ///     <see
    ///         cref="M:System.IO.Path.GetInvalidPathChars" />
    ///     .
    /// </exception>
    public static String GetFileNameWithoutExtension(this FileInfo @this)
    {
        return Path.GetFileNameWithoutExtension(@this.FullName);
    }
}

}