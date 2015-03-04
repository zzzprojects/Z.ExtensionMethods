// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     An Assembly extension method that gets an attribute.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The attribute.</returns>
    public static T GetAttribute<T>(this Assembly @this) where T : Attribute
    {
        object[] configAttributes = Attribute.GetCustomAttributes(@this, typeof (T), false);

        if (configAttributes != null && configAttributes.Length > 0)
        {
            return (T) configAttributes[0];
        }

        return null;
    }
}