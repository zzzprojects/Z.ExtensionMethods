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
    /// <summary>A DirectoryInfo extension method that copies to.</summary>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="destDirName">Pathname of the destination directory.</param>
    public static void CopyTo(this DirectoryInfo obj, string destDirName)
    {
        obj.CopyTo(destDirName, "*.*", SearchOption.TopDirectoryOnly);
    }

    /// <summary>A DirectoryInfo extension method that copies to.</summary>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="destDirName">Pathname of the destination directory.</param>
    /// <param name="searchPattern">A pattern specifying the search.</param>
    public static void CopyTo(this DirectoryInfo obj, string destDirName, string searchPattern)
    {
        obj.CopyTo(destDirName, searchPattern, SearchOption.TopDirectoryOnly);
    }

    /// <summary>A DirectoryInfo extension method that copies to.</summary>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="destDirName">Pathname of the destination directory.</param>
    /// <param name="searchOption">The search option.</param>
    public static void CopyTo(this DirectoryInfo obj, string destDirName, SearchOption searchOption)
    {
        obj.CopyTo(destDirName, "*.*", searchOption);
    }

    /// <summary>A DirectoryInfo extension method that copies to.</summary>
    /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="destDirName">Pathname of the destination directory.</param>
    /// <param name="searchPattern">A pattern specifying the search.</param>
    /// <param name="searchOption">The search option.</param>
    public static void CopyTo(this DirectoryInfo obj, string destDirName, string searchPattern, SearchOption searchOption)
    {
        var files = obj.GetFiles(searchPattern, searchOption);
        foreach (var file in files)
        {
            var outputFile = destDirName + file.FullName.Substring(obj.FullName.Length);
            var directory = new FileInfo(outputFile).Directory;

            if (directory == null)
            {
                throw new Exception("The directory cannot be null.");
            }

            if (!directory.Exists)
            {
                directory.Create();
            }

            file.CopyTo(outputFile);
        }

        // Ensure empty dir are also copied
        var directories = obj.GetDirectories(searchPattern, searchOption);
        foreach (var directory in directories)
        {
            var outputDirectory = destDirName + directory.FullName.Substring(obj.FullName.Length);
            var directoryInfo = new DirectoryInfo(outputDirectory);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }
    }
}