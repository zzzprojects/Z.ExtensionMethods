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
    ///     Retrieves the byte at a specified location in a specified array.
    /// </summary>
    /// <param name="array">An array.</param>
    /// <param name="index">A location in the array.</param>
    /// <returns>Returns the  byte in the array.</returns>
    public static Byte GetByte(this Array array, Int32 index)
    {
        return Buffer.GetByte(array, index);
    }
}