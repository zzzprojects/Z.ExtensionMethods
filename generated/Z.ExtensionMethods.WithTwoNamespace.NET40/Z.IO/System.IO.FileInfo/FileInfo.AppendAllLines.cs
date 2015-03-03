using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A FileInfo extension method that appends all lines.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="contents">The contents.</param>
    public static void AppendAllLines(this FileInfo @this, IEnumerable<String> contents)
    {
        File.AppendAllLines(@this.FullName, contents);
    }

    /// <summary>
    ///     A FileInfo extension method that appends all lines.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="contents">The contents.</param>
    /// <param name="encoding">The encoding.</param>
    public static void AppendAllLines(this FileInfo @this, IEnumerable<String> contents, Encoding encoding)
    {
        File.AppendAllLines(@this.FullName, contents, encoding);
    }
}

}