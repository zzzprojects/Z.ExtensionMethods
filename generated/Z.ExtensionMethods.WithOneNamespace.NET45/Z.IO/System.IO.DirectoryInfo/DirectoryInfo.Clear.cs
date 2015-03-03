namespace Z.ExtensionMethods
{

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

}