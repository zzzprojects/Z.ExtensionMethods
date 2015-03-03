using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

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
    public static IEnumerable<DirectoryInfo> ForEach(this IEnumerable<DirectoryInfo> @this, Action<DirectoryInfo> action)
    {
        foreach (DirectoryInfo t in @this)
        {
            action(t);
        }
        return @this;
    }
}

}