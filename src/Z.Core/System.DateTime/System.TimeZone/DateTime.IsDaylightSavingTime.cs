// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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