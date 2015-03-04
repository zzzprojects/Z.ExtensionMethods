// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

#if NET45_OR_GREATER
using System.IO;
using System.IO.Compression;

public static partial class Extensions
{
    /// <summary>
    ///     The path to the archive to open, specified as a relative or absolute path. A relative path is interpreted as
    ///     relative to the current working directory.
    /// </summary>
    /// <param name="this">
    ///     The path to the archive to open, specified as a relative or absolute path. A relative path is
    ///     interpreted as relative to the current working directory.
    /// </param>
    /// <returns>The opened zip archive.</returns>
    public static ZipArchive OpenReadZipFile(this FileInfo @this)
    {
        return ZipFile.OpenRead(@this.FullName);
    }
}
#endif