// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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