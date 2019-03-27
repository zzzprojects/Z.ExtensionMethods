// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    ///     A T[] extension method that searches for the first index.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="array">The array to act on.</param>
    /// <param name="match">Specifies the match.</param>
    /// <returns>The found index.</returns>
    public static Int32 FindIndex<T>(this T[] array, Predicate<T> match)
    {
        return Array.FindIndex(array, match);
    }

    /// <summary>
    ///     A T[] extension method that searches for the first index.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="array">The array to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="match">Specifies the match.</param>
    /// <returns>The found index.</returns>
    public static Int32 FindIndex<T>(this T[] array, Int32 startIndex, Predicate<T> match)
    {
        return Array.FindIndex(array, startIndex, match);
    }

    /// <summary>
    ///     A T[] extension method that searches for the first index.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="array">The array to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="count">Number of.</param>
    /// <param name="match">Specifies the match.</param>
    /// <returns>The found index.</returns>
    public static Int32 FindIndex<T>(this T[] array, Int32 startIndex, Int32 count, Predicate<T> match)
    {
        return Array.FindIndex(array, startIndex, count, match);
    }
}