// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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