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
    ///     Returns a  that represents a specified number of seconds, where the specification is accurate to the nearest
    ///     millisecond.
    /// </summary>
    /// <param name="value">A number of seconds, accurate to the nearest millisecond.</param>
    /// <returns>An object that represents .</returns>
    public static TimeSpan FromSeconds(this Double value)
    {
        return TimeSpan.FromSeconds(value);
    }
}