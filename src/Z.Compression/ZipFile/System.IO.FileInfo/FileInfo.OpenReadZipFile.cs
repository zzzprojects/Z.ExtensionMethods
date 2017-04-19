// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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