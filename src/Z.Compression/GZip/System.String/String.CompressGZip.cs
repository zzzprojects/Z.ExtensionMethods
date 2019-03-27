// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.IO;
using System.IO.Compression;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that compress the given string to GZip byte array.
    /// </summary>
    /// <param name="this">The stringToCompress to act on.</param>
    /// <returns>The string compressed into a GZip byte array.</returns>
    public static byte[] CompressGZip(this string @this)
    {
        byte[] stringAsBytes = Encoding.Default.GetBytes(@this);
        using (var memoryStream = new MemoryStream())
        {
            using (var zipStream = new GZipStream(memoryStream, CompressionMode.Compress))
            {
                zipStream.Write(stringAsBytes, 0, stringAsBytes.Length);
                zipStream.Close();
                return (memoryStream.ToArray());
            }
        }
    }

    /// <summary>
    ///     A string extension method that compress the given string to GZip byte array.
    /// </summary>
    /// <param name="this">The stringToCompress to act on.</param>
    /// <param name="encoding">The encoding.</param>
    /// <returns>The string compressed into a GZip byte array.</returns>
    public static byte[] CompressGZip(this string @this, Encoding encoding)
    {
        byte[] stringAsBytes = encoding.GetBytes(@this);
        using (var memoryStream = new MemoryStream())
        {
            using (var zipStream = new GZipStream(memoryStream, CompressionMode.Compress))
            {
                zipStream.Write(stringAsBytes, 0, stringAsBytes.Length);
                zipStream.Close();
                return (memoryStream.ToArray());
            }
        }
    }
}