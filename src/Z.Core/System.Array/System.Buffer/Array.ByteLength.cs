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
    ///     Returns the number of bytes in the specified array.
    /// </summary>
    /// <param name="array">An array.</param>
    /// <returns>The number of bytes in the array.</returns>
    public static Int32 ByteLength(this Array array)
    {
        return Buffer.ByteLength(array);
    }
}