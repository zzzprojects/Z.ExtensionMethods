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
    ///     Divides two specified  values.
    /// </summary>
    /// <param name="d1">The dividend.</param>
    /// <param name="d2">The divisor.</param>
    /// <returns>The result of dividing  by .</returns>
    public static Decimal Divide(this Decimal d1, Decimal d2)
    {
        return Decimal.Divide(d1, d2);
    }
}