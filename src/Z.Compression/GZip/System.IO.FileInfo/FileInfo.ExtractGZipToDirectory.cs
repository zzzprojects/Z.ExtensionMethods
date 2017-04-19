// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.IO;
using System.IO.Compression;

public static partial class Extensions
{
    /// <summary>
    ///     A FileInfo extension method that extracts the g zip to directory described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void ExtractGZipToDirectory(this FileInfo @this)
    {
        using (FileStream originalFileStream = @this.OpenRead())
        {
            string newFileName = Path.GetFileNameWithoutExtension(@this.FullName);

            using (FileStream decompressedFileStream = File.Create(newFileName))
            {
                using (var decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                {
                    decompressionStream.CopyTo(decompressedFileStream);
                }
            }
        }
    }

    /// <summary>
    ///     A FileInfo extension method that extracts the g zip to directory described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="destination">Destination for the.</param>
    public static void ExtractGZipToDirectory(this FileInfo @this, string destination)
    {
        using (FileStream originalFileStream = @this.OpenRead())
        {
            using (FileStream compressedFileStream = File.Create(destination))
            {
                using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                {
                    originalFileStream.CopyTo(compressionStream);
                }
            }
        }
    }

    /// <summary>
    ///     A FileInfo extension method that extracts the g zip to directory described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="destination">Destination for the.</param>
    public static void ExtractGZipToDirectory(this FileInfo @this, FileInfo destination)
    {
        using (FileStream originalFileStream = @this.OpenRead())
        {
            using (FileStream compressedFileStream = File.Create(destination.FullName))
            {
                using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                {
                    originalFileStream.CopyTo(compressionStream);
                }
            }
        }
    }
}