// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether a @this includes a file name extension.
    /// </summary>
    /// <param name="this">The @this to search for an extension.</param>
    /// <returns>
    ///     true if the characters that follow the last directory separator (\\ or /) or volume separator (:) in the
    ///     @this include a period (.) followed by one or more characters; otherwise, false.
    /// </returns>
    /// ###
    /// <exception cref="T:System.ArgumentException">
    ///     <paramref name="this" /> contains one or more of the invalid
    ///     characters defined in
    ///     <see
    ///         cref="M:System.IO.Path.GetInvalidPathChars" />
    ///     .
    /// </exception>
    public static Boolean HasExtension(this FileInfo @this)
    {
        return Path.HasExtension(@this.FullName);
    }
}