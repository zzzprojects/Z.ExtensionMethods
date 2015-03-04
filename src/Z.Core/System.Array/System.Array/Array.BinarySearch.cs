// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Collections;

public static partial class Extensions
{
    /// <summary>
    ///     Searches an entire one-dimensional sorted  for a specific element, using the  interface implemented by each
    ///     element of the  and by the specified object.
    /// </summary>
    /// <param name="array">The sorted one-dimensional  to search.</param>
    /// <param name="value">The object to search for.</param>
    /// <returns>
    ///     The index of the specified  in the specified , if  is found. If  is not found and  is less than one or more
    ///     elements in , a negative number which is the bitwise complement of the index of the first element that is
    ///     larger than . If  is not found and  is greater than any of the elements in , a negative number which is the
    ///     bitwise complement of (the index of the last element plus 1).
    /// </returns>
    public static Int32 BinarySearch(this Array array, Object value)
    {
        return Array.BinarySearch(array, value);
    }

    /// <summary>
    ///     Searches a range of elements in a one-dimensional sorted  for a value, using the  interface implemented by
    ///     each element of the  and by the specified value.
    /// </summary>
    /// <param name="array">The sorted one-dimensional  to search.</param>
    /// <param name="index">The starting index of the range to search.</param>
    /// <param name="length">The length of the range to search.</param>
    /// <param name="value">The object to search for.</param>
    /// <returns>
    ///     The index of the specified  in the specified , if  is found. If  is not found and  is less than one or more
    ///     elements in , a negative number which is the bitwise complement of the index of the first element that is
    ///     larger than . If  is not found and  is greater than any of the elements in , a negative number which is the
    ///     bitwise complement of (the index of the last element plus 1).
    /// </returns>
    public static Int32 BinarySearch(this Array array, Int32 index, Int32 length, Object value)
    {
        return Array.BinarySearch(array, index, length, value);
    }

    /// <summary>
    ///     Searches an entire one-dimensional sorted  for a value using the specified  interface.
    /// </summary>
    /// <param name="array">The sorted one-dimensional  to search.</param>
    /// <param name="value">The object to search for.</param>
    /// <param name="comparer">
    ///     The  implementation to use when comparing elements.-or- null to use the  implementation
    ///     of each element.
    /// </param>
    /// <returns>
    ///     The index of the specified  in the specified , if  is found. If  is not found and  is less than one or more
    ///     elements in , a negative number which is the bitwise complement of the index of the first element that is
    ///     larger than . If  is not found and  is greater than any of the elements in , a negative number which is the
    ///     bitwise complement of (the index of the last element plus 1).
    /// </returns>
    public static Int32 BinarySearch(this Array array, Object value, IComparer comparer)
    {
        return Array.BinarySearch(array, value, comparer);
    }

    /// <summary>
    ///     Searches a range of elements in a one-dimensional sorted  for a value, using the specified  interface.
    /// </summary>
    /// <param name="array">The sorted one-dimensional  to search.</param>
    /// <param name="index">The starting index of the range to search.</param>
    /// <param name="length">The length of the range to search.</param>
    /// <param name="value">The object to search for.</param>
    /// <param name="comparer">
    ///     The  implementation to use when comparing elements.-or- null to use the  implementation
    ///     of each element.
    /// </param>
    /// <returns>
    ///     The index of the specified  in the specified , if  is found. If  is not found and  is less than one or more
    ///     elements in , a negative number which is the bitwise complement of the index of the first element that is
    ///     larger than . If  is not found and  is greater than any of the elements in , a negative number which is the
    ///     bitwise complement of (the index of the last element plus 1).
    /// </returns>
    public static Int32 BinarySearch(this Array array, Int32 index, Int32 length, Object value, IComparer comparer)
    {
        return Array.BinarySearch(array, index, length, value, comparer);
    }
}