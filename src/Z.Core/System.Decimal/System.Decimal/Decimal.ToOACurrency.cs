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
    ///     Converts the specified  value to the equivalent OLE Automation Currency value, which is contained in a 64-bit
    ///     signed integer.
    /// </summary>
    /// <param name="value">The decimal number to convert.</param>
    /// <returns>A 64-bit signed integer that contains the OLE Automation equivalent of .</returns>
    public static Int64 ToOACurrency(this Decimal value)
    {
        return Decimal.ToOACurrency(value);
    }
}