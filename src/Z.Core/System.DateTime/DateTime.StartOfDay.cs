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
    ///     A DateTime extension method that return a DateTime with the time set to "00:00:00:000". The first moment of
    ///     the day.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTime of the day with the time set to "00:00:00:000".</returns>
    public static DateTime StartOfDay(this DateTime @this)
    {
        return new DateTime(@this.Year, @this.Month, @this.Day);
    }
}