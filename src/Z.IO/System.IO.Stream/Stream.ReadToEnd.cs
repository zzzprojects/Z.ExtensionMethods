// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.IO;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A Stream extension method that reads a stream to the end.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>
    ///     The rest of the stream as a string, from the current position to the end. If the current position is at the
    ///     end of the stream, returns an empty string ("").
    /// </returns>
    public static string ReadToEnd(this Stream @this)
    {
        using (var sr = new StreamReader(@this, Encoding.Default))
        {
            return sr.ReadToEnd();
        }
    }

    /// <summary>
    ///     A Stream extension method that reads a stream to the end.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="encoding">The encoding.</param>
    /// <returns>
    ///     The rest of the stream as a string, from the current position to the end. If the current position is at the
    ///     end of the stream, returns an empty string ("").
    /// </returns>
    public static string ReadToEnd(this Stream @this, Encoding encoding)
    {
        using (var sr = new StreamReader(@this, encoding))
        {
            return sr.ReadToEnd();
        }
    }

    /// <summary>
    ///     A Stream extension method that reads a stream to the end.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="position">The position.</param>
    /// <returns>
    ///     The rest of the stream as a string, from the current position to the end. If the current position is at the
    ///     end of the stream, returns an empty string ("").
    /// </returns>
    public static string ReadToEnd(this Stream @this, long position)
    {
        @this.Position = position;

        using (var sr = new StreamReader(@this, Encoding.Default))
        {
            return sr.ReadToEnd();
        }
    }

    /// <summary>
    ///     A Stream extension method that reads a stream to the end.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="encoding">The encoding.</param>
    /// <param name="position">The position.</param>
    /// <returns>
    ///     The rest of the stream as a string, from the current position to the end. If the current position is at the
    ///     end of the stream, returns an empty string ("").
    /// </returns>
    public static string ReadToEnd(this Stream @this, Encoding encoding, long position)
    {
        @this.Position = position;

        using (var sr = new StreamReader(@this, encoding))
        {
            return sr.ReadToEnd();
        }
    }
}