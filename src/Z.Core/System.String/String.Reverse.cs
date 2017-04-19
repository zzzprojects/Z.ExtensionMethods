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
    ///     A string extension method that reverses the given string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The string reversed.</returns>
    public static string Reverse(this string @this)
    {
        if (@this.Length <= 1)
        {
            return @this;
        }

        char[] chars = @this.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}