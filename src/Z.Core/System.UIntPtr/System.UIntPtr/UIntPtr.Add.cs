// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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