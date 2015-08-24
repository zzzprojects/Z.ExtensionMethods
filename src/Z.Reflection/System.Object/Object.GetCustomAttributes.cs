// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>An object extension method that gets custom attributes.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An array of object.</returns>
    public static Attribute[] GetCustomAttributes(this object @this)
    {
        var type = @this.GetType();

        return type.IsEnum ?
            type.GetField(@this.ToString()).GetCustomAttributes() :
            type.GetCustomAttributes();
    }

    /// <summary>
    ///     An object extension method that gets custom attributes.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>An array of object.</returns>
    public static object[] GetCustomAttributes(this object @this, bool inherit)
    {
        var type = @this.GetType();

        return type.IsEnum ?
            type.GetField(@this.ToString()).GetCustomAttributes(inherit) :
            type.GetCustomAttributes(inherit);
    }

    /// <summary>An object extension method that gets custom attributes.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An array of object.</returns>
    public static T[] GetCustomAttributes<T>(this object @this) where T : Attribute
    {
        var type = @this.GetType();

        return (T[]) (type.IsEnum ?
            type.GetField(@this.ToString()).GetCustomAttributes(typeof (T)) :
            type.GetCustomAttributes(typeof (T)));
    }

    /// <summary>
    ///     An object extension method that gets custom attributes.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>An array of object.</returns>
    public static T[] GetCustomAttributes<T>(this object @this, bool inherit) where T : Attribute
    {
        var type = @this.GetType();

        return (T[]) (type.IsEnum ?
            type.GetField(@this.ToString()).GetCustomAttributes(typeof (T), inherit) :
            type.GetCustomAttributes(typeof (T), inherit));
    }

    /// <summary>An object extension method that gets custom attributes.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An array of object.</returns>
    public static T[] GetCustomAttributes<T>(this MemberInfo @this) where T : Attribute
    {
        return (T[]) @this.GetCustomAttributes(typeof (T));
    }

    /// <summary>An object extension method that gets custom attributes.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>An array of object.</returns>
    public static T[] GetCustomAttributes<T>(this MemberInfo @this, bool inherit) where T : Attribute
    {
        return (T[]) @this.GetCustomAttributes(typeof (T), inherit);
    }
}