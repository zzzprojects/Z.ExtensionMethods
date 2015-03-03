using System;
using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     Gets a value indicating whether the specified @this string contains a root.
    /// </summary>
    /// <param name="this">The @this to test.</param>
    /// <returns>
    ///     true if <paramref name="this" /> contains a root; otherwise, false.
    /// </returns>
    /// ###
    /// <exception cref="T:System.ArgumentException">
    ///     <paramref name="this" /> contains one or more of the invalid
    ///     characters defined in
    ///     <see
    ///         cref="M:System.IO.Path.GetInvalidPathChars" />
    ///     .
    /// </exception>
    public static Boolean IsPathRooted(this FileInfo @this)
    {
        return Path.IsPathRooted(@this.FullName);
    }
}