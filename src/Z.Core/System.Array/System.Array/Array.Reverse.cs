// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;

public static partial class Extensions
{
    /// <summary>
    ///     Reverses the sequence of the elements in the entire one-dimensional .
    /// </summary>
    /// <param name="array">The one-dimensional  to reverse.</param>
    public static void Reverse(this Array array)
    {
        Array.Reverse(array);
    }

    /// <summary>
    ///     Reverses the sequence of the elements in a range of elements in the one-dimensional .
    /// </summary>
    /// <param name="array">The one-dimensional  to reverse.</param>
    /// <param name="index">The starting index of the section to reverse.</param>
    /// <param name="length">The number of elements in the section to reverse.</param>
    public static void Reverse(this Array array, Int32 index, Int32 length)
    {
        Array.Reverse(array, index, length);
    }
}