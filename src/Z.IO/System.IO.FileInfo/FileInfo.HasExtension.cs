// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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