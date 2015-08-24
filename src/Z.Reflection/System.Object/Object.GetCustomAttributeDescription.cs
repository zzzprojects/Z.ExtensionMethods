// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.ComponentModel;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that gets description attribute.
    /// </summary>
    /// <param name="value">The value to act on.</param>
    /// <returns>The description attribute.</returns>
    public static string GetCustomAttributeDescription(this object value)
    {
        var type = value.GetType();

        var attributes = type.IsEnum ?
            type.GetField(value.ToString()).GetCustomAttributes(typeof (DescriptionAttribute)) :
            type.GetCustomAttributes(typeof (DescriptionAttribute));

        if (attributes.Length == 0)
        {
            return null;
        }
        if (attributes.Length == 1)
        {
            return ((DescriptionAttribute) attributes[0]).Description;
        }

        throw new Exception(string.Format("Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.", attributes.Length));
    }

    /// <summary>An object extension method that gets description attribute.</summary>
    /// <param name="value">The value to act on.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>The description attribute.</returns>
    public static string GetCustomAttributeDescription(this object value, bool inherit)
    {
        var type = value.GetType();

        var attributes = type.IsEnum ?
            type.GetField(value.ToString()).GetCustomAttributes(typeof (DescriptionAttribute), inherit) :
            type.GetCustomAttributes(typeof (DescriptionAttribute));

        if (attributes.Length == 0)
        {
            return null;
        }
        if (attributes.Length == 1)
        {
            return ((DescriptionAttribute) attributes[0]).Description;
        }

        throw new Exception(string.Format("Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.", attributes.Length));
    }

    /// <summary>An object extension method that gets description attribute.</summary>
    /// <param name="value">The value to act on.</param>
    /// <returns>The description attribute.</returns>
    public static string GetCustomAttributeDescription(this MemberInfo value)
    {
        var attributes = value.GetCustomAttributes(typeof (DescriptionAttribute));

        if (attributes.Length == 0)
        {
            return null;
        }
        if (attributes.Length == 1)
        {
            return ((DescriptionAttribute) attributes[0]).Description;
        }

        throw new Exception(string.Format("Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.", attributes.Length));
    }

    /// <summary>An object extension method that gets description attribute.</summary>
    /// <param name="value">The value to act on.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>The description attribute.</returns>
    public static string GetCustomAttributeDescription(this MemberInfo value, bool inherit)
    {
        var attributes = value.GetCustomAttributes(typeof (DescriptionAttribute), inherit);

        if (attributes.Length == 0)
        {
            return null;
        }
        if (attributes.Length == 1)
        {
            return ((DescriptionAttribute) attributes[0]).Description;
        }

        throw new Exception(string.Format("Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.", attributes.Length));
    }
}