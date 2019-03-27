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
    ///     Converts a time to the time in a particular time zone.
    /// </summary>
    /// <param name="dateTime">The date and time to convert.</param>
    /// <param name="destinationTimeZone">The time zone to convert  to.</param>
    /// <returns>The date and time in the destination time zone.</returns>
    public static DateTime ConvertTime(this DateTime dateTime, TimeZoneInfo destinationTimeZone)
    {
        return TimeZoneInfo.ConvertTime(dateTime, destinationTimeZone);
    }

    /// <summary>
    ///     Converts a time from one time zone to another.
    /// </summary>
    /// <param name="dateTime">The date and time to convert.</param>
    /// <param name="sourceTimeZone">The time zone of .</param>
    /// <param name="destinationTimeZone">The time zone to convert  to.</param>
    /// <returns>
    ///     The date and time in the destination time zone that corresponds to the  parameter in the source time zone.
    /// </returns>
    public static DateTime ConvertTime(this DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone)
    {
        return TimeZoneInfo.ConvertTime(dateTime, sourceTimeZone, destinationTimeZone);
    }
}