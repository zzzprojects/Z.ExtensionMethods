// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
#if NET45_OR_GREATER
using System.IO;
using System.IO.Compression;
using System.Text;

public static partial class Extensions
{
    /// <summary>Opens a zip archive at the specified path and in the specified mode.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="mode">
    ///     One of the enumeration values that specifies the actions that are allowed
    ///     on the entries in the opened archive.
    /// </param>
    /// <returns>A ZipArchive.</returns>
    public static ZipArchive OpenZipFile(this FileInfo @this, ZipArchiveMode mode)
    {
        return ZipFile.Open(@this.FullName, mode);
    }

    /// <summary>Opens a zip archive at the specified path and in the specified mode.</summary>
    /// <param name="this">
    ///     The path to the archive to open, specified as a relative or absolute
    ///     path. A relative path is interpreted as relative to the current working directory.
    /// </param>
    /// <param name="mode">
    ///     One of the enumeration values that specifies the actions that are allowed
    ///     on the entries in the opened archive.
    /// </param>
    /// <param name="entryNameEncoding">
    ///     The encoding to use when reading or writing entry names in
    ///     this archive. Specify a value for this parameter only when an encoding is required for
    ///     interoperability with zip archive tools and libraries that do not support UTF-8 encoding for
    ///     entry names.
    /// </param>
    /// <returns>A ZipArchive.</returns>
    public static ZipArchive OpenZipFile(this FileInfo @this, ZipArchiveMode mode, Encoding entryNameEncoding)
    {
        return ZipFile.Open(@this.FullName, mode, entryNameEncoding);
    }
}
#endif