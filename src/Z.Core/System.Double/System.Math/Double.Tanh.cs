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
    ///     Returns the hyperbolic tangent of the specified angle.
    /// </summary>
    /// <param name="value">An angle, measured in radians.</param>
    /// <returns>
    ///     The hyperbolic tangent of . If  is equal to , this method returns -1. If value is equal to , this method
    ///     returns 1. If  is equal to , this method returns .
    /// </returns>
    public static Double Tanh(this Double value)
    {
        return Math.Tanh(value);
    }
}