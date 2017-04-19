// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Globalization;

public static partial class Extensions
{
    /// <summary>
    ///     Returns a value indicating whether the specified date and time is within the specified daylight saving time
    ///     period.
    /// </summary>
    /// <param name="time">A date and time.</param>
    /// <param name="daylightTimes">A daylight saving time period.</param>
    /// <returns>true if  is in ; otherwise, false.</returns>
    public static Boolean IsDaylightSavingTime(this DateTime time, DaylightTime daylightTimes)
    {
        return TimeZone.IsDaylightSavingTime(time, daylightTimes);
    }
}