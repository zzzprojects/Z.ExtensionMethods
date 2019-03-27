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
    ///     Converts the value of the specified  to the equivalent 32-bit unsigned integer.
    /// </summary>
    /// <param name="d">The decimal number to convert.</param>
    /// <returns>A 32-bit unsigned integer equivalent to the value of .</returns>
    public static UInt32 ToUInt32(this Decimal d)
    {
        return Decimal.ToUInt32(d);
    }
}