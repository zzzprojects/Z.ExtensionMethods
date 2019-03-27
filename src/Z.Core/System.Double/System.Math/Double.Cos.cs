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
    ///     Returns the cosine of the specified angle.
    /// </summary>
    /// <param name="d">An angle, measured in radians.</param>
    /// <returns>The cosine of . If  is equal to , , or , this method returns .</returns>
    public static Double Cos(this Double d)
    {
        return Math.Cos(d);
    }
}