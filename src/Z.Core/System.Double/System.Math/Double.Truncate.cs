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
    ///     Calculates the integral part of a specified double-precision floating-point number.
    /// </summary>
    /// <param name="d">A number to truncate.</param>
    /// <returns>
    ///     The integral part of ; that is, the number that remains after any fractional digits have been discarded, or
    ///     one of the values listed in the following table. Return value.
    /// </returns>
    public static Double Truncate(this Double d)
    {
        return Math.Truncate(d);
    }
}