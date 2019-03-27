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
    ///     A DateTime extension method that return a DateTime of the last day of the year with the time set to
    ///     "23:59:59:999". The last moment of the last day of the year.  Use "DateTime2" column type in sql to keep the
    ///     precision.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTime of the last day of the year with the time set to "23:59:59:999".</returns>
    public static DateTime EndOfYear(this DateTime @this)
    {
        return new DateTime(@this.Year, 1, 1).AddYears(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
    }
}