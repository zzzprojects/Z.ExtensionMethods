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
    ///     Converts a Coordinated Universal Time (UTC) to the time in a specified time zone.
    /// </summary>
    /// <param name="dateTime">The Coordinated Universal Time (UTC).</param>
    /// <param name="destinationTimeZone">The time zone to convert  to.</param>
    /// <returns>
    ///     The date and time in the destination time zone. Its  property is  if  is ; otherwise, its  property is .
    /// </returns>
    public static DateTime ConvertTimeFromUtc(this DateTime dateTime, TimeZoneInfo destinationTimeZone)
    {
        return TimeZoneInfo.ConvertTimeFromUtc(dateTime, destinationTimeZone);
    }
}