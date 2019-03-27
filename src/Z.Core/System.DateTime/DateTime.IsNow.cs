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
    ///     A DateTime extension method that query if '@this' is now.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if now, false if not.</returns>
    public static bool IsNow(this DateTime @this)
    {
        return @this == DateTime.Now;
    }
}