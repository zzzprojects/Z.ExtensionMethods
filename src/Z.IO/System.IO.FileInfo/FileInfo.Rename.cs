// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     A FileInfo extension method that renames.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="newName">Name of the new.</param>
    /// ###
    /// <returns>.</returns>
    public static void Rename(this FileInfo @this, string newName)
    {
        string filePath = Path.Combine(@this.Directory.FullName, newName);
        @this.MoveTo(filePath);
    }
}