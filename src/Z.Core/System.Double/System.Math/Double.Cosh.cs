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
    ///     Returns the hyperbolic cosine of the specified angle.
    /// </summary>
    /// <param name="value">An angle, measured in radians.</param>
    /// <returns>The hyperbolic cosine of . If  is equal to  or ,  is returned. If  is equal to ,  is returned.</returns>
    public static Double Cosh(this Double value)
    {
        return Math.Cosh(value);
    }
}