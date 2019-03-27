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
    ///     Subtracts one specified  value from another.
    /// </summary>
    /// <param name="d1">The minuend.</param>
    /// <param name="d2">The subtrahend.</param>
    /// <returns>The result of subtracting  from .</returns>
    public static Decimal Subtract(this Decimal d1, Decimal d2)
    {
        return Decimal.Subtract(d1, d2);
    }
}