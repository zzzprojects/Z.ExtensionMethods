// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    ///     Concatenates all the elements of a IEnumerable, using the specified separator between each element.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">An IEnumerable that contains the elements to concatenate.</param>
    /// <param name="separator">
    ///     The string to use as a separator. separator is included in the returned string only if
    ///     value has more than one element.
    /// </param>
    /// <returns>
    ///     A string that consists of the elements in value delimited by the separator string. If value is an empty array,
    ///     the method returns String.Empty.
    /// </returns>
    public static string StringJoin<T>(this IEnumerable<T> @this, string separator)
    {
        return string.Join(separator, @this);
    }

    /// <summary>
    ///     Concatenates all the elements of a IEnumerable, using the specified separator between
    ///     each element.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="separator">
    ///     The string to use as a separator. separator is included in the
    ///     returned string only if value has more than one element.
    /// </param>
    /// <returns>
    ///     A string that consists of the elements in value delimited by the separator string. If
    ///     value is an empty array, the method returns String.Empty.
    /// </returns>
    public static string StringJoin<T>(this IEnumerable<T> @this, char separator)
    {
        return string.Join(separator.ToString(), @this);
    }
}