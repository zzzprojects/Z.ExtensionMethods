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
    /// A string extension method that checks if '@this' is equal to another string regardless of it's case.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="comparedString">The compared string.</param>
    /// <returns>
    /// true if it contains all values, otherwise false.
    /// </returns>
    public static bool EqualsIgnoreCase(this string @this, string comparedString)
    {
        return @this.Equals(comparedString, StringComparison.OrdinalIgnoreCase);
    }
}