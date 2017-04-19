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
    ///     A DateTime extension method that query if 'date' is date equal.
    /// </summary>
    /// <param name="date">The date to act on.</param>
    /// <param name="dateToCompare">Date/Time of the date to compare.</param>
    /// <returns>true if date equal, false if not.</returns>
    public static bool IsDateEqual(this DateTime date, DateTime dateToCompare)
    {
        return (date.Date == dateToCompare.Date);
    }
}