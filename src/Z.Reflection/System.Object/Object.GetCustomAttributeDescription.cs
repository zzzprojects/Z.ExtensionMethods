// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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