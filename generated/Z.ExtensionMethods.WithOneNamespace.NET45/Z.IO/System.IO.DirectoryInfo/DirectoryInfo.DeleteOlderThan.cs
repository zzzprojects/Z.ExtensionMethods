namespace Z.ExtensionMethods
{

using System;
using System.IO;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     A DirectoryInfo extension method that deletes the older than.
    /// </summary>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="timeSpan">The time span.</param>
    public static void DeleteOlderThan(this DirectoryInfo obj, TimeSpan timeSpan)
    {
        DateTime minDate = DateTime.Now.Subtract(timeSpan);
        obj.GetFiles().Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
        obj.GetDirectories().Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
    }

    /// <summary>
    ///     A DirectoryInfo extension method that deletes the older than.
    /// </summary>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="searchOption">The search option.</param>
    /// <param name="timeSpan">The time span.</param>
    public static void DeleteOlderThan(this DirectoryInfo obj, SearchOption searchOption, TimeSpan timeSpan)
    {
        DateTime minDate = DateTime.Now.Subtract(timeSpan);
        obj.GetFiles("*.*", searchOption).Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
        obj.GetDirectories("*.*", searchOption).Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
    }
}

}