// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Collections.Generic;
using System.Text;

public static partial class Extensions
{
    /// <summary>An IEnumerable&lt;string&gt; extension method that concatenates the given this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A string.</returns>
    public static string Concatenate(this IEnumerable<string> @this)
    {
        var sb = new StringBuilder();

        foreach (var s in @this)
        {
            sb.Append(s);
        }

        return sb.ToString();
    }

    /// <summary>An IEnumerable&lt;T&gt; extension method that concatenates.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="source">The source to act on.</param>
    /// <param name="func">The function.</param>
    /// <returns>A string.</returns>
    public static string Concatenate<T>(this IEnumerable<T> source, Func<T, string> func)
    {
        var sb = new StringBuilder();
        foreach (var item in source)
        {
            sb.Append(func(item));
        }

        return sb.ToString();
    }
}