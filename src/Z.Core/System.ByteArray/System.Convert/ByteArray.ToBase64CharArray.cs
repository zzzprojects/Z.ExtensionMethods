// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array
    ///     encoded with base-64 digits. Parameters specify the subsets as offsets in the input and output arrays, and
    ///     the number of elements in the input array to convert.
    /// </summary>
    /// <param name="inArray">An input array of 8-bit unsigned integers.</param>
    /// <param name="offsetIn">A position within .</param>
    /// <param name="length">The number of elements of  to convert.</param>
    /// <param name="outArray">An output array of Unicode characters.</param>
    /// <param name="offsetOut">A position within .</param>
    /// <returns>A 32-bit signed integer containing the number of bytes in .</returns>
    public static Int32 ToBase64CharArray(this Byte[] inArray, Int32 offsetIn, Int32 length, Char[] outArray, Int32 offsetOut)
    {
        return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut);
    }

    /// <summary>
    ///     Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array
    ///     encoded with base-64 digits. Parameters specify the subsets as offsets in the input and output arrays, the
    ///     number of elements in the input array to convert, and whether line breaks are inserted in the output array.
    /// </summary>
    /// <param name="inArray">An input array of 8-bit unsigned integers.</param>
    /// <param name="offsetIn">A position within .</param>
    /// <param name="length">The number of elements of  to convert.</param>
    /// <param name="outArray">An output array of Unicode characters.</param>
    /// <param name="offsetOut">A position within .</param>
    /// <param name="options">to insert a line break every 76 characters, or  to not insert line breaks.</param>
    /// <returns>A 32-bit signed integer containing the number of bytes in .</returns>
    public static Int32 ToBase64CharArray(this Byte[] inArray, Int32 offsetIn, Int32 length, Char[] outArray, Int32 offsetOut, Base64FormattingOptions options)
    {
        return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut, options);
    }
}