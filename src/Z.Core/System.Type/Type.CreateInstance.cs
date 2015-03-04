// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Globalization;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     A Type extension method that creates an instance.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="bindingAttr">The binding attribute.</param>
    /// <param name="binder">The binder.</param>
    /// <param name="args">The arguments.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The new instance.</returns>
    public static T CreateInstance<T>(this Type @this, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture)
    {
        return (T) Activator.CreateInstance(@this, bindingAttr, binder, args, culture);
    }

    /// <summary>
    ///     A Type extension method that creates an instance.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="bindingAttr">The binding attribute.</param>
    /// <param name="binder">The binder.</param>
    /// <param name="args">The arguments.</param>
    /// <param name="culture">The culture.</param>
    /// <param name="activationAttributes">The activation attributes.</param>
    /// <returns>The new instance.</returns>
    public static T CreateInstance<T>(this Type @this, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture, Object[] activationAttributes)
    {
        return (T) Activator.CreateInstance(@this, bindingAttr, binder, args, culture, activationAttributes);
    }

    /// <summary>
    ///     A Type extension method that creates an instance.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="args">The arguments.</param>
    /// <returns>The new instance.</returns>
    public static T CreateInstance<T>(this Type @this, Object[] args)
    {
        return (T) Activator.CreateInstance(@this, args);
    }

    /// <summary>
    ///     A Type extension method that creates an instance.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="args">The arguments.</param>
    /// <param name="activationAttributes">The activation attributes.</param>
    /// <returns>The new instance.</returns>
    public static T CreateInstance<T>(this Type @this, Object[] args, Object[] activationAttributes)
    {
        return (T) Activator.CreateInstance(@this, args, activationAttributes);
    }

    /// <summary>
    ///     A Type extension method that creates an instance.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The new instance.</returns>
    public static T CreateInstance<T>(this Type @this)
    {
        return (T) Activator.CreateInstance(@this);
    }

    /// <summary>
    ///     A Type extension method that creates an instance.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="nonPublic">true to non public.</param>
    /// <returns>The new instance.</returns>
    public static T CreateInstance<T>(this Type @this, Boolean nonPublic)
    {
        return (T) Activator.CreateInstance(@this, nonPublic);
    }
}