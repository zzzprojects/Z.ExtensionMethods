// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Linq;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>An object extension method that gets custom attributes by name.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="name">The name.</param>
    /// <returns>An array of attribute.</returns>
    public static Attribute[] GetCustomAttributesByName(this object @this, string name)
    {
        var type = @this.GetType();

        return type.IsEnum ?
            type.GetField(@this.ToString()).GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray() :
            type.GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray();
    }

    /// <summary>An object extension method that gets custom attributes by name.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="name">The name.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>An array of attribute.</returns>
    public static object[] GetCustomAttributesByName(this object @this, string name, bool inherit)
    {
        var type = @this.GetType();

        return type.IsEnum ?
            type.GetField(@this.ToString()).GetCustomAttributes(inherit).Where(x => x.GetType().Name == name).ToArray() :
            type.GetCustomAttributes(inherit).Where(x => x.GetType().Name == name).ToArray();
    }

    /// <summary>An object extension method that gets custom attributes by name.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="name">The name.</param>
    /// <returns>An array of attribute.</returns>
    public static Attribute[] GetCustomAttributesByName(this MemberInfo @this, string name)
    {
        return @this.GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray();
    }

    /// <summary>An object extension method that gets custom attributes by name.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="name">The name.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>An array of attribute.</returns>
    public static object[] GetCustomAttributesByName(this MemberInfo @this, string name, bool inherit)
    {
        return @this.GetCustomAttributes(inherit).Where(x => x.GetType().Name == name).ToArray();
    }
}