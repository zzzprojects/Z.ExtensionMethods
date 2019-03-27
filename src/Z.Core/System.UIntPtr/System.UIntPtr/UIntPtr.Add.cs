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
    ///     Adds an offset to the value of an unsigned pointer.
    /// </summary>
    /// <param name="pointer">The unsigned pointer to add the offset to.</param>
    /// <param name="offset">The offset to add.</param>
    /// <returns>A new unsigned pointer that reflects the addition of  to .</returns>
    public static UIntPtr Add(this UIntPtr pointer, Int32 offset)
    {
        return UIntPtr.Add(pointer, offset);
    }
}