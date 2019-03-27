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
    ///     Returns the smaller of two 32-bit unsigned integers.
    /// </summary>
    /// <param name="val1">The first of two 32-bit unsigned integers to compare.</param>
    /// <param name="val2">The second of two 32-bit unsigned integers to compare.</param>
    /// <returns>Parameter  or , whichever is smaller.</returns>
    public static UInt32 Min(this UInt32 val1, UInt32 val2)
    {
        return Math.Min(val1, val2);
    }
}