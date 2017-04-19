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
    ///     An object extension method that query if '@this' is assignable from.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if assignable from, false if not.</returns>
    public static bool IsAssignableFrom<T>(this object @this)
    {
        Type type = @this.GetType();
        return type.IsAssignableFrom(typeof (T));
    }

    /// <summary>
    ///     An object extension method that query if '@this' is assignable from.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="targetType">Type of the target.</param>
    /// <returns>true if assignable from, false if not.</returns>
    public static bool IsAssignableFrom(this object @this, Type targetType)
    {
        Type type = @this.GetType();
        return type.IsAssignableFrom(targetType);
    }
}