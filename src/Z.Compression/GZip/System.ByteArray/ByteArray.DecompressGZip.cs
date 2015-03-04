// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.IO;
using System.IO.Compression;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A byte[] extension method that decompress the byte array gzip to string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The byte array gzip to string.</returns>
    public static string DecompressGZip(this byte[] @this)
    {
        const int bufferSize = 1024;
        using (var memoryStream = new MemoryStream(@this))
        {
            using (var zipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
            {
                // Memory stream for storing the decompressed bytes
                using (var outStream = new MemoryStream())
                {
                    var buffer = new byte[bufferSize];
                    int totalBytes = 0;
                    int readBytes;
                    while ((readBytes = zipStream.Read(buffer, 0, bufferSize)) > 0)
                    {
                        outStream.Write(buffer, 0, readBytes);
                        totalBytes += readBytes;
                    }
                    return Encoding.Default.GetString(outStream.GetBuffer(), 0, totalBytes);
                }
            }
        }
    }

    /// <summary>
    ///     A byte[] extension method that decompress the byte array gzip to string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="encoding">The encoding.</param>
    /// <returns>The byte array gzip to string.</returns>
    public static string DecompressGZip(this byte[] @this, Encoding encoding)
    {
        const int bufferSize = 1024;
        using (var memoryStream = new MemoryStream(@this))
        {
            using (var zipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
            {
                // Memory stream for storing the decompressed bytes
                using (var outStream = new MemoryStream())
                {
                    var buffer = new byte[bufferSize];
                    int totalBytes = 0;
                    int readBytes;
                    while ((readBytes = zipStream.Read(buffer, 0, bufferSize)) > 0)
                    {
                        outStream.Write(buffer, 0, readBytes);
                        totalBytes += readBytes;
                    }
                    return encoding.GetString(outStream.GetBuffer(), 0, totalBytes);
                }
            }
        }
    }
}