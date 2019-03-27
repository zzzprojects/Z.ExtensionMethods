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
    ///     Returns the smallest integral value that is greater than or equal to the specified decimal number.
    /// </summary>
    /// <param name="d">A decimal number.</param>
    /// <returns>
    ///     The smallest integral value that is greater than or equal to . Note that this method returns a  instead of an
    ///     integral type.
    /// </returns>
    public static Decimal Ceiling(this Decimal d)
    {
        return Math.Ceiling(d);
    }
}