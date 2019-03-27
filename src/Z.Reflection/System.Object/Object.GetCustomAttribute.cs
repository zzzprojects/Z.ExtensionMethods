// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>An object extension method that gets the first custom attribute.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="attribute">The attribute.</param>
    /// <returns>The custom attribute.</returns>
    public static object GetCustomAttribute(this object @this, Type attribute)
    {
        var type = @this.GetType();

        return type.IsEnum ?
            Attribute.GetCustomAttribute(type.GetField(@this.ToString()), attribute) :
            Attribute.GetCustomAttribute(type, attribute);
    }

    /// <summary>
    ///     An object extension method that gets the first custom attribute.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="attribute">The attribute.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>The custom attribute.</returns>
    public static object GetCustomAttribute(this object @this, Type attribute, bool inherit)
    {
        var type = @this.GetType();

        return type.IsEnum ?
            Attribute.GetCustomAttribute(type.GetField(@this.ToString()), attribute, inherit) :
            Attribute.GetCustomAttribute(type, attribute, inherit);
    }

    /// <summary>An object extension method that gets custom attribute.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The custom attribute.</returns>
    public static T GetCustomAttribute<T>(this object @this) where T : Attribute
    {
        var type = @this.GetType();

        return (T) (type.IsEnum ?
            Attribute.GetCustomAttribute(type.GetField(@this.ToString()), typeof (T)) :
            Attribute.GetCustomAttribute(type, typeof (T)));
    }

    /// <summary>
    ///     An object extension method that gets custom attribute.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>The custom attribute.</returns>
    public static T GetCustomAttribute<T>(this object @this, bool inherit) where T : Attribute
    {
        var type = @this.GetType();

        return (T) (type.IsEnum ?
            Attribute.GetCustomAttribute(type.GetField(@this.ToString()), typeof (T), inherit) :
            Attribute.GetCustomAttribute(type, typeof (T), inherit));
    }

    /// <summary>An object extension method that gets custom attribute.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The custom attribute.</returns>
    public static T GetCustomAttribute<T>(this MemberInfo @this) where T : Attribute
    {
        return (T) Attribute.GetCustomAttribute(@this, typeof (T));
    }

    /// <summary>An object extension method that gets custom attribute.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>The custom attribute.</returns>
    public static T GetCustomAttribute<T>(this MemberInfo @this, bool inherit) where T : Attribute
    {
        return (T) Attribute.GetCustomAttribute(@this, typeof (T), inherit);
    }
}