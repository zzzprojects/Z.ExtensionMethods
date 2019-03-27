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
    ///     Returns the remainder resulting from the division of a specified number by another specified number.
    /// </summary>
    /// <param name="x">A dividend.</param>
    /// <param name="y">A divisor.</param>
    /// <returns>
    ///     A number equal to  - ( Q), where Q is the quotient of  /  rounded to the nearest integer (if  /  falls
    ///     halfway between two integers, the even integer is returned).If  - ( Q) is zero, the value +0 is returned if
    ///     is positive, or -0 if  is negative.If  = 0,  is returned.
    /// </returns>
    public static Double IEEERemainder(this Double x, Double y)
    {
        return Math.IEEERemainder(x, y);
    }
}