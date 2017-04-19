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
    ///     Returns an indication whether the specified year is a leap year.
    /// </summary>
    /// <param name="year">A 4-digit year.</param>
    /// <returns>true if  is a leap year; otherwise, false.</returns>
    public static Boolean IsLeapYear(this Int32 year)
    {
        return DateTime.IsLeapYear(year);
    }
}