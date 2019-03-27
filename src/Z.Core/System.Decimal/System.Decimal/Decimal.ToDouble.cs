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
    ///     Converts the value of the specified  to the equivalent double-precision floating-point number.
    /// </summary>
    /// <param name="d">The decimal number to convert.</param>
    /// <returns>A double-precision floating-point number equivalent to .</returns>
    public static Double ToDouble(this Decimal d)
    {
        return Decimal.ToDouble(d);
    }
}