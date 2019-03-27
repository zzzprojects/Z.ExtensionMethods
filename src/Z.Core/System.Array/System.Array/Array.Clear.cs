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
    ///     Sets a range of elements in the  to zero, to false, or to null, depending on the element type.
    /// </summary>
    /// <param name="array">The  whose elements need to be cleared.</param>
    /// <param name="index">The starting index of the range of elements to clear.</param>
    /// <param name="length">The number of elements to clear.</param>
    public static void Clear(this Array array, Int32 index, Int32 length)
    {
        Array.Clear(array, index, length);
    }
}