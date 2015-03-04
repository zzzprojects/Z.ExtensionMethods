// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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