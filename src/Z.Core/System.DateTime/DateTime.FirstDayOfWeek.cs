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
    ///     A DateTime extension method that first day of week.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTime.</returns>
    public static DateTime FirstDayOfWeek(this DateTime @this)
    {
        return new DateTime(@this.Year, @this.Month, @this.Day).AddDays(-(int) @this.DayOfWeek);
    }
}