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
    ///     Converts the value of a specified instance of  to its equivalent binary representation.
    /// </summary>
    /// <param name="d">The value to convert.</param>
    /// <returns>A 32-bit signed integer array with four elements that contain the binary representation of .</returns>
    public static Int32[] GetBits(this Decimal d)
    {
        return Decimal.GetBits(d);
    }
}