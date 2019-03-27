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
    ///     Converts the specified 64-bit signed integer, which contains an OLE Automation Currency value, to the
    ///     equivalent  value.
    /// </summary>
    /// <param name="cy">An OLE Automation Currency value.</param>
    /// <returns>A  that contains the equivalent of .</returns>
    public static Decimal FromOACurrency(this Int64 cy)
    {
        return Decimal.FromOACurrency(cy);
    }
}