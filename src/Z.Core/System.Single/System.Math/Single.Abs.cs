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
    ///     Returns the absolute value of a single-precision floating-point number.
    /// </summary>
    /// <param name="value">A number that is greater than or equal to , but less than or equal to .</param>
    /// <returns>A single-precision floating-point number, x, such that 0 ? x ?.</returns>
    public static Single Abs(this Single value)
    {
        return Math.Abs(value);
    }
}