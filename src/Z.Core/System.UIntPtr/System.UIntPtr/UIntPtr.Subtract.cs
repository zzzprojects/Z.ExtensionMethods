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
    ///     Subtracts an offset from the value of an unsigned pointer.
    /// </summary>
    /// <param name="pointer">The unsigned pointer to subtract the offset from.</param>
    /// <param name="offset">The offset to subtract.</param>
    /// <returns>A new unsigned pointer that reflects the subtraction of  from .</returns>
    public static UIntPtr Subtract(this UIntPtr pointer, Int32 offset)
    {
        return UIntPtr.Subtract(pointer, offset);
    }
}