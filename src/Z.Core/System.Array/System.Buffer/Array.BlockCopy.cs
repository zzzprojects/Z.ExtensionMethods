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
    ///     Copies a specified number of bytes from a source array starting at a particular offset to a destination array
    ///     starting at a particular offset.
    /// </summary>
    /// <param name="src">The source buffer.</param>
    /// <param name="srcOffset">The zero-based byte offset into .</param>
    /// <param name="dst">The destination buffer.</param>
    /// <param name="dstOffset">The zero-based byte offset into .</param>
    /// <param name="count">The number of bytes to copy.</param>
    public static void BlockCopy(this Array src, Int32 srcOffset, Array dst, Int32 dstOffset, Int32 count)
    {
        Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
    }
}