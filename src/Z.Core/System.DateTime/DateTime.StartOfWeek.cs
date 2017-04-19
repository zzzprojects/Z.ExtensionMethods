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
    ///     A DateTime extension method that starts of week.
    /// </summary>
    /// <param name="dt">The dt to act on.</param>
    /// <param name="startDayOfWeek">(Optional) the start day of week.</param>
    /// <returns>A DateTime.</returns>
    public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
    {
        var start = new DateTime(dt.Year, dt.Month, dt.Day);

        if (start.DayOfWeek != startDayOfWeek)
        {
            int d = startDayOfWeek - start.DayOfWeek;
            if (startDayOfWeek <= start.DayOfWeek)
            {
                return start.AddDays(d);
            }
            return start.AddDays(-7 + d);
        }

        return start;
    }
}