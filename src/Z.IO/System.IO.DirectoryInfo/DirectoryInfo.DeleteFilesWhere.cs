// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.IO;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     A DirectoryInfo extension method that deletes the files where.
    /// </summary>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="predicate">The predicate.</param>
    public static void DeleteFilesWhere(this DirectoryInfo obj, Func<FileInfo, bool> predicate)
    {
        obj.GetFiles().Where(predicate).ForEach(x => x.Delete());
    }

    /// <summary>
    ///     A DirectoryInfo extension method that deletes the files where.
    /// </summary>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="searchOption">The search option.</param>
    /// <param name="predicate">The predicate.</param>
    public static void DeleteFilesWhere(this DirectoryInfo obj, SearchOption searchOption, Func<FileInfo, bool> predicate)
    {
        obj.GetFiles("*.*", searchOption).Where(predicate).ForEach(x => x.Delete());
    }
}