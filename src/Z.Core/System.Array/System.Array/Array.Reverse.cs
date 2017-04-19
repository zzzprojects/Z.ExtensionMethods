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