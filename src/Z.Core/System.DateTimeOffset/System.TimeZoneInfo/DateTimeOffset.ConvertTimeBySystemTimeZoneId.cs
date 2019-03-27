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
    /// <param name="dateTimeOffset">The date and time to convert.</param>
    /// <param name="destinationTimeZoneId">The identifier of the destination time zone.</param>
    /// <returns>The date and time in the destination time zone.</returns>
    public static DateTimeOffset ConvertTimeBySystemTimeZoneId(this DateTimeOffset dateTimeOffset, String destinationTimeZoneId)
    {
        return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTimeOffset, destinationTimeZoneId);
    }
}