// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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