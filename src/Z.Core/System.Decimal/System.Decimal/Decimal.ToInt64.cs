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
    ///     Converts the value of the specified  to the equivalent 64-bit signed integer.
    /// </summary>
    /// <param name="d">The decimal number to convert.</param>
    /// <returns>A 64-bit signed integer equivalent to the value of .</returns>
    public static Int64 ToInt64(this Decimal d)
    {
        return Decimal.ToInt64(d);
    }
}