// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Linq;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>An object extension method that gets custom attributes by full name.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="fullName">Name of the full.</param>
    /// <returns>An array of attribute.</returns>
    public static Attribute[] GetCustomAttributesByFullName(this object @this, string fullName)
    {
        var type = @this.GetType();

        return type.IsEnum ?
            type.GetField(@this.ToString()).GetCustomAttributes().Where(x => x.GetType().FullName == fullName).ToArray() :
            type.GetCustomAttributes().Where(x => x.GetType().FullName == fullName).ToArray();
    }

    /// <summary>An object extension method that gets custom attributes by full name.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="fullName">Name of the full.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>An array of attribute.</returns>
    public static object[] GetCustomAttributesByFullName(this object @this, string fullName, bool inherit)
    {
        var type = @this.GetType();

        return type.IsEnum ?
            type.GetField(@this.ToString()).GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName).ToArray() :
            type.GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName).ToArray();
    }

    /// <summary>An object extension method that gets custom attributes by full name.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="fullName">Name of the full.</param>
    /// <returns>An array of attribute.</returns>
    public static Attribute[] GetCustomAttributesByFullName(this MemberInfo @this, string fullName)
    {
        return @this.GetCustomAttributes().Where(x => x.GetType().FullName == fullName).ToArray();
    }

    /// <summary>An object extension method that gets custom attributes by full name.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="fullName">Name of the full.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>An array of attribute.</returns>
    public static object[] GetCustomAttributesByFullName(this MemberInfo @this, string fullName, bool inherit)
    {
        return @this.GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName).ToArray();
    }
}