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
    ///     A TimeSpan extension method that add the specified TimeSpan to the current UTC (Coordinated Universal Time)
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The current UTC (Coordinated Universal Time) with the specified TimeSpan added to it.</returns>
    public static DateTime UtcFromNow(this TimeSpan @this)
    {
        return DateTime.UtcNow.Add(@this);
    }
}