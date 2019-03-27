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
    ///     A FileInfo extension method that gets directory full name.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The directory full name.</returns>
    public static String GetDirectoryFullName(this FileInfo @this)
    {
        return @this.Directory.FullName;
    }
}