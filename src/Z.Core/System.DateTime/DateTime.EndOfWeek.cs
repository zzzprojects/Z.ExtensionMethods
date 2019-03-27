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
    ///     A System.DateTime extension method that ends of week.
    /// </summary>
    /// <param name="dt">Date/Time of the dt.</param>
    /// <param name="startDayOfWeek">(Optional) the start day of week.</param>
    /// <returns>A DateTime.</returns>
    public static DateTime EndOfWeek(this DateTime dt, DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
    {
        DateTime end = dt;
        DayOfWeek endDayOfWeek = startDayOfWeek - 1;
        if (endDayOfWeek < 0)
        {
            endDayOfWeek = DayOfWeek.Saturday;
        }

        if (end.DayOfWeek != endDayOfWeek)
        {
            if (endDayOfWeek < end.DayOfWeek)
            {
                end = end.AddDays(7 - (end.DayOfWeek - endDayOfWeek));
            }
            else
            {
                end = end.AddDays(endDayOfWeek - end.DayOfWeek);
            }
        }

        return new DateTime(end.Year, end.Month, end.Day, 23, 59, 59, 999);
    }
}