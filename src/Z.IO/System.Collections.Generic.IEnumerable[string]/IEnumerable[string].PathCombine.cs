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
    ///     An IEnumerable&lt;string&gt; extension method that combine all value to return a path.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The path.</returns>
    public static string PathCombine(this IEnumerable<string> @this)
    {
        return Path.Combine(@this.ToArray());
    }
}