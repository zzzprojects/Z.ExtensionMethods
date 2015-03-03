namespace Z.ExtensionMethods
{

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

}