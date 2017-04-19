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
    ///     Returns the largest integer less than or equal to the specified double-precision floating-point number.
    /// </summary>
    /// <param name="d">A double-precision floating-point number.</param>
    /// <returns>The largest integer less than or equal to . If  is equal to , , or , that value is returned.</returns>
    public static Double Floor(this Double d)
    {
        return Math.Floor(d);
    }
}