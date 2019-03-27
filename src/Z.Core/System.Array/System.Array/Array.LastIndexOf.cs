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
    ///     Searches for the specified object and returns the index of the last occurrence within the entire one-
    ///     dimensional .
    /// </summary>
    /// <param name="array">The one-dimensional  to search.</param>
    /// <param name="value">The object to locate in .</param>
    /// <returns>
    ///     The index of the last occurrence of  within the entire , if found; otherwise, the lower bound of the array
    ///     minus 1.
    /// </returns>
    public static Int32 LastIndexOf(this Array array, Object value)
    {
        return Array.LastIndexOf(array, value);
    }

    /// <summary>
    ///     Searches for the specified object and returns the index of the last occurrence within the range of elements
    ///     in the one-dimensional  that extends from the first element to the specified index.
    /// </summary>
    /// <param name="array">The one-dimensional  to search.</param>
    /// <param name="value">The object to locate in .</param>
    /// <param name="startIndex">The starting index of the backward search.</param>
    /// <returns>
    ///     The index of the last occurrence of  within the range of elements in  that extends from the first element to ,
    ///     if found; otherwise, the lower bound of the array minus 1.
    /// </returns>
    public static Int32 LastIndexOf(this Array array, Object value, Int32 startIndex)
    {
        return Array.LastIndexOf(array, value, startIndex);
    }

    /// <summary>
    ///     Searches for the specified object and returns the index of the last occurrence within the range of elements
    ///     in the one-dimensional  that contains the specified number of elements and ends at the specified index.
    /// </summary>
    /// <param name="array">The one-dimensional  to search.</param>
    /// <param name="value">The object to locate in .</param>
    /// <param name="startIndex">The starting index of the backward search.</param>
    /// <param name="count">The number of elements in the section to search.</param>
    /// <returns>
    ///     The index of the last occurrence of  within the range of elements in  that contains the number of elements
    ///     specified in  and ends at , if found; otherwise, the lower bound of the array minus 1.
    /// </returns>
    public static Int32 LastIndexOf(this Array array, Object value, Int32 startIndex, Int32 count)
    {
        return Array.LastIndexOf(array, value, startIndex, count);
    }
}