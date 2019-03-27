// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Text;

public static partial class Extensions
{
    /// <summary>A StringBuilder extension method that appends a join.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="separator">The separator.</param>
    /// <param name="values">The values.</param>
    public static StringBuilder AppendJoin<T>(this StringBuilder @this, string separator, IEnumerable<T> values)
    {
        @this.Append(string.Join(separator, values));

        return @this;
    }

    /// <summary>A StringBuilder extension method that appends a join.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="separator">The separator.</param>
    /// <param name="values">The values.</param>
    public static StringBuilder AppendJoin<T>(this StringBuilder @this, string separator, params T[] values)
    {
        @this.Append(string.Join(separator, values));

        return @this;
    }
}