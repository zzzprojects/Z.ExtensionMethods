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
    ///     Converts a time to the time in another time zone based on the time zone&#39;s identifier.
    /// </summary>
    /// <param name="dateTime">The date and time to convert.</param>
    /// <param name="destinationTimeZoneId">The identifier of the destination time zone.</param>
    /// <returns>The date and time in the destination time zone.</returns>
    public static DateTime ConvertTimeBySystemTimeZoneId(this DateTime dateTime, String destinationTimeZoneId)
    {
        return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, destinationTimeZoneId);
    }

    /// <summary>
    ///     Converts a time from one time zone to another based on time zone identifiers.
    /// </summary>
    /// <param name="dateTime">The date and time to convert.</param>
    /// <param name="sourceTimeZoneId">The identifier of the source time zone.</param>
    /// <param name="destinationTimeZoneId">The identifier of the destination time zone.</param>
    /// <returns>
    ///     The date and time in the destination time zone that corresponds to the  parameter in the source time zone.
    /// </returns>
    public static DateTime ConvertTimeBySystemTimeZoneId(this DateTime dateTime, String sourceTimeZoneId, String destinationTimeZoneId)
    {
        return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, sourceTimeZoneId, destinationTimeZoneId);
    }
}