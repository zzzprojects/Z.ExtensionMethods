// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Collections.Generic;
using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     Enumerates for each in this collection.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="action">The action.</param>
    /// <returns>An enumerator that allows foreach to be used to process for each in this collection.</returns>
    public static IEnumerable<FileInfo> ForEach(this IEnumerable<FileInfo> @this, Action<FileInfo> action)
    {
        foreach (FileInfo t in @this)
        {
            action(t);
        }
        return @this;
    }
}