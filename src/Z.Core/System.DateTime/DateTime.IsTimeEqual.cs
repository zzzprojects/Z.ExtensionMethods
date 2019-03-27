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
    ///     A DateTime extension method that query if 'time' is time equal.
    /// </summary>
    /// <param name="time">The time to act on.</param>
    /// <param name="timeToCompare">Date/Time of the time to compare.</param>
    /// <returns>true if time equal, false if not.</returns>
    public static bool IsTimeEqual(this DateTime time, DateTime timeToCompare)
    {
        return (time.TimeOfDay == timeToCompare.TimeOfDay);
    }
}