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
    ///     Returns a value that indicates whether the specified value is not a number ().
    /// </summary>
    /// <param name="f">A single-precision floating-point number.</param>
    /// <returns>true if  evaluates to not a number (); otherwise, false.</returns>
    public static Boolean IsNaN(this Single f)
    {
        return Single.IsNaN(f);
    }
}