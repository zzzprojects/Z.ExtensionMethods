// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     Changes the extension of a @this string.
    /// </summary>
    /// <param name="this">
    ///     The @this information to modify. The @this cannot contain any of the characters defined in
    ///     <see
    ///         cref="M:System.IO.Path.GetInvalidPathChars" />
    ///     .
    /// </param>
    /// <param name="extension">
    ///     The new extension (with or without a leading period). Specify null to remove an existing
    ///     extension from
    ///     <paramref
    ///         name="this" />
    ///     .
    /// </param>
    /// <returns>
    ///     The modified @this information.On Windows-based desktop platforms, if <paramref name="this" /> is null or an
    ///     empty string (""), the @this information is returned unmodified. If
    ///     <paramref
    ///         name="extension" />
    ///     is null, the returned string contains the specified @this with its extension removed. If
    ///     <paramref
    ///         name="this" />
    ///     has no extension, and <paramref name="extension" /> is not null, the returned @this string contains
    ///     <paramref
    ///         name="extension" />
    ///     appended to the end of <paramref name="this" />.
    /// </returns>
    /// ###
    /// <exception cref="T:System.ArgumentException">
    ///     <paramref name="this" /> contains one or more of the invalid
    ///     characters defined in
    ///     <see
    ///         cref="M:System.IO.Path.GetInvalidPathChars" />
    ///     .
    /// </exception>
    public static String ChangeExtension(this FileInfo @this, String extension)
    {
        return Path.ChangeExtension(@this.FullName, extension);
    }
}