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
    ///     An object extension method that query if '@this' is attribute defined.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="attributeType">Type of the attribute.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>true if attribute defined, false if not.</returns>
    public static bool IsAttributeDefined(this object @this, Type attributeType, bool inherit)
    {
        return @this.GetType().IsDefined(attributeType, inherit);
    }

    /// <summary>
    ///     An object extension method that query if '@this' is attribute defined.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>true if attribute defined, false if not.</returns>
    public static bool IsAttributeDefined<T>(this object @this, bool inherit) where T : Attribute
    {
        return @this.GetType().IsDefined(typeof (T), inherit);
    }
}