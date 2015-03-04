// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts an array of 8-bit unsigned integers to its equivalent string representation that is encoded with
    ///     base-64 digits.
    /// </summary>
    /// <param name="inArray">An array of 8-bit unsigned integers.</param>
    /// <returns>The string representation, in base 64, of the contents of .</returns>
    public static String ToBase64String(this Byte[] inArray)
    {
        return Convert.ToBase64String(inArray);
    }

    /// <summary>
    ///     Converts an array of 8-bit unsigned integers to its equivalent string representation that is encoded with
    ///     base-64 digits. A parameter specifies whether to insert line breaks in the return value.
    /// </summary>
    /// <param name="inArray">An array of 8-bit unsigned integers.</param>
    /// <param name="options">to insert a line break every 76 characters, or  to not insert line breaks.</param>
    /// <returns>The string representation in base 64 of the elements in .</returns>
    public static String ToBase64String(this Byte[] inArray, Base64FormattingOptions options)
    {
        return Convert.ToBase64String(inArray, options);
    }

    /// <summary>
    ///     Converts a subset of an array of 8-bit unsigned integers to its equivalent string representation that is
    ///     encoded with base-64 digits. Parameters specify the subset as an offset in the input array, and the number of
    ///     elements in the array to convert.
    /// </summary>
    /// <param name="inArray">An array of 8-bit unsigned integers.</param>
    /// <param name="offset">An offset in .</param>
    /// <param name="length">The number of elements of  to convert.</param>
    /// <returns>The string representation in base 64 of  elements of , starting at position .</returns>
    public static String ToBase64String(this Byte[] inArray, Int32 offset, Int32 length)
    {
        return Convert.ToBase64String(inArray, offset, length);
    }

    /// <summary>
    ///     Converts a subset of an array of 8-bit unsigned integers to its equivalent string representation that is
    ///     encoded with base-64 digits. Parameters specify the subset as an offset in the input array, the number of
    ///     elements in the array to convert, and whether to insert line breaks in the return value.
    /// </summary>
    /// <param name="inArray">An array of 8-bit unsigned integers.</param>
    /// <param name="offset">An offset in .</param>
    /// <param name="length">The number of elements of  to convert.</param>
    /// <param name="options">to insert a line break every 76 characters, or  to not insert line breaks.</param>
    /// <returns>The string representation in base 64 of  elements of , starting at position .</returns>
    public static String ToBase64String(this Byte[] inArray, Int32 offset, Int32 length, Base64FormattingOptions options)
    {
        return Convert.ToBase64String(inArray, offset, length, options);
    }
}