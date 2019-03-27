// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     Combines multiples string into a path.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="paths">A variable-length parameters list containing paths.</param>
    /// <returns>
    ///     The combined paths. If one of the specified paths is a zero-length string, this method returns the other path.
    /// </returns>
    public static string PathCombine(this string @this, params string[] paths)
    {
        List<string> list = paths.ToList();
        list.Insert(0, @this);
        return Path.Combine(list.ToArray());
    }
}