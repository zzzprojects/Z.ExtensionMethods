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
    ///     Returns the angle whose tangent is the specified number.
    /// </summary>
    /// <param name="d">A number representing a tangent.</param>
    /// <returns>
    ///     An angle, ?, measured in radians, such that -?/2 ????/2.-or-  if  equals , -?/2 rounded to double precision (-
    ///     1.5707963267949) if  equals , or ?/2 rounded to double precision (1.5707963267949) if  equals .
    /// </returns>
    public static Double Atan(this Double d)
    {
        return Math.Atan(d);
    }
}