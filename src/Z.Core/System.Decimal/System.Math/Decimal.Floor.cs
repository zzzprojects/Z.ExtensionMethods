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
    ///     Returns the largest integer less than or equal to the specified decimal number.
    /// </summary>
    /// <param name="d">A decimal number.</param>
    /// <returns>
    ///     The largest integer less than or equal to .  Note that the method returns an integral value of type .
    /// </returns>
    public static Decimal Floor(this Decimal d)
    {
        return Math.Floor(d);
    }
}