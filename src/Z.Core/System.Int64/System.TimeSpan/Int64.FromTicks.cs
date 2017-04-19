// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns a  that represents a specified time, where the specification is in units of ticks.
    /// </summary>
    /// <param name="value">A number of ticks that represent a time.</param>
    /// <returns>An object that represents .</returns>
    public static TimeSpan FromTicks(this Int64 value)
    {
        return TimeSpan.FromTicks(value);
    }
}