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
    ///     Returns e raised to the specified power.
    /// </summary>
    /// <param name="d">A number specifying a power.</param>
    /// <returns>
    ///     The number e raised to the power . If  equals  or , that value is returned. If  equals , 0 is returned.
    /// </returns>
    public static Double Exp(this Double d)
    {
        return Math.Exp(d);
    }
}