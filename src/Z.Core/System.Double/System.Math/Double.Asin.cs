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
    ///     Returns the angle whose sine is the specified number.
    /// </summary>
    /// <param name="d">
    ///     A number representing a sine, where  must be greater than or equal to -1, but less than or equal
    ///     to 1.
    /// </param>
    /// <returns>
    ///     An angle, ?, measured in radians, such that -?/2 ????/2 -or-  if  &lt; -1 or  &gt; 1 or  equals .
    /// </returns>
    public static Double Asin(this Double d)
    {
        return Math.Asin(d);
    }
}