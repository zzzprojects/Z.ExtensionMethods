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
    ///     An Int32 extension method that days the given this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A TimeSpan.</returns>
    public static TimeSpan Days(this Int32 @this)
    {
        return TimeSpan.FromDays(@this);
    }
}