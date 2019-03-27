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
    ///     Sets the time of the current date with minute precision.
    /// </summary>
    /// <param name="current">The current date.</param>
    /// <param name="hour">The hour.</param>
    /// <returns>A DateTimeOffset.</returns>
    public static DateTimeOffset SetTime(this DateTimeOffset current, int hour)
    {
        return SetTime(current, hour, 0, 0, 0);
    }

    /// <summary>
    ///     Sets the time of the current date with minute precision.
    /// </summary>
    /// <param name="current">The current date.</param>
    /// <param name="hour">The hour.</param>
    /// <param name="minute">The minute.</param>
    /// <returns>A DateTimeOffset.</returns>
    public static DateTimeOffset SetTime(this DateTimeOffset current, int hour, int minute)
    {
        return SetTime(current, hour, minute, 0, 0);
    }

    /// <summary>
    ///     Sets the time of the current date with second precision.
    /// </summary>
    /// <param name="current">The current date.</param>
    /// <param name="hour">The hour.</param>
    /// <param name="minute">The minute.</param>
    /// <param name="second">The second.</param>
    /// <returns>A DateTimeOffset.</returns>
    public static DateTimeOffset SetTime(this DateTimeOffset current, int hour, int minute, int second)
    {
        return SetTime(current, hour, minute, second, 0);
    }

    /// <summary>
    ///     Sets the time of the current date with millisecond precision.
    /// </summary>
    /// <param name="current">The current date.</param>
    /// <param name="hour">The hour.</param>
    /// <param name="minute">The minute.</param>
    /// <param name="second">The second.</param>
    /// <param name="millisecond">The millisecond.</param>
    /// <returns>A DateTimeOffset.</returns>
    public static DateTimeOffset SetTime(this DateTimeOffset current, int hour, int minute, int second, int millisecond)
    {
        return new DateTime(current.Year, current.Month, current.Day, hour, minute, second, millisecond);
    }
}