using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;
using System.IO;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     A DirectoryInfo extension method that deletes the directories where.
    /// </summary>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="predicate">The predicate.</param>
    public static void DeleteDirectoriesWhere(this DirectoryInfo obj, Func<DirectoryInfo, bool> predicate)
    {
        obj.GetDirectories().Where(predicate).ForEach(x => x.Delete());
    }

    /// <summary>
    ///     A DirectoryInfo extension method that deletes the directories where.
    /// </summary>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="searchOption">The search option.</param>
    /// <param name="predicate">The predicate.</param>
    public static void DeleteDirectoriesWhere(this DirectoryInfo obj, SearchOption searchOption, Func<DirectoryInfo, bool> predicate)
    {
        obj.GetDirectories("*.*", searchOption).Where(predicate).ForEach(x => x.Delete());
    }
}

}