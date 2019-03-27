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
    ///     A bool extension method that convert this object into a binary representation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A binary represenation of this object.</returns>
    public static byte ToBinary(this bool @this)
    {
        return Convert.ToByte(@this);
    }
}