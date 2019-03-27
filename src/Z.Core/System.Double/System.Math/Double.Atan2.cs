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
    ///     Returns the angle whose tangent is the quotient of two specified numbers.
    /// </summary>
    /// <param name="y">The y coordinate of a point.</param>
    /// <param name="x">The x coordinate of a point.</param>
    /// <returns>
    ///     An angle, ?, measured in radians, such that -?????, and tan(?) =  / , where (, ) is a point in the Cartesian
    ///     plane. Observe the following: For (, ) in quadrant 1, 0 &lt; ? &lt; ?/2.For (, ) in quadrant 2, ?/2 &lt;
    ///     ???.For (, ) in quadrant 3, -? &lt; ? &lt; -?/2.For (, ) in quadrant 4, -?/2 &lt; ? &lt; 0.For points on the
    ///     boundaries of the quadrants, the return value is the following:If y is 0 and x is not negative, ? = 0.If y is
    ///     0 and x is negative, ? = ?.If y is positive and x is 0, ? = ?/2.If y is negative and x is 0, ? = -?/2.If  or
    ///     is , or if  and  are either  or , the method returns .
    /// </returns>
    public static Double Atan2(this Double y, Double x)
    {
        return Math.Atan2(y, x);
    }
}