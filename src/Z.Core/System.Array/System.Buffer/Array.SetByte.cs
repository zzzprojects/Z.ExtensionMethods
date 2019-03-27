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
    ///     Assigns a specified value to a byte at a particular location in a specified array.
    /// </summary>
    /// <param name="array">An array.</param>
    /// <param name="index">A location in the array.</param>
    /// <param name="value">A value to assign.</param>
    public static void SetByte(this Array array, Int32 index, Byte value)
    {
        Buffer.SetByte(array, index, value);
    }
}