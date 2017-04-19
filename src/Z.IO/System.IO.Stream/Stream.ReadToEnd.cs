// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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