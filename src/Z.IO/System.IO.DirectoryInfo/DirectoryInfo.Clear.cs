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
    ///     A DirectoryInfo extension method that clears all files and directories in this directory.
    /// </summary>
    /// <param name="obj">The obj to act on.</param>
    public static void Clear(this DirectoryInfo obj)
    {
        Array.ForEach(obj.GetFiles(), x => x.Delete());
        Array.ForEach(obj.GetDirectories(), x => x.Delete(true));
    }
}