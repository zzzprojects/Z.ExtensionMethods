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
    ///     Returns the number of days in the specified month and year.
    /// </summary>
    /// <param name="year">The year.</param>
    /// <param name="month">The month (a number ranging from 1 to 12).</param>
    /// <returns>
    ///     The number of days in  for the specified .For example, if  equals 2 for February, the return value is 28 or
    ///     29 depending upon whether  is a leap year.
    /// </returns>
    public static Int32 DaysInMonth(this Int32 year, Int32 month)
    {
        return DateTime.DaysInMonth(year, month);
    }
}