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
    ///     Returns a  that represents a specified number of milliseconds.
    /// </summary>
    /// <param name="value">A number of milliseconds.</param>
    /// <returns>An object that represents .</returns>
    public static TimeSpan FromMilliseconds(this Double value)
    {
        return TimeSpan.FromMilliseconds(value);
    }
}