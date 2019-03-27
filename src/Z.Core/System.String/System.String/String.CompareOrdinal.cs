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
    ///     Compares two specified  objects by evaluating the numeric values of the corresponding  objects in each string.
    /// </summary>
    /// <param name="strA">The first string to compare.</param>
    /// <param name="strB">The second string to compare.</param>
    /// <returns>
    ///     An integer that indicates the lexical relationship between the two comparands.ValueCondition Less than zero
    ///     is less than . Zero  and  are equal. Greater than zero  is greater than .
    /// </returns>
    public static Int32 CompareOrdinal(this String strA, String strB)
    {
        return String.CompareOrdinal(strA, strB);
    }

    /// <summary>
    ///     Compares substrings of two specified  objects by evaluating the numeric values of the corresponding  objects
    ///     in each substring.
    /// </summary>
    /// <param name="strA">The first string to use in the comparison.</param>
    /// <param name="indexA">The starting index of the substring in .</param>
    /// <param name="strB">The second string to use in the comparison.</param>
    /// <param name="indexB">The starting index of the substring in .</param>
    /// <param name="length">The maximum number of characters in the substrings to compare.</param>
    /// <returns>
    ///     A 32-bit signed integer that indicates the lexical relationship between the two comparands.ValueCondition
    ///     Less than zero The substring in  is less than the substring in . Zero The substrings are equal, or  is zero.
    ///     Greater than zero The substring in  is greater than the substring in .
    /// </returns>
    public static Int32 CompareOrdinal(this String strA, Int32 indexA, String strB, Int32 indexB, Int32 length)
    {
        return String.CompareOrdinal(strA, indexA, strB, indexB, length);
    }
}